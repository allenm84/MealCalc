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
  public partial class ViewNutritionalInfoControl : XtraUserControl
  {
    private string[] source = new string[7];
    private StringFormat format;

    private bool showServingSize = true;
    public bool ShowServingSize
    {
      get { return showServingSize; }
      set 
      { 
        showServingSize = value;
        UpdateDisplay();
      }
    }

    public ViewNutritionalInfoControl()
    {
      InitializeComponent();
      format = new StringFormat
      {
        Alignment = StringAlignment.Center,
        LineAlignment = StringAlignment.Center,
      };
    }

    public void Populate(NutritionalInfo info)
    {
      info = Calculator.Round(info);

      int s = 0;
      source[s++] = string.Format("Serving Size {0}", info.ServingSize);
      source[s++] = string.Format("Calories {0}", info.Calories);
      source[s++] = string.Format("Fat {0}g", info.Fat);
      source[s++] = string.Format("Sodium {0}mg", info.Sodium);
      source[s++] = string.Format("Carbs {0}g", info.Carbs);
      source[s++] = string.Format("Sugar {0}g", info.Sugar);
      source[s++] = string.Format("Protein {0}g", info.Protein);
      UpdateDisplay();
    }

    private void UpdateDisplay()
    {
      lstItems.BeginUpdate();
      lstItems.Items.Clear();

      lstItems.Items.Add(string.Empty);
      lstItems.Items.Add("Nutrition Facts");
      lstItems.Items.Add(string.Empty);

      if (source.Any(string.IsNullOrWhiteSpace))
      {
        // at least one of the items in source is NullOrWhiteSpace
      }
      else
      {
        int i = showServingSize ? 0 : 1;
        for (; i < source.Length; ++i)
        {
          lstItems.Items.Add(source[i]);
        }
      }

      lstItems.EndUpdate();
    }

    private void lstItems_DrawItem(object sender, ListBoxDrawItemEventArgs e)
    {
      string text = (string)e.Item;
      e.Appearance.DrawBackground(e.Cache, e.Bounds);

      bool dispose = false;

      Font font = e.Appearance.Font;
      if (e.Index == 1)
      {
        dispose = true;
        font = new Font(font.FontFamily, font.Size + 6f, FontStyle.Bold);
      }

      e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(e.Appearance.ForeColor), e.Bounds, format);
      e.Handled = true;

      if (dispose)
      {
        font.Dispose();
        font = null;
      }
    }
  }
}
