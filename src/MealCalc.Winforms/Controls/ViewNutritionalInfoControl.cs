using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc
{
  public partial class ViewNutritionalInfoControl : UserControl
  {
    private Pen borderPen;

    public bool ShowServingSize
    {
      get { return lblServingSize.Visible; }
      set { lblServingSize.Visible = value; }
    }

    public ViewNutritionalInfoControl()
    {
      InitializeComponent();
      DoubleBuffered = true;
      borderPen = new Pen(Color.Gray);
    }

    public void Populate(NutritionalInfo info)
    {
      info = Calculator.Round(info);
      lblServingSize.Text = string.Format("Serving Size {0}", info.ServingSize);
      lblCalories.Text = string.Format("Calories {0}", info.Calories);
      lblFat.Text = string.Format("Fat {0}g", info.Fat);
      lblSodium.Text = string.Format("Sodium {0}mg", info.Sodium);
      lblCarbs.Text = string.Format("Carbs {0}g", info.Carbs);
      lblSugar.Text = string.Format("Sugar {0}g", info.Sugar);
      lblProtein.Text = string.Format("Protein {0}g", info.Protein);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);
      if (borderPen != null)
      {
        e.Graphics.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
      }
    }
  }
}
