using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public static class Accessor
  {
    public static Ingredient GetIngredient(string id, params IEnumerable<Ingredient>[] sources)
    {
      return sources.SelectMany(s => s).Single(i => string.Equals(i.ID, id));
    }

    public static string GetServingSizeText(NutritionalInfo info)
    {
      if (info.NoMeasurement)
      {
        return string.Format("{0:0.00} parts", info.ServingSize.Amount);
      }
      return info.ServingSize.ToString();
    }
  }
}
