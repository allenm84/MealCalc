using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MealCalc.JanusControls.Properties;

namespace MealCalc.JanusControls
{
  public partial class MainForm : BaseForm, IDoWorkView
  {
    private BindingList<Recipe> recipes;
    private DoWorkController workController;

    public MainForm()
    {
      InitializeComponent();
      workController = new DoWorkController(this);
    }

    #region IDoWorkView Members

    void IDoWorkView.ShowError(string text)
    {
      MessageBox.Show(this, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    void IDoWorkView.SetIsWorking(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      tableLayoutPanel1.Enabled = !working;
      mainToolStrip.Enabled = !working;
      mainToolStrip.Focus();
      progStatus.Visible = working;
    }

    void IDoWorkView.Close()
    {
      base.Close();
    }

    #endregion

    private void IncorporateChanges(EditRecipeDialog dlg)
    {
      SaveFile.Instance.Categories.AddRange(dlg.NewCategories);
      SaveFile.Instance.Ingredients.AddRange(dlg.NewIngredients);
    }

    private void EditRecipeFromRow(GridEXRow row)
    {
      if (row == null) return;
      EditRecipe(row.DataRow as Recipe);
    }

    private void EditRecipe(Recipe recipe)
    {
      if (recipe == null) return;

      var copy = recipe.Duplicate();
      using (var dlg = new EditRecipeDialog())
      {
        dlg.Text = string.Concat("Edit ", recipe.Name);
        dlg.BindTo(copy);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = recipes.IndexOf(recipe);
          recipes[index] = copy;
          IncorporateChanges(dlg);
        }
      }
    }

    private void RenameCurrentRecipe()
    {
      var row = gridRecipes.CurrentRow;
      if (row == null) return;

      var recipe = row.DataRow as Recipe;
      if (recipe == null) return;

      string input;
      if (TextInputDialog.Show(this, "Name:", "Rename Recipe", recipe.Name, out input) == System.Windows.Forms.DialogResult.OK)
      {
        recipe.Name = input;
        var index = recipes.IndexOf(recipe);
        recipes.ResetItem(index);
      }
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridRecipes.SelectedItems.Count == 1;
      btnRemove.Enabled = gridRecipes.SelectedItems.Count > 0;
      btnRename.Enabled = btnEdit.Enabled;
      btnClear.Enabled = recipes.Count > 0;
    }

    private void DoLoadWork(DoWorkInput input)
    {
      SaveFile.Load();
    }

    private void DoLoadCompleted(DoWorkOutput output)
    {
      recipes = new BindingList<Recipe>(SaveFile.Instance.Recipes);
      gridRecipes.SetPropertiesToList(true, false);
      gridRecipes.DataSource = recipes;
      gridRecipes.RetrieveStructure();
      gridRecipes.RootTable.RowHeight = 18;
      gridRecipes.RootTable.Columns.HideAllExcept("Name", "Favorite");
      gridRecipes.RootTable.Columns["Favorite"].Position = 0;
      gridRecipes.RootTable.Columns["Name"].Position = 1;

      var clmnFavorite = gridRecipes.RootTable.Columns["Favorite"];
      clmnFavorite.AllowSize = false;
      clmnFavorite.ColumnType = ColumnType.Image;
      clmnFavorite.HasValueList = true;
      clmnFavorite.ValueList.Add(true, "Favorite", Resources.star_small);
      clmnFavorite.ValueList.Add(false, "Regular");
      clmnFavorite.Width = 16;

      gridRecipes.RootTable.SortKeys.Add("Favorite", Janus.Windows.GridEX.SortOrder.Descending);
      gridRecipes.RootTable.SortKeys.Add("Name");
      UpdateButtons();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      workController.StartWorker(DoLoadWork, DoLoadCompleted);
    }

    private void tbbSave_Click(object sender, EventArgs e)
    {
      workController.StartWorker(SaveFile.Save);
    }

    private void tbbCategories_Click(object sender, EventArgs e)
    {
      using (var dlg = new EditCategoriesDialog())
      {
        dlg.Text = "Categories";
        dlg.Hydrate(SaveFile.Instance.Categories.Select(c => c.Duplicate()));
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Categories = dlg.Categories.ToList();
        }
      }
    }

    private void tbbIngredients_Click(object sender, EventArgs e)
    {
      using (var dlg = new EditIngredientsDialog())
      {
        dlg.Text = "Ingredients";
        dlg.Hydrate(SaveFile.Instance.Ingredients.Select(i => i.Duplicate()));
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Ingredients = dlg.Ingredients.ToList();
          SaveFile.Instance.Categories.AddRange(dlg.NewCategories);
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      string name = "<New Recipe>";
      string baseName = name;
      int salt = 1;
      while (recipes.Any(r => string.Equals(r.Name, name)))
      {
        name = string.Concat(baseName, "_", salt++);
      }

      var recipe = Factory.NewRecipe(name);
      using (var dlg = new EditRecipeDialog())
      {
        dlg.Text = "Edit Recipe";
        dlg.BindTo(recipe);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          recipes.Add(recipe);
          IncorporateChanges(dlg);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var row = gridRecipes.CurrentRow;
      EditRecipeFromRow(row);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "Are you sure you want to remove the selected recipes?", "Remove", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      var selected = gridRecipes
        .GetSelectedItems<Recipe>()
        .ToArray();

      using (var defer = recipes.DeferBinding())
      {
        foreach (var item in selected)
        {
          recipes.Remove(item);
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "Are you sure you want to clear all recipes?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      recipes.Clear();
    }

    private void btnRename_Click(object sender, EventArgs e)
    {
      RenameCurrentRecipe();
    }

    private void gridRecipes_RowDoubleClick(object sender, RowActionEventArgs e)
    {
      EditRecipeFromRow(e.Row);
    }

    private void gridRecipes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F2)
      {
        RenameCurrentRecipe();
      }
    }

    private void gridRecipes_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }
  }
}
