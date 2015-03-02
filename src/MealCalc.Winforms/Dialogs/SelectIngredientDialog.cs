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

namespace MealCalc.Winforms
{
  public partial class SelectIngredientDialog : BaseForm
  {
    static PropertyInfo[] ingredientProperties;
    static SelectIngredientDialog()
    {
      ingredientProperties = typeof(Ingredient).GetProperties();
    }

    private List<Ingredient> addedIngredients;
    private List<Category> addedCategories;
    private DataTable ingredients;

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
        return gridIngredients.CurrentRow.Cells["Tag"].Value as Ingredient;
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

      ingredients = new DataTable("Ingredients");
      foreach (var property in ingredientProperties)
      {
        var column = new DataColumn();
        column.ColumnName = property.Name;
        column.DataType = property.PropertyType;
        ingredients.Columns.Add(column);
      }
      ingredients.Columns.Add("Tag", typeof(object));

      foreach (var ingredient in sources.SelectMany(s => s))
      {
        AddIngredient(ingredient);
      }
    }

    private DataRow AddIngredient(Ingredient ingredient)
    {
      var values = ingredientProperties.Select(p => p.GetValue(ingredient)).ToList();
      values.Add(ingredient);
      return ingredients.Rows.Add(values.ToArray());
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      gridIngredients.SetPropertiesToList(false, false);
      gridIngredients.DataSource = ingredients;
      gridIngredients.Columns.HideAllExcept("Name");
      ingredients.DefaultView.Sort = "Name";
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

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtFilter.Text))
      {
        ingredients.DefaultView.RowFilter = null;
      }
      else
      {
        ingredients.DefaultView.RowFilter = string.Format("Name LIKE '*{0}*'", txtFilter.Text);
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      using (var dlg = new EditIngredientDialog())
      {
        string name = txtFilter.Text;
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

          var row = AddIngredient(ingredient);
          var index = ingredients.Rows.IndexOf(row);
          gridIngredients.Rows[index].Selected = true;

          addedIngredients.Add(ingredient);
          addedCategories.AddRange(dlg.NewCategories);
        }
      }
    }

    private void gridIngredients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      DialogResult = System.Windows.Forms.DialogResult.OK;
      Close();
    }
  }
}
