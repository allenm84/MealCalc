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
  public partial class EditNutritionalInfoControl : XtraUserControl
  {
    public EditNutritionalInfoControl()
    {
      InitializeComponent();
    }

    public void Hydrate(NutritionalInfo info)
    {
      servingEditor.Hydrate(info.ServingSize);
      numCalories.Value = info.Calories;
      numFat.Value = info.Fat;
      numSodium.Value = info.Sodium;
      numCarbs.Value = info.Carbs;
      numSugar.Value = info.Sugar;
      numProtein.Value = info.Protein;
    }

    public void Dehydrate(NutritionalInfo info)
    {
      servingEditor.Dehydrate(info.ServingSize);
      info.Calories = numCalories.Value;
      info.Fat = numFat.Value;
      info.Sodium = numSodium.Value;
      info.Carbs = numCarbs.Value;
      info.Sugar = numSugar.Value;
      info.Protein = numProtein.Value;
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      height = 100;
      base.SetBoundsCore(x, y, width, height, specified);
    }
  }
}
