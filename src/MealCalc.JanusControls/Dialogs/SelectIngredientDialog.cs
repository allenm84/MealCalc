using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.JanusControls
{
  public partial class SelectIngredientDialog : BaseForm
  {
    private List<Ingredient> addedIngredients;
    private List<Category> addedCategories;
    private BindingList<Ingredient> ingredients;

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

    public Ingredient SelectedIngredient
    {
      get
      {
        return gridIngredients.CurrentRow.DataRow as Ingredient;
      }
    }

    public Serving ServingSize
    {
      get
      {
        Serving serving = new Serving();
        ctrlEditServing.Dehydrate(serving);
        return serving;
      }
    }

    public SelectIngredientDialog()
    {
      InitializeComponent();
      addedIngredients = new List<Ingredient>();
      addedCategories = new List<Category>();
    }

    public void Populate(params IEnumerable<Ingredient>[] sources)
    {
      ctrlEditServing.Hydrate(Factory.NewServing());

      ingredients = new BindingList<Ingredient>();
      ingredients.AddRange(sources.SelectMany(s => s));
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      gridIngredients.SetPropertiesToList(false, false);
      gridIngredients.SetPropertiesToShowFilterRow();
      gridIngredients.DataSource = ingredients;
      gridIngredients.RetrieveStructure();
      gridIngredients.RootTable.Columns.HideAllExcept("Name");
      gridIngredients.RootTable.SortKeys.Add("Name");
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (DialogResult == System.Windows.Forms.DialogResult.OK)
      {
        if (!ctrlEditServing.ValidateServing())
        {
          var result = MessageBox.Show(this, "An invalid serving was entered. If you exit now, your selection will be lost. Do you want to correct the serving?",
            "Invalid Serving",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
          if (result == System.Windows.Forms.DialogResult.No)
          {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
          }
          else
          {
            e.Cancel = true;
          }
        }
        else if (gridIngredients.CurrentRow == null)
        {
          var result = MessageBox.Show(this, "An ingredient hasn't been select. If you exit now, your selection will be lost. Do you want to update your selection?",
            "Invalid Selection",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
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

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      using (var dlg = new EditIngredientDialog())
      {
        string name = gridIngredients.RootTable.GetFilterText();
        if (string.IsNullOrWhiteSpace(name))
        {
          name = "<New Ingredient>";
        }

        var ingredient = Factory.NewIngredient(name);
        dlg.Hydrate(ingredient);
        dlg.Text = "Create New Ingredient";

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dlg.Dehydrate(ingredient);
          ingredients.Add(ingredient);

          var row = gridIngredients.GetRow(ingredient);
          gridIngredients.MoveTo(row);

          addedIngredients.Add(ingredient);
          addedCategories.AddRange(dlg.NewCategories);
        }
      }
    }

    private void gridIngredients_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
    {
      DialogResult = System.Windows.Forms.DialogResult.OK;
      Close();
    }

    private void gridIngredients_SelectionChanged(object sender, EventArgs e)
    {
      if (gridIngredients.CurrentRow == null) return;
      var ingredient = SelectedIngredient;

      if (ingredient == null) return;
      ctrlEditServing.MeasurementVisible = !ingredient.Info.NoMeasurement;
    }
  }
}
