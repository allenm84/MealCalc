using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public class CategoryEditor : IEditor
  {
    public bool AddValue(IWin32Window owner, out object newValue)
    {
      bool retval = false;
      newValue = null;

      string name;
      if (TextInputDialog.Show(owner, "Name:", "Add Category", out name) == DialogResult.OK)
      {
        newValue = Factory.NewCategory(name);
        retval = true;
      }

      return retval;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      bool retval = false;
      editedValue = null;

      var category = original as Category;
      string name;

      if (TextInputDialog.Show(owner, "Name:", "Edit Category", category.Name, out name) == DialogResult.OK)
      {
        var copy = category.Duplicate();
        copy.Name = name;
        editedValue = copy;
        retval = true;
      }

      return retval;
    }
  }
}
