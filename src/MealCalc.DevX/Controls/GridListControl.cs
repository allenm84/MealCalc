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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace MealCalc.DevX
{
  public partial class GridListControl : XtraUserControl
  {
    private GridListControlViewMode mMode = GridListControlViewMode.Default;

    public bool AutoGenerateColumns
    {
      get { return gridViewItems.OptionsBehavior.AutoPopulateColumns; }
      set { gridViewItems.OptionsBehavior.AutoPopulateColumns = value; }
    }

    public object DataSource
    {
      get { return itemSource.DataSource; }
      set { itemSource.DataSource = value; }
    }

    public GridColumnCollection Columns
    {
      get { return gridViewItems.Columns; }
    }

    public GridView View
    {
      get { return gridViewItems; }
    }

    public GridListControlViewMode Mode
    {
      get { return mMode; }
      set
      {
        if (value != mMode)
        {
          mMode = value;
          UpdateViewOptions();
        }
      }
    }

    public IEditor Editor { get; set; }

    public GridListControl()
    {
      InitializeComponent();
      UpdateViewOptions();
      UpdateButtonsAsync();
    }

    public void ScrollToRow(int rowHandle)
    {
      gridViewItems.FocusedRowHandle = rowHandle;
      gridViewItems.SelectRow(rowHandle);
      gridViewItems.MakeRowVisible(rowHandle);
    }

    private void UpdateViewOptions()
    {
      bool autoGenerateColumns = AutoGenerateColumns;
      switch (mMode)
      {
        case GridListControlViewMode.Default:
          {
            gridViewItems.OptionsBehavior.Reset();
            gridViewItems.OptionsCustomization.Reset();
            gridViewItems.OptionsDetail.Reset();
            gridViewItems.OptionsEditForm.Reset();
            gridViewItems.OptionsFilter.Reset();
            gridViewItems.OptionsFind.Reset();
            gridViewItems.OptionsHint.Reset();
            gridViewItems.OptionsLayout.Reset();
            gridViewItems.OptionsMenu.Reset();
            gridViewItems.OptionsNavigation.Reset();
            gridViewItems.OptionsPrint.Reset();
            gridViewItems.OptionsSelection.Reset();
            gridViewItems.OptionsView.Reset();
            break;
          }
        case GridListControlViewMode.List:
          {
            gridViewItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewItems.OptionsBehavior.AllowIncrementalSearch = true;
            gridViewItems.OptionsBehavior.Editable = false;
            gridViewItems.OptionsBehavior.ReadOnly = true;

            gridViewItems.OptionsCustomization.AllowColumnMoving = false;
            gridViewItems.OptionsCustomization.AllowColumnResizing = false;
            gridViewItems.OptionsCustomization.AllowRowSizing = false;

            gridViewItems.OptionsDetail.EnableMasterViewMode = false;

            gridViewItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewItems.OptionsSelection.EnableAppearanceFocusedRow = true;
            gridViewItems.OptionsSelection.EnableAppearanceHideSelection = true;
            gridViewItems.OptionsSelection.MultiSelect = true;
            gridViewItems.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            gridViewItems.OptionsSelection.UseIndicatorForSelection = false;

            gridViewItems.OptionsView.ShowColumnHeaders = false;
            gridViewItems.OptionsView.ShowGroupPanel = false;
            gridViewItems.OptionsView.ShowIndicator = false;
            break;
          }
      }
    }

    private async void UpdateButtonsAsync()
    {
      await Task.Yield();
      UpdateButtons();
    }

    private void UpdateButtons()
    {
      ctrlButtons.UpdateButtons(gridViewItems.SelectedRowsCount, itemSource.Count);
    }

    private void EditByRow(object row)
    {
      var editor = Editor;
      object editedValue;

      if (editor != null && editor.EditValue(this, row, out editedValue))
      {
        int index = itemSource.IndexOf(row);
        itemSource[index] = editedValue;
      }
    }

    private void ctrlButtons_AddClick(object sender, EventArgs e)
    {
      var editor = Editor;
      object newValue;

      if (editor != null && editor.AddValue(this, out newValue))
      {
        itemSource.Add(newValue);
      }
    }

    private void ctrlButtons_EditClick(object sender, EventArgs e)
    {
      EditByRow(gridViewItems.GetFocusedRow());
    }

    private void ctrlButtons_RemoveClick(object sender, EventArgs e)
    {
      if (MessageHelper.Confirm(this, "Are you sure you want to remove the selected items?"))
      {
        gridViewItems.DeleteSelectedRows();
      }
    }

    private void ctrlButtons_ClearClick(object sender, EventArgs e)
    {
      if (MessageHelper.Confirm(this, "Are you sure you want to remove all of the items?"))
      {
        itemSource.Clear();
      }
    }

    private void gridItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button.HasFlag(MouseButtons.Left))
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && !info.InGroupRow)
        {
          EditByRow(gridViewItems.GetRow(info.RowHandle));
        }
      }
    }

    private void gridViewItems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        ctrlButtons.Remove();
      }
    }

    private void gridViewItems_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      UpdateButtons();
    }
  }

  public enum GridListControlViewMode
  {
    Default,
    List,
  }
}
