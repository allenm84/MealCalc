using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public partial class TextInputDialog : BaseForm
  {
    private TextInputDialog()
    {
      InitializeComponent();
    }

    public static DialogResult Show(IWin32Window owner, string prompt, string caption, string initialInput, out string input)
    {
      DialogResult result;
      using (var dlg = new TextInputDialog())
      {
        dlg.Text = caption;
        dlg.lblPrompt.Text = prompt;
        dlg.txtInput.Text = initialInput;
        result = dlg.ShowDialog(owner);
        input = dlg.txtInput.Text;
      }
      return result;
    }

    public static DialogResult Show(IWin32Window owner, string prompt, string caption, out string input)
    {
      return Show(owner, prompt, caption, "", out input);
    }

    public static DialogResult Show(string prompt, string caption, out string input)
    {
      return Show(null, prompt, caption, out input);
    }

    private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        e.Handled = true;
        this.ProcessDialogKey(Keys.Enter);
      }
    }
  }
}
