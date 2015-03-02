using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MealCalc.JanusControls
{
  public partial class EditIngredientsDialog : BaseForm
  {
    private BindingList<Ingredient> ingredients = new BindingList<Ingredient>();
    private List<Category> addedCategories = new List<Category>();

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

    public IEnumerable<Ingredient> Ingredients
    {
      get
      {
        foreach (var ingredient in ingredients)
        {
          yield return ingredient;
        }
      }
    }

    public void Hydrate(IEnumerable<Ingredient> ingredients)
    {
      this.ingredients.AddRange(ingredients);
    }

    public EditIngredientsDialog()
    {
      InitializeComponent();
      ingredients.ListChanged += ingredients_ListChanged;
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridIngredients.SelectedItems.Count == 1;
      btnClear.Enabled = ingredients.Count > 0;
      btnRemove.Enabled = gridIngredients.SelectedItems.Count > 0;
      btnRename.Enabled = btnEdit.Enabled;
    }

    private void EditIngredientByRow(GridEXRow row)
    {
      if (row == null) return;
      EditIngredient(row.DataRow as Ingredient);
    }

    private void EditIngredient(Ingredient ingredient)
    {
      if (ingredient == null) return;

      using (var dlg = new EditIngredientDialog())
      {
        dlg.Text = string.Concat("Edit ", ingredient.Name);
        dlg.Hydrate(ingredient);
        dlg.AddCategories(addedCategories);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dlg.Dehydrate(ingredient);
          var index = ingredients.IndexOf(ingredient);
          ingredients.ResetItem(index);
          addedCategories.AddRange(dlg.NewCategories);
        }
      }
    }

    private void RenameCurrentIngredient()
    {
      var row = gridIngredients.CurrentRow;
      if (row == null) return;

      var ingredient = row.DataRow as Ingredient;
      if (ingredient == null) return;

      string input;
      if (TextInputDialog.Show(this, "Name:", "Rename Ingredient", ingredient.Name, out input) == System.Windows.Forms.DialogResult.OK)
      {
        ingredient.Name = input;
        var index = ingredients.IndexOf(ingredient);
        ingredients.ResetItem(index);
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      gridIngredients.SelectionChanged += gridIngredients_SelectionChanged;
      gridIngredients.SetPropertiesToList(true, false);
      gridIngredients.DataSource = ingredients;
      gridIngredients.RetrieveStructure();
      gridIngredients.RootTable.Columns.HideAllExcept("Name");
      gridIngredients.RootTable.SortKeys.Add("Name");
      UpdateButtons();
    }

    private void ingredients_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridIngredients_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string name = "<New Ingredient>";
      var ingredient = Factory.NewIngredient(name);
      using (var dlg = new EditIngredientDialog())
      {
        dlg.Text = "Create New Ingredient";
        dlg.Hydrate(ingredient);
        dlg.AddCategories(addedCategories);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dlg.Dehydrate(ingredient);
          ingredients.Add(ingredient);
          addedCategories.AddRange(dlg.NewCategories);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditIngredientByRow(gridIngredients.CurrentRow);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var selected = gridIngredients
        .GetSelectedItems<Ingredient>()
        .ToArray();
      if (selected.Length < 1) return;

      var result = MessageBox.Show(this, "Are you sure you want to delete the selected ingredients?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      using (var defer = ingredients.DeferBinding())
      {
        ingredients.RemoveRange(selected);
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      if (ingredients.Count == 0) return;

      var result = MessageBox.Show(this, "Are you sure you want to clear all ingredients?", "Clear",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      ingredients.Clear();
    }

    private void btnRename_Click(object sender, EventArgs e)
    {
      RenameCurrentIngredient();
    }

    private void gridIngredients_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
      {
        RenameCurrentIngredient();
      }
    }

    private void gridIngredients_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
    {
      EditIngredientByRow(e.Row);
    }
  }
}
