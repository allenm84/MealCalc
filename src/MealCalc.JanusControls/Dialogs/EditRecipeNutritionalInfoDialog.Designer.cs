namespace MealCalc.JanusControls
{
  partial class EditRecipeNutritionalInfoDialog
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.gridCalculations = new Janus.Windows.GridEX.GridEX();
      this.ctrlViewNutritionalInfo = new MealCalc.ViewNutritionalInfoControl();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnNew = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.okCancelPanel1 = new MealCalc.JanusControls.OKCancelPanel();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.gridCalculations, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.ctrlViewNutritionalInfo, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 263);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(224, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nutritional Information Previously Calculated:";
      // 
      // gridCalculations
      // 
      this.gridCalculations.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridCalculations.Location = new System.Drawing.Point(3, 23);
      this.gridCalculations.Name = "gridCalculations";
      this.gridCalculations.Size = new System.Drawing.Size(233, 207);
      this.gridCalculations.TabIndex = 1;
      this.gridCalculations.SelectionChanged += new System.EventHandler(this.gridCalculations_SelectionChanged);
      // 
      // ctrlViewNutritionalInfo
      // 
      this.ctrlViewNutritionalInfo.BackColor = System.Drawing.Color.White;
      this.ctrlViewNutritionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlViewNutritionalInfo.Location = new System.Drawing.Point(242, 23);
      this.ctrlViewNutritionalInfo.Name = "ctrlViewNutritionalInfo";
      this.ctrlViewNutritionalInfo.Padding = new System.Windows.Forms.Padding(1);
      this.ctrlViewNutritionalInfo.Size = new System.Drawing.Size(219, 207);
      this.ctrlViewNutritionalInfo.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.btnNew, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnRemove, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.okCancelPanel1, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 233);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(464, 30);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // btnNew
      // 
      this.btnNew.Location = new System.Drawing.Point(3, 3);
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(74, 23);
      this.btnNew.TabIndex = 0;
      this.btnNew.Text = "New";
      this.btnNew.UseVisualStyleBackColor = true;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(83, 3);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(74, 23);
      this.btnRemove.TabIndex = 1;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // okCancelPanel1
      // 
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(160, 0);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(304, 30);
      this.okCancelPanel1.TabIndex = 2;
      // 
      // EditRecipeNutritionalInfoDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 263);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditRecipeNutritionalInfoDialog";
      this.Text = "EditRecipeNutritionalInfoDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private Janus.Windows.GridEX.GridEX gridCalculations;
    private ViewNutritionalInfoControl ctrlViewNutritionalInfo;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnNew;
    private System.Windows.Forms.Button btnRemove;
    private OKCancelPanel okCancelPanel1;
  }
}