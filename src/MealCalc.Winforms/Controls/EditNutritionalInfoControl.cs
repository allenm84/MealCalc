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
  public partial class EditNutritionalInfoControl : UserControl
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
  }
}
