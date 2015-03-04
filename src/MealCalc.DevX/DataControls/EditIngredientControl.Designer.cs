namespace MealCalc.DevX
{
  partial class EditIngredientControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.cboCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.categorySource = new System.Windows.Forms.BindingSource(this.components);
      this.cboCategoryView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.nutritionalInfoEditor = new MealCalc.DevX.EditNutritionalInfoControl();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categorySource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategoryView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.cboCategory);
      this.layoutControl1.Controls.Add(this.nutritionalInfoEditor);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(722, 259, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(204, 204);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // cboCategory
      // 
      this.cboCategory.Location = new System.Drawing.Point(2, 58);
      this.cboCategory.Name = "cboCategory";
      this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboCategory.Properties.DataSource = this.categorySource;
      this.cboCategory.Properties.DisplayMember = "Name";
      this.cboCategory.Properties.NullText = "[Select a category]";
      this.cboCategory.Properties.ShowAddNewButton = true;
      this.cboCategory.Properties.ValueMember = "ID";
      this.cboCategory.Properties.View = this.cboCategoryView;
      this.cboCategory.Size = new System.Drawing.Size(200, 20);
      this.cboCategory.StyleController = this.layoutControl1;
      this.cboCategory.TabIndex = 7;
      this.cboCategory.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboCategory_AddNewValue);
      // 
      // categorySource
      // 
      this.categorySource.DataSource = typeof(MealCalc.Category);
      // 
      // cboCategoryView
      // 
      this.cboCategoryView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.cboCategoryView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.cboCategoryView.Name = "cboCategoryView";
      this.cboCategoryView.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.cboCategoryView.OptionsView.ShowColumnHeaders = false;
      this.cboCategoryView.OptionsView.ShowGroupPanel = false;
      this.cboCategoryView.OptionsView.ShowIndicator = false;
      this.cboCategoryView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // nutritionalInfoEditor
      // 
      this.nutritionalInfoEditor.Location = new System.Drawing.Point(2, 98);
      this.nutritionalInfoEditor.Name = "nutritionalInfoEditor";
      this.nutritionalInfoEditor.Size = new System.Drawing.Size(200, 100);
      this.nutritionalInfoEditor.TabIndex = 6;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(2, 18);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(200, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(204, 204);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtName;
      this.layoutControlItem1.CustomizationFormText = "Name:";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(204, 40);
      this.layoutControlItem1.Text = "Name:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(74, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.nutritionalInfoEditor;
      this.layoutControlItem3.CustomizationFormText = "Nutrition Facts:";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(204, 124);
      this.layoutControlItem3.Text = "Nutrition Facts:";
      this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(74, 13);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.cboCategory;
      this.layoutControlItem2.CustomizationFormText = "Category:";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(204, 40);
      this.layoutControlItem2.Text = "Category:";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(74, 13);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // EditIngredientControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditIngredientControl";
      this.Size = new System.Drawing.Size(204, 204);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categorySource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategoryView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private EditNutritionalInfoControl nutritionalInfoEditor;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.SearchLookUpEdit cboCategory;
    private DevExpress.XtraGrid.Views.Grid.GridView cboCategoryView;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private System.Windows.Forms.BindingSource categorySource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
  }
}
