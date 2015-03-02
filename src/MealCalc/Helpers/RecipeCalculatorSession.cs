using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public sealed class RecipeCalculatorSession
  {
    public IEnumerable<Ingredient> Ingredients { get; set; }
    public IEnumerable<IngredientRef> References { get; set; }
    public IEnumerable<Calculation> Calculations { get; set; }
  }
}
