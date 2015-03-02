using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Common.Extensions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public partial class EditRecipeDialog : BaseForm
  {
    static readonly int EntireRecipe;
    static readonly int CutIntoParts;
    static readonly int UseServingSize;

    static EditRecipeDialog()
    {
      EntireRecipe = BitVector32.CreateMask();
      CutIntoParts = BitVector32.CreateMask(EntireRecipe);
      UseServingSize = BitVector32.CreateMask(CutIntoParts);
    }

    private Recipe recipe;
    private BindingList<IngredientRef> ingredients;

    private List<Ingredient> addedIngredients;
    private List<Category> addedCategories;

    private BitVector32 optionState = new BitVector32(0);
    private int lastState = -1;

    public IEnumerable<Ingredient> NewIngredients
    {
      get
      {
        foreach (var ingredient in addedIngredients)
        {
          yield return ingredient;
        }
      }
    }

    public IEnumerable<Category> NewCategories
    {
      get
      {
        foreach (var category in addedCategories)
        {
          yield return category;
        }
      }
    }

    public EditRecipeDialog()
    {
      InitializeComponent();
    }

    public void BindTo(Recipe recipe)
    {
      this.recipe = recipe;
      addedIngredients = new List<Ingredient>();
      addedCategories = new List<Category>();

      recipe.Ingredients.Sort(CompareReferences);
      ingredients = new BindingList<IngredientRef>(recipe.Ingredients);
      ingredients.ListChanged += ingredients_ListChanged;

      ctrlEditServing.Hydrate(Factory.NewServing());
      txtName.DataBindings.Add("Text", recipe, "Name");

      chkFavorite.CheckedChanged += chkFavorite_CheckedChanged;
      chkFavorite.Checked = recipe.Favorite;
    }

    private int CompareReferences(IngredientRef a, IngredientRef b)
    {
      var ia = Accessor.GetIngredient(a.IngredientID, addedIngredients, SaveFile.Instance.Ingredients);
      var ib = Accessor.GetIngredient(b.IngredientID, addedIngredients, SaveFile.Instance.Ingredients);
      return string.Compare(ia.Name, ib.Name);
    }

    private void EditIngredientByRow(DataGridViewRow row)
    {
      if (row == null) return;
      EditIngredient(row.DataBoundItem as IngredientRef);
    }

    private void EditIngredient(IngredientRef ingredient)
    {
      if (ingredient == null) return;

      using (var dlg = new EditServingDialog())
      {
        dlg.Hydrate(ingredient.Serving);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dlg.Dehydrate(ingredient.Serving);
          var index = ingredients.IndexOf(ingredient);
          ingredients.ResetItem(index);
        }
      }
    }

    private bool UpdateState()
    {
      optionState[EntireRecipe] = optEntireRecipe.Checked;
      optionState[CutIntoParts] = optCutIntoParts.Checked;
      optionState[UseServingSize] = optServingSize.Checked;

      int state = optionState.Data;
      bool retval = (state != lastState);

      lastState = state;
      return retval;
    }

    private void UpdateNutritionalDisplay(bool force = true)
    {
      numParts.Enabled = optCutIntoParts.Checked;
      ctrlEditServing.Enabled = optServingSize.Checked;

      if (UpdateState() || force)
      {
        var info = Calculator.CalculateNutritionalInfo(ingredients, addedIngredients, SaveFile.Instance.Ingredients);
        if (optCutIntoParts.Checked)
        {
          info = Calculator.Divide(info, numParts.Value);
        }
        else if (optServingSize.Checked)
        {
          try
          {
            var size = Factory.NewServing();
            ctrlEditServing.Dehydrate(size);
            size = Calculator.ToCups(size);

            decimal divisor = 0;
            if (size.Amount > 0)
            {
              divisor = info.ServingSize.Amount / size.Amount;
            }

            if (divisor != 0)
            {
              info = Calculator.Divide(info, divisor);
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show(this,
              string.Format("Unable to calculate because {0}. Please let me know.", ex.Message),
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
          }
        }
        ctrlViewNutritionalInfo.Populate(info);
      }
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridIngredients.SelectedRows.Count == 1;
      btnRemove.Enabled = gridIngredients.SelectedRows.Count > 0;
      btnClear.Enabled = ingredients.Count > 0;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      gridIngredients.SetPropertiesToList(true, false);
      gridIngredients.DataSource = ingredients;
      gridIngredients.Columns.HideAllExcept("IngredientID");
      UpdateNutritionalDisplay();
      UpdateButtons();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (DialogResult == System.Windows.Forms.DialogResult.OK)
      {
        if (ingredients.Count == 0)
        {
          var result = MessageBox.Show(this, 
            "If you exit without adding ingredients then your changes will be cancelled. Would you like to add ingredients?", 
            "No Ingredients",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == System.Windows.Forms.DialogResult.No)
          {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
          }
          else
          {
            e.Cancel = true;
          }
        }
      }
      base.OnFormClosing(e);
    }

    private void ingredients_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateNutritionalDisplay();
    }

    private void chkFavorite_CheckedChanged(object sender, EventArgs e)
    {
      recipe.Favorite = chkFavorite.Checked;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      using (var dlg = new SelectIngredientDialog())
      {
        dlg.Populate(addedIngredients, SaveFile.Instance.Ingredients);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          addedCategories.AddRange(dlg.NewCategories);
          addedIngredients.AddRange(dlg.NewIngredients);

          var ingredient = dlg.SelectedIngredient;
          var serving = dlg.ServingSize;

          var index = ingredients.FirstIndex(r => string.Equals(r.IngredientID, ingredient.ID));
          if (index > -1)
          {
            var match = ingredients[index];
            var result = MessageBox.Show(this, "This ingredient is already added. Would you like to combine it with the existing ingredient?", "Combine",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.No) return;

            if (match.Serving.Type != serving.Type)
            {
              serving = Calculator.ToCups(serving);
              match.Serving = Calculator.ToCups(match.Serving);
            }

            match.Serving.Amount += serving.Amount;
            ingredients.ResetItem(index);
          }
          else
          {
            var reference = new IngredientRef
            {
              IngredientID = ingredient.ID,
              Serving = serving,
            };

            var added = false;
            for (int i = 0; !added && i < ingredients.Count; ++i)
            {
              if (CompareReferences(reference, ingredients[i]) < 0)
              {
                added = true;
                ingredients.Insert(i, reference);
              }
            }

            if (!added)
            {
              ingredients.Add(reference);
            }
          }
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var row = gridIngredients.CurrentRow;
      EditIngredientByRow(row);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "Are you sure you want to remove the selected ingredients?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      var selected = gridIngredients
        .SelectedRows
        .Cast<DataGridViewRow>()
        .Select(r => r.DataBoundItem as IngredientRef)
        .ToArray();

      using (var defer = ingredients.DeferBinding())
      {
        foreach (var item in selected)
        {
          ingredients.Remove(item);
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "Are you sure you want to clear all ingredients?", "Clear",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      ingredients.Clear();
    }

    private void gridIngredients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (-1 < e.RowIndex && e.RowIndex < gridIngredients.Rows.Count)
      {
        var row = gridIngredients.Rows[e.RowIndex];
        EditIngredientByRow(row);
      }
    }

    private void option_CheckedChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay(false);
    }

    private void numParts_ValueChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }

    private void ctrlEditServing_IsDirtyChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }

    private void gridIngredients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.ColumnIndex == gridIngredients.Columns["IngredientID"].Index)
      {
        var row = gridIngredients.Rows[e.RowIndex];
        var ingredient = row.DataBoundItem as IngredientRef;
        e.FormattingApplied = true;
        e.Value = string.Format("{0} {1}{2} of {3}{2}",
          ingredient.Serving.Amount,
          ingredient.Serving.Type,
          ingredient.Serving.Amount == 1m ? "" : "s",
          Accessor.GetIngredient(ingredient.IngredientID, addedIngredients, SaveFile.Instance.Ingredients).Name);
      }
    }

    private void gridIngredients_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void ctrlEditServing_ServingChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }
  }
}
