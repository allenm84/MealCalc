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
  public partial class BaseForm : XtraForm
  {
    protected bool cancelClose = false;

    public BaseForm()
    {
      InitializeComponent();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        cancelClose = false;
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }
  }
}