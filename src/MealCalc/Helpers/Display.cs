using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public static class Display
  {
    public static string GetDisplay(IngredientRef ingredient, params IEnumerable<Ingredient>[] sources)
    {
      var i = Accessor.GetIngredient(ingredient.IngredientID, sources);
      return GetDisplay(ingredient, i.Name);
    }

    public static string GetDisplay(IngredientRef ingredient, string ingredientName)
    {
      return string.Format("{0} {1}{2} of {3}{2}",
        ingredient.Serving.Amount,
        ingredient.Serving.Type,
        ingredient.Serving.Amount == 1m ? "" : "s",
        ingredientName);
    }
  }
}
