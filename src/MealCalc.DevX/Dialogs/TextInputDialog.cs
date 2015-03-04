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

namespace MealCalc.DevX
{
  public partial class TextInputDialog : BaseForm
  {
    public bool AllowEmptyInput { get; set; }

    public string Prompt
    {
      get { return layoutControlItem1.Text; }
      set { layoutControlItem1.Text = value; }
    }

    public string Input
    {
      get { return textEdit1.Text; }
      set { textEdit1.Text = value; }
    }

    public TextInputDialog()
    {
      InitializeComponent();
    }

    public static DialogResult Show(IWin32Window owner, string prompt, string caption, string initialInput, out string input)
    {
      DialogResult result;
      using (var dlg = new TextInputDialog())
      {
        dlg.Text = caption;
        dlg.Prompt = prompt;
        dlg.Input = initialInput;
        result = dlg.ShowDialog(owner);
        input = dlg.Input;
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

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(textEdit1.Text) && !AllowEmptyInput)
      {
        MessageHelper.Inform(this, "The textbox cannot be empty");
        cancelClose = true;
      }
    }
  }
}