using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public partial class EditIngredientControl : UserControl
  {
    private BindingListEx<Category> categories = new BindingListEx<Category>();
    private List<Category> addedCategories = new List<Category>();

    public string IngredientName
    {
      get { return txtName.Text; }
    }

    public IEnumerable<Category> NewCategories
    {
      get
      {
        foreach (var category in addedCategories)
        {
          yield return category;
        }
      }
    }

    public EditIngredientControl()
    {
      InitializeComponent();
    }

    public void Hydrate(Ingredient ingredient)
    {
      txtName.Text = ingredient.Name;
      if (!string.IsNullOrEmpty(ingredient.CategoryID))
      {
        cboCategories.SelectedValue = ingredient.CategoryID;
      }
      else if (cboCategories.Items.Count > 0)
      {
        cboCategories.SelectedIndex = 0;
      }
      nutritionalInfoEditor.Hydrate(ingredient.Info);
    }

    public void Dehydrate(Ingredient ingredient)
    {
      ingredient.Name = txtName.Text;
      ingredient.CategoryID = cboCategories.SelectedValue as string;
      nutritionalInfoEditor.Dehydrate(ingredient.Info);
    }

    public void AddCategories(IEnumerable<Category> additional)
    {
      CollectionExtensions.AddRange(categories, additional);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (DesignMode) return;

      CollectionExtensions.AddRange(categories, SaveFile.Instance.Categories);
      cboCategories.DataSource = categories;
      cboCategories.DisplayMember = "Name";
      cboCategories.ValueMember = "ID";
    }

    private void btnAddNewCategory_Click(object sender, EventArgs e)
    {
      string name;
      if (TextInputDialog.Show(this, "Category Name:", "Create New Category", out name) == DialogResult.OK)
      {
        var category = Factory.NewCategory(name);
        addedCategories.Add(category);
        categories.Add(category);
        cboCategories.SelectedValue = category.ID;
      }
    }
  }
}
