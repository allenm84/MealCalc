using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public class GridView : DataGridView
  {
    private Pen borderPen;

    public GridView()
    {
      BackgroundColor = SystemColors.Window;
      DoubleBuffered = true;
      borderPen = new Pen(Color.Gray);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (borderPen != null)
        {
          borderPen.Dispose();
          borderPen = null;
        }
      }
      base.Dispose(disposing);
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
