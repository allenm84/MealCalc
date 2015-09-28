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
using DevExpress.Utils.Menu;
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
      gridRecipes.View.PopupMenuShowing += gridRecipes_PopupMenuShowing;
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

    private void gridRecipes_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
    {
      if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
      {
        var item = new DXMenuItem("Copy To Ingredient", CopyToIngredient);
        item.Tag = e.HitInfo.View.GetRow(e.HitInfo.RowHandle) as Recipe;
        e.Menu.Items.Clear();
        e.Menu.Items.Add(item);
      }
    }

    private void CopyToIngredient(object sender, EventArgs e)
    {
      var item = sender as DXMenuItem;
      if (item == null)
      {
        return;
      }

      var recipe = item.Tag as Recipe;
      if (recipe == null)
      {
        return;
      }

      var message = string.Format("Are you sure you want to copy {0} to an ingredient?", recipe.Name);
      if (MessageHelper.Confirm(this, message))
      {
        var ingredients = SaveFile.Instance.Ingredients;
        var name = string.Format("{0} as Ingredient", recipe.Name);
        var ingredient = Factory.NewIngredient(name);
        var info = Calculator.CalculateNutritionalInfo(recipe.Ingredients, ingredients);
        using (var dlg = new EditServingDialog())
        {
          if (dlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
          {
            return;
          }

          var size = Factory.NewServing();
          dlg.Dehydrate(size);
          size = Calculator.ToCups(size);

          decimal divisor = 0;
          if (size.Amount > 0)
          {
            divisor = info.ServingSize.Amount / size.Amount;
          }

          if (divisor != 0)
          {
            info = Calculator.Divide(info, divisor);
          }
        }

        ingredient.Info = Calculator.Round(info);
        ingredient.CategoryID = null;
        DeferEditIngredient(ingredient);
      }
    }

    private async void DeferEditIngredient(Ingredient ingredient)
    {
      await Task.Yield();
      using (var dlg = new EditIngredientDialog(ingredient, SaveFile.Instance.Categories))
      {
        dlg.Text = "Confirm Copy";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Ingredients.Add(ingredient);
          MessageHelper.Inform(this, "Ingredient has been created from recipe!");
        }
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
