namespace MealCalc.DevX
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbCategories = new DevExpress.XtraBars.BarButtonItem();
      this.tbbIngredients = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.progStatus = new DevExpress.XtraEditors.MarqueeProgressBarControl();
      this.gridRecipes = new MealCalc.DevX.GridListControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbCategories,
            this.tbbIngredients});
      this.barManager1.MaxItemId = 3;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbCategories, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbIngredients, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableClose = true;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.Glyph")));
      this.tbbSave.Id = 0;
      this.tbbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.LargeGlyph")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // tbbCategories
      // 
      this.tbbCategories.Caption = "Categories";
      this.tbbCategories.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbCategories.Glyph")));
      this.tbbCategories.Id = 1;
      this.tbbCategories.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbCategories.LargeGlyph")));
      this.tbbCategories.Name = "tbbCategories";
      this.tbbCategories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbCategories_ItemClick);
      // 
      // tbbIngredients
      // 
      this.tbbIngredients.Caption = "Ingredients";
      this.tbbIngredients.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbIngredients.Glyph")));
      this.tbbIngredients.Id = 2;
      this.tbbIngredients.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbIngredients.LargeGlyph")));
      this.tbbIngredients.Name = "tbbIngredients";
      this.tbbIngredients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbIngredients_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(423, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 344);
      this.barDockControlBottom.Size = new System.Drawing.Size(423, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 313);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(423, 31);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 313);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.progStatus);
      this.layoutControl1.Controls.Add(this.gridRecipes);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(619, 170, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(423, 313);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // progStatus
      // 
      this.progStatus.EditValue = 0;
      this.progStatus.Location = new System.Drawing.Point(12, 283);
      this.progStatus.MenuManager = this.barManager1;
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(399, 18);
      this.progStatus.StyleController = this.layoutControl1;
      this.progStatus.TabIndex = 5;
      // 
      // gridRecipes
      // 
      this.gridRecipes.AutoGenerateColumns = true;
      this.gridRecipes.DataSource = null;
      this.gridRecipes.Editor = null;
      this.gridRecipes.Location = new System.Drawing.Point(24, 43);
      this.gridRecipes.Mode = MealCalc.DevX.GridListControlViewMode.Default;
      this.gridRecipes.Name = "gridRecipes";
      this.gridRecipes.Size = new System.Drawing.Size(375, 224);
      this.gridRecipes.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(423, 313);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Recipes:";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(403, 271);
      this.layoutControlGroup2.Text = "Recipes:";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridRecipes;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(379, 228);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.progStatus;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 271);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(403, 22);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 344);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MealCalc";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.progStatus.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbCategories;
    private DevExpress.XtraBars.BarButtonItem tbbIngredients;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private GridListControl gridRecipes;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.MarqueeProgressBarControl progStatus;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;

  }
}

