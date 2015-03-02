using System;
using System.Windows.Forms;

namespace MealCalc.JanusControls
{
  public class NumericEdit : NumericUpDown
  {
    protected override void OnEnter(EventArgs e)
    {
      base.OnEnter(e);
      base.Select(0, base.Text.Length);
    }
  }
}
