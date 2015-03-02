using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public static class Calculator
  {
    const decimal CupsInTablespoon = 0.0625m;
    const decimal CupsInTeaspoon = 0.02083333333333333333333333333333m;
    const decimal CupsInOunce = 0.125m;

    public static NutritionalInfo CalculateNutritionalInfo(IEnumerable<IngredientRef> references, params IEnumerable<Ingredient>[] sources)
    {
      var info = Factory.NewNutritionalInfo();
      info.ServingSize.Amount = 0;
      info.ServingSize.Type = Measurement.Cup;

      var factor = 1m;
      foreach (var reference in references)
      {
        var ingredient = Accessor.GetIngredient(reference.IngredientID, sources);
        var ingredientInfo = ingredient.Info;

        if (ingredientInfo.NoMeasurement)
        {
          factor = reference.Serving.Amount;
        }
        else
        {
          var ingredientServing = Calculator.ToCups(ingredientInfo.ServingSize);
          var referenceServing = Calculator.ToCups(reference.Serving);

          factor = referenceServing.Amount / ingredientServing.Amount;
          info.ServingSize.Amount += referenceServing.Amount;
        }

        info.Calories += (ingredientInfo.Calories * factor);
        info.Carbs += (ingredientInfo.Carbs * factor);
        info.Fat += (ingredientInfo.Fat * factor);
        info.Protein += (ingredientInfo.Protein * factor);
        info.Sodium += (ingredientInfo.Sodium * factor);
        info.Sugar += (ingredientInfo.Sugar * factor);
      }

      return info;
    }

    public static Serving ToCups(Serving serving)
    {
      var retval = serving.Duplicate();

      if (retval.Type != Measurement.Cup)
      {
        if (retval.Type == Measurement.TableSpoon)
        {
          retval.Amount *= CupsInTablespoon;
        }
        else if (retval.Type == Measurement.TeaSpoon)
        {
          retval.Amount *= CupsInTeaspoon;
        }
        else if (retval.Type == Measurement.Ounce)
        {
          retval.Amount *= CupsInOunce;
        }
      }

      retval.Type = Measurement.Cup;
      return retval;
    }

    public static NutritionalInfo Divide(NutritionalInfo info, decimal value)
    {
      var retval = info.Duplicate();
      retval.Calories /= value;
      retval.Carbs /= value;
      retval.Fat /= value;
      retval.Protein /= value;
      retval.ServingSize.Amount /= value;
      retval.Sodium /= value;
      retval.Sugar /= value;
      return retval;
    }

    public static NutritionalInfo Round(NutritionalInfo info)
    {
      var retval = info.Duplicate();
      retval.Calories = Math.Round(retval.Calories, 2);
      retval.Carbs = Math.Round(retval.Carbs, 2);
      retval.Fat = Math.Round(retval.Fat, 2);
      retval.Protein = Math.Round(retval.Protein, 2);
      retval.ServingSize.Amount = Math.Round(retval.ServingSize.Amount, 2);
      retval.Sodium = Math.Round(retval.Sodium, 2);
      retval.Sugar = Math.Round(retval.Sugar, 2);
      return retval;
    }
  }
}
