using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
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

    public EditServingControl()
    {
      InitializeComponent();
      InitializeAmount();
    }

    private void InitializeAmount()
    {
      numAmount.Minimum = 0.01m;
      numAmount.Increment = 0.01m;
      numAmount.ValueChanged += servingValue_Changed;
    }

    public void Hydrate(Serving serving)
    {
      numAmount.Value = serving.Amount;
      pendingProperties["Measurement"] = serving.Type;
    }

    public void Dehydrate(Serving serving)
    {
      serving.Amount = numAmount.Value;
      serving.Type = SelectedMeasurement;
    }

    public bool ValidateServing()
    {
      return numAmount.Value > 0m;
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

      pendingProperties.Clear();
      base.OnLoad(e);
    }

    private void servingValue_Changed(object sender, EventArgs e)
    {
      FireServingChanged();
    }
  }
}
