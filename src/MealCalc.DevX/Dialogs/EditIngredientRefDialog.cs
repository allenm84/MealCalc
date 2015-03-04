using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;

namespace MealCalc.DevX
{
  public partial class EditIngredientRefDialog : BaseForm
  {
    public string IngredientID
    {
      get { return cboIngredients.EditValue as string; }
      set { cboIngredients.EditValue = value; }
    }

    public Serving Serving
    {
      get
      {
        var s = Factory.NewServing();
        ctrlEditServing.Dehydrate(s);
        return s;
      }
      set { ctrlEditServing.Hydrate(value); }
    }

    public EditIngredientRefDialog(IList ingredients)
    {
      InitializeComponent();
      ingredientSource.DataSource = ingredients;
    }

    private void cboIngredients_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      string name = cboIngredientsView.FindFilterText;
      if(string.IsNullOrWhiteSpace(name))
      {
        name = "<New Ingredient>";
      }

      var ingredient = Factory.NewIngredient(name);

      using (var dlg = new EditIngredientDialog(ingredient, SaveFile.Instance.Categories))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          ingredientSource.Add(ingredient);
          e.NewValue = ingredient.ID;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(IngredientID))
      {
        cancelClose = true;
        MessageHelper.Inform(this, "Please select an ingredient");
      }
    }
  }
}