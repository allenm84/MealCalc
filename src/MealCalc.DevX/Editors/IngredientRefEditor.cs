using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public class IngredientRefEditor : IEditor
  {
    private readonly IList ingredients;

    public IngredientRefEditor(IList ingredients)
    {
      this.ingredients = ingredients;
    }

    public bool AddValue(IWin32Window owner, out object newValue)
    {
      bool retval = false;
      newValue = null;

      using (var dlg = new EditIngredientRefDialog(ingredients))
      {
        dlg.Text = "Add Ingredient";
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          newValue = Factory.NewIngredientReference(dlg.IngredientID, dlg.Serving);
          retval = true;
        }
      }

      return retval;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      bool retval = false;
      editedValue = null;

      var i = original as IngredientRef;
      using (var dlg = new EditIngredientRefDialog(ingredients))
      {
        dlg.Text = "Edit Ingredient";
        dlg.IngredientID = i.IngredientID;
        dlg.Serving = i.Serving;
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          editedValue = Factory.NewIngredientReference(dlg.IngredientID, dlg.Serving);
          retval = true;
        }
      }

      return retval;
    }
  }
}
