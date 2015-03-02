using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Common.Extensions;
using System.Common.References;

namespace MealCalc.Winforms
{
  public partial class EditCategoriesDialog : BaseForm
  {
    private BindingListEx<Category> categories = new BindingListEx<Category>();

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
      CollectionExtensions.AddRange(this.categories, categories);
    }

    public EditCategoriesDialog()
    {
      InitializeComponent();
      categories.ListChanged += categories_ListChanged;
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridCategories.SelectedRows.Count == 1;
      btnClear.Enabled = categories.Count > 0;
      btnRemove.Enabled = gridCategories.SelectedRows.Count > 0;
    }

    private void EditCategoryByRow(DataGridViewRow row)
    {
      if (row == null) return;
      EditCategory(row.DataBoundItem as Category);
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
      gridCategories.AutoGenerateColumns = false;
      gridCategories.Columns.AddDataBoundColumn("Name");
      gridCategories.DataSource = categories;
      gridCategories.Sort(gridCategories.Columns["Name"], ListSortDirection.Ascending);
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
      var selected = gridCategories.SelectedRows
        .Cast<DataGridViewRow>()
        .Select(r => r.DataBoundItem as Category)
        .ToArray();
      if (selected.Length < 1) return;

      var result = MessageBox.Show(this, "Are you sure you want to delete the selected categories?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      using (var defer = categories.DeferBinding())
      {
        CollectionExtensions.RemoveRange(categories, selected);
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

    private void gridCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (-1 < e.RowIndex && e.RowIndex < gridCategories.Rows.Count)
      {
        var row = gridCategories.Rows[e.RowIndex];
        EditCategoryByRow(row);
      }
    }
  }
}
