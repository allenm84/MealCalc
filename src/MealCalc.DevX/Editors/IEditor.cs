using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public interface IEditor
  {
    bool AddValue(IWin32Window owner, out object newValue);
    bool EditValue(IWin32Window owner, object original, out object editedValue);
  }
}
