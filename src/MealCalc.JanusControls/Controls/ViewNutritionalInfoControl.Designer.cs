namespace MealCalc
{
  partial class ViewNutritionalInfoControl
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
      if (disposing)
      {
        if (borderPen != null)
        {
          borderPen.Dispose();
          borderPen = null;
        }

        if (components != null)
        {
          components.Dispose();
        }
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
      this.radLabel2 = new System.Windows.Forms.Label();
      this.lblCalories = new System.Windows.Forms.Label();
      this.lblFat = new System.Windows.Forms.Label();
      this.lblSodium = new System.Windows.Forms.Label();
      this.lblSugar = new System.Windows.Forms.Label();
      this.lblProtein = new System.Windows.Forms.Label();
      this.lblCarbs = new System.Windows.Forms.Label();
      this.lblServingSize = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblCalories, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblFat, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblSodium, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.lblSugar, 0, 7);
      this.tableLayoutPanel1.Controls.Add(this.lblProtein, 0, 8);
      this.tableLayoutPanel1.Controls.Add(this.lblCarbs, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.lblServingSize, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 10;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 246);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // radLabel2
      // 
      this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.radLabel2.AutoSize = true;
      this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radLabel2.Location = new System.Drawing.Point(28, 41);
      this.radLabel2.Margin = new System.Windows.Forms.Padding(3);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(160, 30);
      this.radLabel2.TabIndex = 1;
      this.radLabel2.Text = "Nutrition Facts";
      // 
      // lblCalories
      // 
      this.lblCalories.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblCalories.AutoSize = true;
      this.lblCalories.Location = new System.Drawing.Point(76, 96);
      this.lblCalories.Margin = new System.Windows.Forms.Padding(3);
      this.lblCalories.Name = "lblCalories";
      this.lblCalories.Size = new System.Drawing.Size(65, 13);
      this.lblCalories.TabIndex = 3;
      this.lblCalories.Text = "Calories 250";
      // 
      // lblFat
      // 
      this.lblFat.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblFat.AutoSize = true;
      this.lblFat.Location = new System.Drawing.Point(87, 115);
      this.lblFat.Margin = new System.Windows.Forms.Padding(3);
      this.lblFat.Name = "lblFat";
      this.lblFat.Size = new System.Drawing.Size(43, 13);
      this.lblFat.TabIndex = 4;
      this.lblFat.Text = "Fat 15g";
      // 
      // lblSodium
      // 
      this.lblSodium.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblSodium.AutoSize = true;
      this.lblSodium.Location = new System.Drawing.Point(73, 134);
      this.lblSodium.Margin = new System.Windows.Forms.Padding(3);
      this.lblSodium.Name = "lblSodium";
      this.lblSodium.Size = new System.Drawing.Size(71, 13);
      this.lblSodium.TabIndex = 5;
      this.lblSodium.Text = "Sodium 75mg";
      // 
      // lblSugar
      // 
      this.lblSugar.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblSugar.AutoSize = true;
      this.lblSugar.Location = new System.Drawing.Point(80, 172);
      this.lblSugar.Margin = new System.Windows.Forms.Padding(3);
      this.lblSugar.Name = "lblSugar";
      this.lblSugar.Size = new System.Drawing.Size(56, 13);
      this.lblSugar.TabIndex = 6;
      this.lblSugar.Text = "Sugar 26g";
      // 
      // lblProtein
      // 
      this.lblProtein.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblProtein.AutoSize = true;
      this.lblProtein.Location = new System.Drawing.Point(81, 191);
      this.lblProtein.Margin = new System.Windows.Forms.Padding(3);
      this.lblProtein.Name = "lblProtein";
      this.lblProtein.Size = new System.Drawing.Size(55, 13);
      this.lblProtein.TabIndex = 7;
      this.lblProtein.Text = "Protein 4g";
      // 
      // lblCarbs
      // 
      this.lblCarbs.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblCarbs.AutoSize = true;
      this.lblCarbs.Location = new System.Drawing.Point(81, 153);
      this.lblCarbs.Margin = new System.Windows.Forms.Padding(3);
      this.lblCarbs.Name = "lblCarbs";
      this.lblCarbs.Size = new System.Drawing.Size(55, 13);
      this.lblCarbs.TabIndex = 8;
      this.lblCarbs.Text = "Carbs 26g";
      // 
      // lblServingSize
      // 
      this.lblServingSize.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblServingSize.AutoSize = true;
      this.lblServingSize.Location = new System.Drawing.Point(52, 77);
      this.lblServingSize.Margin = new System.Windows.Forms.Padding(3);
      this.lblServingSize.Name = "lblServingSize";
      this.lblServingSize.Size = new System.Drawing.Size(112, 13);
      this.lblServingSize.TabIndex = 9;
      this.lblServingSize.Text = "Serving Size 1/2 cups";
      // 
      // ViewNutritionalInfoControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ViewNutritionalInfoControl";
      this.Padding = new System.Windows.Forms.Padding(1);
      this.Size = new System.Drawing.Size(219, 248);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label radLabel2;
    private System.Windows.Forms.Label lblCalories;
    private System.Windows.Forms.Label lblFat;
    private System.Windows.Forms.Label lblSodium;
    private System.Windows.Forms.Label lblSugar;
    private System.Windows.Forms.Label lblProtein;
    private System.Windows.Forms.Label lblCarbs;
    private System.Windows.Forms.Label lblServingSize;
  }
}
