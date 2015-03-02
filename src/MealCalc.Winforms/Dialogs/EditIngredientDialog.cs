using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public partial class EditIngredientDialog : BaseForm
  {
    public IEnumerable<Category> NewCategories
    {
      get { return editIngredientControl1.NewCategories; }
    }

    public EditIngredientDialog()
    {
      InitializeComponent();
    }

    public void Hydrate(Ingredient ingredient)
    {
      editIngredientControl1.Hydrate(ingredient);
    }

    public void Dehydrate(Ingredient ingredient)
    {
      editIngredientControl1.Dehydrate(ingredient);
    }

    public void AddCategories(IEnumerable<Category> additional)
    {
      editIngredientControl1.AddCategories(additional);
    }
  }
}
