using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MealCalc.DevX
{
  public partial class EditorButtons : XtraUserControl
  {
    public event EventHandler AddClick
    {
      add { btnAdd.Click += value; }
      remove { btnAdd.Click -= value; }
    }

    public event EventHandler EditClick
    {
      add { btnEdit.Click += value; }
      remove { btnEdit.Click -= value; }
    }

    public event EventHandler RemoveClick
    {
      add { btnRemove.Click += value; }
      remove { btnRemove.Click -= value; }
    }

    public event EventHandler ClearClick
    {
      add { btnClear.Click += value; }
      remove { btnClear.Click -= value; }
    }

    public EditorButtons()
    {
      InitializeComponent();
    }

    public void UpdateButtons(int selectionCount, int totalCount)
    {
      btnAdd.Enabled = true;
      btnEdit.Enabled = selectionCount == 1;
      btnRemove.Enabled = selectionCount > 0;
      btnClear.Enabled = totalCount > 0;
    }

    public void Remove()
    {
      if (btnRemove.Enabled)
      {
        btnRemove.PerformClick();
      }
    }
  }
}
