using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.DevX
{
  public partial class EditIngredientDialog : BaseForm
  {
    private Ingredient ingredient;

    public EditIngredientDialog(Ingredient ingredient, IList<Category> categories)
    {
      this.ingredient = ingredient;
      InitializeComponent();

      editIngredientControl1.SetCategories(categories);
      editIngredientControl1.Hydrate(ingredient);
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      editIngredientControl1.Dehydrate(ingredient);
      if (string.IsNullOrWhiteSpace(ingredient.CategoryID))
      {
        cancelClose = true;
        MessageHelper.Inform(this, "Please select a category");
      }
    }
  }
}
