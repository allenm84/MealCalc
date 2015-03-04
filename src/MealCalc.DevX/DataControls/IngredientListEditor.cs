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
using DevExpress.XtraEditors.Repository;

namespace MealCalc.DevX
{
  public partial class IngredientListEditor : XtraUserControl
  {
    private readonly BindingSource ingredientSource;
    private bool initiailized = false;
    private BindingList<IngredientRef> bsIngredients;

    public event EventHandler ListChanged;

    public IngredientListEditor()
    {
      InitializeComponent();
      ingredientSource = new BindingSource();
    }

    public void SetupEditor(IList<IngredientRef> ingredients)
    {
      if (initiailized)
        throw new InvalidOperationException("Editor has already been initialized");
      initiailized = true;

      ingredientSource.DataSource = SaveFile.Instance.Ingredients;

      bsIngredients = new BindingList<IngredientRef>(ingredients);
      bsIngredients.ListChanged += bsIngredients_ListChanged;

      gridListControl1.Editor = new IngredientRefEditor(ingredientSource);
      gridListControl1.AutoGenerateColumns = false;
      gridListControl1.DataSource = bsIngredients;

      var cboIngredients = new RepositoryItemLookUpEdit();
      cboIngredients.DataSource = ingredientSource;
      cboIngredients.DisplayMember = "Name";
      cboIngredients.ValueMember = "ID";

      var clmnIngredientID = gridListControl1.View.Columns.AddField("IngredientID");
      clmnIngredientID.ColumnEdit = cboIngredients;
      clmnIngredientID.Visible = false;
      clmnIngredientID.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
      clmnIngredientID.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;

      var clmnDisplay = gridListControl1.View.Columns.AddField("IngredientDisplay");
      clmnDisplay.UnboundType = DevExpress.Data.UnboundColumnType.String;
      clmnDisplay.Visible = true;
      clmnDisplay.VisibleIndex = 0;

      gridListControl1.Mode = GridListControlViewMode.List;
      gridListControl1.View.CustomUnboundColumnData += lstIngredients_CustomUnboundColumnData;
    }

    public NutritionalInfo CalculateNutritionInfo()
    {
      return Calculator.CalculateNutritionalInfo(bsIngredients, ingredientSource.Cast<Ingredient>());
    }

    private void bsIngredients_ListChanged(object sender, ListChangedEventArgs e)
    {
      var changed = ListChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }
    }

    private void lstIngredients_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      if (e.Column.FieldName == "IngredientDisplay")
      {
        try
        {
          var ingredient = e.Row as IngredientRef;
          e.Value = Display.GetDisplay(ingredient, ingredientSource.OfType<Ingredient>());
        }
        catch
        {
          e.Value = "[Unknown]";
        }
      }
    }
  }
}
