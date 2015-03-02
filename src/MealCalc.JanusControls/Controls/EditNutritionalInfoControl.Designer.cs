namespace MealCalc.JanusControls
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.servingEditor = new MealCalc.JanusControls.EditServingControl();
      this.label1 = new System.Windows.Forms.Label();
      this.numCalories = new MealCalc.JanusControls.NumericEdit();
      this.label2 = new System.Windows.Forms.Label();
      this.numFat = new MealCalc.JanusControls.NumericEdit();
      this.label3 = new System.Windows.Forms.Label();
      this.numSodium = new MealCalc.JanusControls.NumericEdit();
      this.label4 = new System.Windows.Forms.Label();
      this.numCarbs = new MealCalc.JanusControls.NumericEdit();
      this.label5 = new System.Windows.Forms.Label();
      this.numSugar = new MealCalc.JanusControls.NumericEdit();
      this.label6 = new System.Windows.Forms.Label();
      this.numProtein = new MealCalc.JanusControls.NumericEdit();
      this.chkNoMeasurement = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSodium)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSugar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numProtein)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 6;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.servingEditor, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.numCalories, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.numFat, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.numSodium, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.label4, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.numCarbs, 4, 2);
      this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.numSugar, 4, 3);
      this.tableLayoutPanel1.Controls.Add(this.label6, 3, 4);
      this.tableLayoutPanel1.Controls.Add(this.numProtein, 4, 4);
      this.tableLayoutPanel1.Controls.Add(this.chkNoMeasurement, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 126);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // servingEditor
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.servingEditor, 6);
      this.servingEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.servingEditor.Location = new System.Drawing.Point(0, 24);
      this.servingEditor.Margin = new System.Windows.Forms.Padding(0);
      this.servingEditor.Name = "servingEditor";
      this.servingEditor.Size = new System.Drawing.Size(231, 30);
      this.servingEditor.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Calories:";
      // 
      // numCalories
      // 
      this.numCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numCalories.DecimalPlaces = 2;
      this.numCalories.Location = new System.Drawing.Point(60, 57);
      this.numCalories.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numCalories.Name = "numCalories";
      this.numCalories.Size = new System.Drawing.Size(54, 20);
      this.numCalories.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(25, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Fat:";
      // 
      // numFat
      // 
      this.numFat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numFat.DecimalPlaces = 2;
      this.numFat.Location = new System.Drawing.Point(60, 81);
      this.numFat.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numFat.Name = "numFat";
      this.numFat.Size = new System.Drawing.Size(54, 20);
      this.numFat.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 107);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Sodium:";
      // 
      // numSodium
      // 
      this.numSodium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numSodium.DecimalPlaces = 2;
      this.numSodium.Location = new System.Drawing.Point(60, 105);
      this.numSodium.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numSodium.Name = "numSodium";
      this.numSodium.Size = new System.Drawing.Size(54, 20);
      this.numSodium.TabIndex = 6;
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(120, 59);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Carbs:";
      // 
      // numCarbs
      // 
      this.numCarbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numCarbs.DecimalPlaces = 2;
      this.numCarbs.Location = new System.Drawing.Point(169, 57);
      this.numCarbs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numCarbs.Name = "numCarbs";
      this.numCarbs.Size = new System.Drawing.Size(54, 20);
      this.numCarbs.TabIndex = 8;
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(120, 83);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Sugar:";
      // 
      // numSugar
      // 
      this.numSugar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numSugar.DecimalPlaces = 2;
      this.numSugar.Location = new System.Drawing.Point(169, 81);
      this.numSugar.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numSugar.Name = "numSugar";
      this.numSugar.Size = new System.Drawing.Size(54, 20);
      this.numSugar.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(120, 107);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Protein:";
      // 
      // numProtein
      // 
      this.numProtein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numProtein.DecimalPlaces = 2;
      this.numProtein.Location = new System.Drawing.Point(169, 105);
      this.numProtein.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numProtein.Name = "numProtein";
      this.numProtein.Size = new System.Drawing.Size(54, 20);
      this.numProtein.TabIndex = 12;
      // 
      // chkNoMeasurement
      // 
      this.chkNoMeasurement.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.chkNoMeasurement.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.chkNoMeasurement, 6);
      this.chkNoMeasurement.Location = new System.Drawing.Point(8, 3);
      this.chkNoMeasurement.Name = "chkNoMeasurement";
      this.chkNoMeasurement.Size = new System.Drawing.Size(215, 17);
      this.chkNoMeasurement.TabIndex = 13;
      this.chkNoMeasurement.Text = "Serving is measured in units (e.g. 1 Egg)";
      this.chkNoMeasurement.UseVisualStyleBackColor = true;
      this.chkNoMeasurement.CheckedChanged += new System.EventHandler(this.chkNoMeasurement_CheckedChanged);
      // 
      // EditNutritionalInfoControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "EditNutritionalInfoControl";
      this.Size = new System.Drawing.Size(231, 126);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSodium)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSugar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numProtein)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private EditServingControl servingEditor;
    private System.Windows.Forms.Label label1;
    private NumericEdit numCalories;
    private System.Windows.Forms.Label label2;
    private NumericEdit numFat;
    private System.Windows.Forms.Label label3;
    private NumericEdit numSodium;
    private System.Windows.Forms.Label label4;
    private NumericEdit numCarbs;
    private System.Windows.Forms.Label label5;
    private NumericEdit numSugar;
    private System.Windows.Forms.Label label6;
    private NumericEdit numProtein;
    private System.Windows.Forms.CheckBox chkNoMeasurement;
  }
}
