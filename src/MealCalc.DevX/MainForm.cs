using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace MealCalc.DevX
{
  public partial class MainForm : BaseForm, IWorker
  {
    private BindingList<Recipe> recipes;

    public MainForm()
    {
      InitializeComponent();
    }

    void IWorker.SetIsWorking(bool working)
    {
      UseWaitCursor = working;
      layoutControlItem2.SetIsVisible(working);
      gridRecipes.Enabled = !working;
      bar1.SetIsEnabled(!working);
    }

    private void SetupGrid()
    {
      gridRecipes.AutoGenerateColumns = false;
      gridRecipes.Editor = new RecipeEditor();
      gridRecipes.Mode = GridListControlViewMode.List;
      gridRecipes.View.OptionsView.ShowVerticalLines = DefaultBoolean.False;
      gridRecipes.View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      gridRecipes.DataSource = recipes;

      var chkFavorite = new RepositoryItemCheckEdit();
      chkFavorite.PictureChecked = MealCalc.DevX.Properties.Resources.Star;
      chkFavorite.CheckStyle = CheckStyles.UserDefined;

      var clmnFavorite = gridRecipes.View.Columns.AddField("Favorite");
      clmnFavorite.Visible = true;
      clmnFavorite.MinWidth = 18;
      clmnFavorite.MaxWidth = 18;
      clmnFavorite.ColumnEdit = chkFavorite;

      var clmnName = gridRecipes.View.Columns.AddField("Name");
      clmnName.Visible = true;
      clmnName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
      clmnName.SortIndex = 0;

      if (recipes.Count > 0)
      {
        gridRecipes.ScrollToRow(0);
      }
    }

    private async void LoadSaveFile()
    {
      using (this.BeginWork())
      {
        await Task.Run(() => SaveFile.Load());
        recipes = new BindingList<Recipe>(SaveFile.Instance.Recipes);
      }
      SetupGrid();
    }

    private async void SaveSaveFile()
    {
      using (this.BeginWork())
      {
        await Task.Run(() => SaveFile.Save());
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      LoadSaveFile();
    }

    private void tbbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      SaveSaveFile();
    }

    private void tbbCategories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      using (var dlg = new GridListDialog())
      {
        dlg.Text = "All Categories";
        dlg.Header = "Items";
        var categories = SaveFile.Instance.Categories.Select(c => c.Duplicate()).ToList();

        var grid = dlg.List;
        grid.Mode = GridListControlViewMode.List;
        grid.AutoGenerateColumns = false;
        grid.DataSource = categories;
        grid.Columns.AddVisible("Name").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        grid.Editor = new CategoryEditor();

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Categories = categories;
        }
      }
    }

    private void tbbIngredients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      using (var dlg = new GridListDialog())
      {
        dlg.Text = "All Ingredients";
        dlg.Header = "Items";

        var ingredients = SaveFile.Instance.Ingredients.Select(i => i.Duplicate()).ToList();
        var categories = new BindingList<Category>(SaveFile.Instance.Categories);

        var grid = dlg.List;
        grid.Mode = GridListControlViewMode.List;
        grid.AutoGenerateColumns = false;
        grid.DataSource = ingredients;
        grid.View.GroupFormat = "[#image]{1} {2}";
        grid.Columns.AddVisible("Name").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

        var cboCategories = new RepositoryItemLookUpEdit();
        cboCategories.DataSource = categories;
        cboCategories.DisplayMember = "Name";
        cboCategories.ValueMember = "ID";

        var clmnCategoryID = grid.Columns.AddVisible("CategoryID");
        clmnCategoryID.ColumnEdit = cboCategories;
        clmnCategoryID.GroupIndex = 0;

        grid.Editor = new IngredientEditor(categories);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Ingredients = ingredients;
        }
      }
    }
  }
}
