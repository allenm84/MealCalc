using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public class IngredientEditor : IEditor
  {
    private readonly BindingList<Category> categories;

    public IngredientEditor(IList<Category> categories)
    {
      this.categories = new BindingList<Category>(categories);
    }

    public bool AddValue(IWin32Window owner, out object newValue)
    {
      bool retval = false;
      newValue = null;

      var ingredient = Factory.NewIngredient("<New Ingredient>");
      using (var dlg = new EditIngredientDialog(ingredient, categories))
      {
        dlg.Text = "Add Ingredient";
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          newValue = ingredient;
          retval = true;
        }
      }

      return retval;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      bool retval = false;
      editedValue = null;

      var i = original as Ingredient;
      var copy = i.Duplicate();

      using (var dlg = new EditIngredientDialog(copy, categories))
      {
        dlg.Text = "Edit Ingredient";
        if (dlg.ShowDialog(owner) == DialogResult.OK)
        {
          editedValue = copy;
          retval = true;
        }
      }

      return retval;
    }
  }
}
