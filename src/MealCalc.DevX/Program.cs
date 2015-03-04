using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace MealCalc.DevX
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      SkinManager.EnableFormSkins();
      SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
      UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

      Application.Run(new MainForm());
    }
  }
}
