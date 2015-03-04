namespace MealCalc.DevX
{
  partial class GridListControl
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
      this.ctrlButtons = new MealCalc.DevX.EditorButtons();
      this.gridItems = new DevExpress.XtraGrid.GridControl();
      this.itemSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
      this.SuspendLayout();
      // 
      // ctrlButtons
      // 
      this.ctrlButtons.Dock = System.Windows.Forms.DockStyle.Right;
      this.ctrlButtons.Location = new System.Drawing.Point(196, 0);
      this.ctrlButtons.MaximumSize = new System.Drawing.Size(80, 0);
      this.ctrlButtons.MinimumSize = new System.Drawing.Size(80, 120);
      this.ctrlButtons.Name = "ctrlButtons";
      this.ctrlButtons.Size = new System.Drawing.Size(80, 170);
      this.ctrlButtons.TabIndex = 5;
      this.ctrlButtons.AddClick += new System.EventHandler(this.ctrlButtons_AddClick);
      this.ctrlButtons.EditClick += new System.EventHandler(this.ctrlButtons_EditClick);
      this.ctrlButtons.RemoveClick += new System.EventHandler(this.ctrlButtons_RemoveClick);
      this.ctrlButtons.ClearClick += new System.EventHandler(this.ctrlButtons_ClearClick);
      // 
      // gridItems
      // 
      this.gridItems.DataSource = this.itemSource;
      this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridItems.Location = new System.Drawing.Point(0, 0);
      this.gridItems.MainView = this.gridViewItems;
      this.gridItems.Name = "gridItems";
      this.gridItems.Size = new System.Drawing.Size(196, 170);
      this.gridItems.TabIndex = 4;
      this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
      this.gridItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridItems_MouseDoubleClick);
      // 
      // gridViewItems
      // 
      this.gridViewItems.GridControl = this.gridItems;
      this.gridViewItems.Name = "gridViewItems";
      this.gridViewItems.OptionsView.ShowGroupPanel = false;
      this.gridViewItems.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewItems_SelectionChanged);
      this.gridViewItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewItems_KeyDown);
      // 
      // GridListControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridItems);
      this.Controls.Add(this.ctrlButtons);
      this.Name = "GridListControl";
      this.Size = new System.Drawing.Size(276, 170);
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridItems;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
    private MealCalc.DevX.EditorButtons ctrlButtons;
    private System.Windows.Forms.BindingSource itemSource;
  }
}
