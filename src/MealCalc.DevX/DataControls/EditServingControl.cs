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
  public partial class EditServingControl : XtraUserControl
  {
    public event EventHandler ServingChanged;

    public EditServingControl()
    {
      InitializeComponent();
      cboMeasurement.FillWithEnum<Measurement>((m) => m.GetDescription());
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      height = 24;
      base.SetBoundsCore(x, y, width, height, specified);
    }

    public void Hydrate(Serving serving)
    {
      numAmount.Value = serving.Amount;
      cboMeasurement.EditValue = serving.Type;
    }

    public void Dehydrate(Serving serving)
    {
      serving.Amount = numAmount.Value;
      serving.Type = (Measurement)cboMeasurement.EditValue;
    }

    private void FireServingChanged()
    {
      if (ServingChanged != null)
      {
        ServingChanged(this, EventArgs.Empty);
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (cboMeasurement.EditValue == null)
      {
        cboMeasurement.EditValue = Measurement.Cup;
      }
    }

    private void numAmount_EditValueChanged(object sender, EventArgs e)
    {
      FireServingChanged();
    }

    private void cboMeasurement_EditValueChanged(object sender, EventArgs e)
    {
      FireServingChanged();
    }
  }
}
