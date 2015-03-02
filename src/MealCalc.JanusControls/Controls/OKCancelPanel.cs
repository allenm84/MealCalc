using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.JanusControls
{
  public partial class OKCancelPanel : UserControl
  {
    public Button OK { get { return btnOK; } }
    public Button Cancel { get { return btnCancel; } }

    public OKCancelPanel()
    {
      InitializeComponent();
      Margin = new Padding(0);
    }

    protected override void OnParentChanged(EventArgs e)
    {
      base.OnParentChanged(e);
      Hook(ParentForm);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      Hook(ParentForm);
    }

    public void Hook(Form form)
    {
      if (form == null) return;
      form.AcceptButton = btnOK;
      form.CancelButton = btnCancel;
    }
  }
}
