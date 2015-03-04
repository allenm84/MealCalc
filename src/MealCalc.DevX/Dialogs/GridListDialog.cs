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
  public partial class GridListDialog : BaseForm
  {
    public string Header
    {
      get { return layoutControlGroup2.Text; }
      set { layoutControlGroup2.Text = value; }
    }

    public GridListControl List
    {
      get { return gridListControl1; }
    }

    public GridListDialog()
    {
      InitializeComponent();
    }
  }
}