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
  public partial class EditIngredientControl : XtraUserControl
  {
    public EditIngredientControl()
    {
      InitializeComponent();
    }

    public void SetCategories(IList<Category> categories)
    {
      categorySource.DataSource = categories;
    }

    public void Hydrate(Ingredient ingredient)
    {
      txtName.Text = ingredient.Name;
      cboCategory.EditValue = ingredient.CategoryID;
      nutritionalInfoEditor.Hydrate(ingredient.Info);
    }

    public void Dehydrate(Ingredient ingredient)
    {
      ingredient.Name = txtName.Text;
      ingredient.CategoryID = cboCategory.EditValue as string;
      nutritionalInfoEditor.Dehydrate(ingredient.Info);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (cboCategory.EditValue == null && categorySource.Count > 0)
      {
        var category = (Category)categorySource[0];
        cboCategory.EditValue = category.ID;
      }
    }

    private void cboCategory_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      string name;

      string initialInput = cboCategory.Properties.View.FindFilterText;
      if (string.IsNullOrWhiteSpace(initialInput))
      {
        initialInput = "<New Category>";
      }

      if (TextInputDialog.Show(this, "Name:", "Add Category", initialInput, out name) == DialogResult.OK)
      {
        var cat = Factory.NewCategory(name);
        categorySource.Add(cat);
        e.NewValue = cat.ID;
      }
      else
      {
        e.Cancel = true;
      }
    }
  }
}
