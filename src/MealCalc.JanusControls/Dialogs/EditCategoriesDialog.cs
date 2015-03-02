using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MealCalc.JanusControls
{
  public partial class EditCategoriesDialog : BaseForm
  {
    private BindingList<Category> categories = new BindingList<Category>();

    public IEnumerable<Category> Categories
    {
      get
      {
        foreach (var category in categories)
        {
          yield return category;
        }
      }
    }

    public void Hydrate(IEnumerable<Category> categories)
    {
      this.categories.AddRange(categories);
    }

    public EditCategoriesDialog()
    {
      InitializeComponent();
      categories.ListChanged += categories_ListChanged;
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridCategories.SelectedItems.Count == 1;
      btnClear.Enabled = categories.Count > 0;
      btnRemove.Enabled = gridCategories.SelectedItems.Count > 0;
    }

    private void EditCategoryByRow(GridEXRow row)
    {
      if (row == null) return;
      EditCategory(row.DataRow as Category);
    }

    private void EditCategory(Category category)
    {
      if (category == null) return;

      string name = category.Name;
      if (TextInputDialog.Show(this, "Name:", string.Concat("Rename ", name), name, out name) == System.Windows.Forms.DialogResult.OK)
      {
        var index = categories.IndexOf(category);
        category.Name = name;
        categories.ResetItem(index);
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      gridCategories.SelectionChanged += gridCategories_SelectionChanged;
      gridCategories.SetPropertiesToList(true, false);
      gridCategories.DataSource = categories;
      gridCategories.RetrieveStructure();
      gridCategories.RootTable.Columns.HideAllExcept("Name");
      gridCategories.RootTable.SortKeys.Add("Name");
      UpdateButtons();
    }

    private void categories_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridCategories_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string name = "<New Category>";
      if (TextInputDialog.Show(this, "Name:", "Create New Category", name, out name) == System.Windows.Forms.DialogResult.OK)
      {
        categories.Add(Factory.NewCategory(name));
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditCategoryByRow(gridCategories.CurrentRow);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var selected = gridCategories
        .GetSelectedItems<Category>()
        .ToArray();
      if (selected.Length < 1) return;

      var result = MessageBox.Show(this, "Are you sure you want to delete the selected categories?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      using (var defer = categories.DeferBinding())
      {
        categories.RemoveRange(selected);
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      if (categories.Count == 0) return;

      var result = MessageBox.Show(this, "Are you sure you want to clear all categories?", "Clear",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      categories.Clear();
    }

    private void gridCategories_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
    {
      EditCategoryByRow(e.Row);
    }
  }
}
