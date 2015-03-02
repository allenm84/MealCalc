using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  public static class Factory
  {
    public static Category NewCategory(string name)
    {
      return new Category
      {
        ID = Tuid.Next,
        Name = name,
      };
    }

    public static Ingredient NewIngredient(string name)
    {
      var category = SaveFile.Instance.Categories.FirstOrDefault();

      return new Ingredient
      {
        CategoryID = (category != null) ? category.ID : null,
        ID = Tuid.Next,
        Info = NewNutritionalInfo(),
        Name = name,
      };
    }

    public static NutritionalInfo NewNutritionalInfo()
    {
      return new NutritionalInfo
      {
        Calories = 0,
        Carbs = 0,
        Fat = 0,
        Protein = 0,
        ServingSize = NewServing(),
        Sodium = 0,
        Sugar = 0,
      };
    }

    public static Serving NewServing()
    {
      return new Serving
      {
        Amount = 1,
        Type = Measurement.Cup,
      };
    }

    public static Recipe NewRecipe(string name)
    {
      return new Recipe
      {
        Favorite = false,
        ID = Tuid.Next,
        Ingredients = new List<IngredientRef>(),
        Name = name,
        Calculations = new List<Calculation>(),
      };
    }

    public static Calculation NewCalculation(string name)
    {
      return new Calculation
      {
        ID = Tuid.Next,
        Info = Factory.NewNutritionalInfo(),
        Name = name,
      };
    }
  }
}
