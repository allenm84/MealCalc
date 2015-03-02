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
  public partial class EditServingControl : UserControl
  {
    private Dictionary<string, object> pendingProperties = new Dictionary<string, object>();
    private Measurement SelectedMeasurement
    {
      get
      {
        return (cboMeasurement.SelectedValue as Measurement?).GetValueOrDefault();
      }
    }

    public event EventHandler ServingChanged;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool MeasurementVisible
    {
      get { return cboMeasurement.Visible; }
      set { cboMeasurement.Visible = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool ServingSizeVisible
    {
      get { return lblServingSize.Visible; }
      set { lblServingSize.Visible = value; }
    }

    private decimal Amount
    {
      get
      {
        decimal amount = (decimal)numAmount.Value;
        return Math.Max(amount, 0.01m);
      }
    }

    public EditServingControl()
    {
      InitializeComponent();
      InitializeAmount();
    }

    private void InitializeAmount()
    {
      numAmount.Value = 0.01m;
      numAmount.ValueChanged += servingValue_Changed;
    }

    public void Hydrate(Serving serving)
    {
      numAmount.Value = serving.Amount;
      pendingProperties["Measurement"] = serving.Type;
    }

    public void Dehydrate(Serving serving)
    {
      serving.Amount = Amount;
      serving.Type = SelectedMeasurement;
    }

    public bool ValidateServing()
    {
      return Amount > 0m;
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
      cboMeasurement.DataSource = Enum
        .GetValues(typeof(Measurement))
        .Cast<Measurement>()
        .Select(m => new { Display = m.GetDescription(), Value = m })
        .ToArray();
      cboMeasurement.DisplayMember = "Display";
      cboMeasurement.ValueMember = "Value";

      object value;
      if (pendingProperties.TryGetValue("Measurement", out value))
      {
        cboMeasurement.SelectedValue = value;
      }
      else
      {
        cboMeasurement.SelectedIndex = 0;
      }

      pendingProperties.Clear();
      base.OnLoad(e);
    }

    private void servingValue_Changed(object sender, EventArgs e)
    {
      FireServingChanged();
    }
  }
}
