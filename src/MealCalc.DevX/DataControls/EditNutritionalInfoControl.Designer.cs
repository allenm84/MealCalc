namespace MealCalc.DevX
{
  partial class EditNutritionalInfoControl
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.servingEditor = new MealCalc.DevX.EditServingControl();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numSodium = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numProtein = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numFat = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numCalories = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numSugar = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numCarbs = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSodium.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numProtein.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFat.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCalories.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSugar.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCarbs.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.numCarbs);
      this.layoutControl1.Controls.Add(this.numSugar);
      this.layoutControl1.Controls.Add(this.numCalories);
      this.layoutControl1.Controls.Add(this.numFat);
      this.layoutControl1.Controls.Add(this.numProtein);
      this.layoutControl1.Controls.Add(this.numSodium);
      this.layoutControl1.Controls.Add(this.servingEditor);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(200, 100);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
      this.layoutControlGroup1.Size = new System.Drawing.Size(200, 100);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // servingEditor
      // 
      this.servingEditor.Location = new System.Drawing.Point(2, 2);
      this.servingEditor.Name = "servingEditor";
      this.servingEditor.Size = new System.Drawing.Size(196, 24);
      this.servingEditor.TabIndex = 0;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.servingEditor;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(200, 28);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // numSodium
      // 
      this.numSodium.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numSodium.Location = new System.Drawing.Point(48, 78);
      this.numSodium.Name = "numSodium";
      this.numSodium.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numSodium.Size = new System.Drawing.Size(50, 20);
      this.numSodium.StyleController = this.layoutControl1;
      this.numSodium.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numSodium;
      this.layoutControlItem2.CustomizationFormText = "Sodium:";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 76);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem2.Text = "Sodium:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(42, 13);
      // 
      // numProtein
      // 
      this.numProtein.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numProtein.Location = new System.Drawing.Point(148, 78);
      this.numProtein.Name = "numProtein";
      this.numProtein.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numProtein.Size = new System.Drawing.Size(50, 20);
      this.numProtein.StyleController = this.layoutControl1;
      this.numProtein.TabIndex = 6;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.numProtein;
      this.layoutControlItem3.CustomizationFormText = "Protein:";
      this.layoutControlItem3.Location = new System.Drawing.Point(100, 76);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem3.Text = "Protein:";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(42, 13);
      // 
      // numFat
      // 
      this.numFat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numFat.Location = new System.Drawing.Point(48, 54);
      this.numFat.Name = "numFat";
      this.numFat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numFat.Size = new System.Drawing.Size(50, 20);
      this.numFat.StyleController = this.layoutControl1;
      this.numFat.TabIndex = 3;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.numFat;
      this.layoutControlItem4.CustomizationFormText = "Fat:";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem4.Text = "Fat:";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(42, 13);
      // 
      // numCalories
      // 
      this.numCalories.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numCalories.Location = new System.Drawing.Point(48, 30);
      this.numCalories.Name = "numCalories";
      this.numCalories.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numCalories.Size = new System.Drawing.Size(50, 20);
      this.numCalories.StyleController = this.layoutControl1;
      this.numCalories.TabIndex = 1;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.numCalories;
      this.layoutControlItem5.CustomizationFormText = "Calories:";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 28);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem5.Text = "Calories:";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(42, 13);
      // 
      // numSugar
      // 
      this.numSugar.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numSugar.Location = new System.Drawing.Point(148, 54);
      this.numSugar.Name = "numSugar";
      this.numSugar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numSugar.Size = new System.Drawing.Size(50, 20);
      this.numSugar.StyleController = this.layoutControl1;
      this.numSugar.TabIndex = 4;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.numSugar;
      this.layoutControlItem6.CustomizationFormText = "Sugar:";
      this.layoutControlItem6.Location = new System.Drawing.Point(100, 52);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem6.Text = "Sugar:";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(42, 13);
      // 
      // numCarbs
      // 
      this.numCarbs.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numCarbs.Location = new System.Drawing.Point(148, 30);
      this.numCarbs.Name = "numCarbs";
      this.numCarbs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numCarbs.Size = new System.Drawing.Size(50, 20);
      this.numCarbs.StyleController = this.layoutControl1;
      this.numCarbs.TabIndex = 2;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.numCarbs;
      this.layoutControlItem7.CustomizationFormText = "Carbs:";
      this.layoutControlItem7.Location = new System.Drawing.Point(100, 28);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(100, 24);
      this.layoutControlItem7.Text = "Carbs:";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(42, 13);
      // 
      // EditNutritionalInfoControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditNutritionalInfoControl";
      this.Size = new System.Drawing.Size(200, 100);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSodium.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numProtein.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFat.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCalories.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSugar.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCarbs.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private EditServingControl servingEditor;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SpinEdit numCarbs;
    private DevExpress.XtraEditors.SpinEdit numSugar;
    private DevExpress.XtraEditors.SpinEdit numCalories;
    private DevExpress.XtraEditors.SpinEdit numFat;
    private DevExpress.XtraEditors.SpinEdit numProtein;
    private DevExpress.XtraEditors.SpinEdit numSodium;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;

  }
}
