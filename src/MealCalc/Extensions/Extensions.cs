using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public static class Extensions
  {
    private static Dictionary<Enum, string> enumDescriptions = new Dictionary<Enum, string>();

    public static Recipe Duplicate(this Recipe recipe)
    {
      return new Recipe
      {
        Favorite = recipe.Favorite,
        ID = string.Copy(recipe.ID ?? string.Empty),
        Ingredients = recipe.Ingredients.Select(i => i.Duplicate()).ToList(),
        Name = string.Copy(recipe.Name ?? string.Empty),
        Calculations = recipe.Calculations.Select(c => c.Duplicate()).ToList(),
      };
    }

    public static Calculation Duplicate(this Calculation calculation)
    {
      return new Calculation
      {
        ID = string.Copy(calculation.ID ?? string.Empty),
        Info = calculation.Info.Duplicate(),
        Name = string.Copy(calculation.Name ?? string.Empty),
      };
    }

    public static IngredientRef Duplicate(this IngredientRef iref)
    {
      return new IngredientRef
      {
        IngredientID = string.Copy(iref.IngredientID ?? string.Empty),
        Serving = iref.Serving.Duplicate(),
      };
    }

    public static Category Duplicate(this Category category)
    {
      return new Category
      {
        ID = string.Copy(category.ID ?? string.Empty),
        Name = string.Copy(category.Name ?? string.Empty),
      };
    }

    public static Ingredient Duplicate(this Ingredient ingredient)
    {
      return new Ingredient
      {
        CategoryID = string.Copy(ingredient.CategoryID ?? string.Empty),
        ID = string.Copy(ingredient.ID ?? string.Empty),
        Info = ingredient.Info.Duplicate(),
        Name = string.Copy(ingredient.Name ?? string.Empty),
      };
    }

    public static NutritionalInfo Duplicate(this NutritionalInfo info)
    {
      return new NutritionalInfo
      {
        Calories = info.Calories,
        Carbs = info.Carbs,
        Fat = info.Fat,
        Protein = info.Protein,
        ServingSize = info.ServingSize.Duplicate(),
        Sodium = info.Sodium,
        Sugar = info.Sugar,
      };
    }

    public static Serving Duplicate(this Serving serving)
    {
      return new Serving
      {
        Amount = serving.Amount,
        Type = serving.Type,
      };
    }

    public static string GetDescription(this Enum value)
    {
      string description;
      if (!enumDescriptions.TryGetValue(value, out description))
      {
        var name = value.ToString();
        description = name;

        var fi = value.GetType().GetField(name);
        var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
        if (attributes != null && attributes.Length > 0)
        {
          description = attributes[0].Description;
        }
      }
      return description;
    }
  }
}
