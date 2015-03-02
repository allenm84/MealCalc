using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.Common;
using Janus.Windows.GridEX;

namespace MealCalc.JanusControls
{
  public static class JanusStyleHelper
  {
    static VisualStyleManager manager;
    static JanusStyleHelper()
    {
      var scheme = new JanusColorScheme("Office2007Silver");
      scheme.Office2007ColorScheme = Janus.Windows.Common.Office2007ColorScheme.Silver;
      scheme.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007;
      manager = new VisualStyleManager();
      manager.ColorSchemes.Add(scheme);
      manager.DefaultColorScheme = scheme.Name;
    }

    public static void SetStyle(Control control)
    {
      manager.AddControl(control, true);
    }
  }
}
