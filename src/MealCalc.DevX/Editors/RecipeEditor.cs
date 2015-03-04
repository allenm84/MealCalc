using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public class RecipeEditor : IEditor
  {
    public bool AddValue(IWin32Window owner, out object newValue)
    {
      bool retval = false;
      newValue = null;

      var r = Factory.NewRecipe("<New Recipe>");
      using (var dlg = new EditRecipeDialog(r))
      {
        dlg.Text = "Add Recipe";
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          retval = true;
          newValue = r;
        }
      }

      return retval;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      bool retval = false;
      editedValue = null;

      var r = original as Recipe;
      var copy = r.Duplicate();
      using (var dlg = new EditRecipeDialog(copy))
      {
        dlg.Text = "Edit Recipe";
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          retval = true;
          editedValue = copy;
        }
      }

      return retval;
    }
  }
}
