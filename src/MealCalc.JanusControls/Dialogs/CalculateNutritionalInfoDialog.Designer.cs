namespace MealCalc.JanusControls
{
  partial class CalculateNutritionalInfoDialog
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
      this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
      this.optCutIntoParts = new System.Windows.Forms.RadioButton();
      this.optEntireRecipe = new System.Windows.Forms.RadioButton();
      this.ctrlShowForServingSize = new MealCalc.JanusControls.EditServingControl();
      this.optServingSize = new System.Windows.Forms.RadioButton();
      this.numParts = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ctrlRecipeAmount = new MealCalc.JanusControls.EditServingControl();
      this.label3 = new System.Windows.Forms.Label();
      this.okCancelPanel1 = new MealCalc.JanusControls.OKCancelPanel();
      this.ctrlViewNutritionalInfo = new MealCalc.ViewNutritionalInfoControl();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel9.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.ctrlRecipeAmount, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.okCancelPanel1, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.ctrlViewNutritionalInfo, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 7;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 275);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel9
      // 
      this.tableLayoutPanel9.ColumnCount = 2;
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel9.Controls.Add(this.optCutIntoParts, 0, 1);
      this.tableLayoutPanel9.Controls.Add(this.optEntireRecipe, 0, 0);
      this.tableLayoutPanel9.Controls.Add(this.ctrlShowForServingSize, 0, 3);
      this.tableLayoutPanel9.Controls.Add(this.optServingSize, 0, 2);
      this.tableLayoutPanel9.Controls.Add(this.numParts, 1, 1);
      this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 120);
      this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel9.Name = "tableLayoutPanel9";
      this.tableLayoutPanel9.RowCount = 4;
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.Size = new System.Drawing.Size(261, 125);
      this.tableLayoutPanel9.TabIndex = 5;
      // 
      // optCutIntoParts
      // 
      this.optCutIntoParts.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.optCutIntoParts.AutoSize = true;
      this.optCutIntoParts.Location = new System.Drawing.Point(5, 38);
      this.optCutIntoParts.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
      this.optCutIntoParts.Name = "optCutIntoParts";
      this.optCutIntoParts.Size = new System.Drawing.Size(192, 17);
      this.optCutIntoParts.TabIndex = 1;
      this.optCutIntoParts.TabStop = true;
      this.optCutIntoParts.Text = "Show info for recipe cut into parts:";
      this.optCutIntoParts.UseVisualStyleBackColor = true;
      this.optCutIntoParts.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // optEntireRecipe
      // 
      this.optEntireRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.optEntireRecipe.AutoSize = true;
      this.optEntireRecipe.Checked = true;
      this.tableLayoutPanel9.SetColumnSpan(this.optEntireRecipe, 2);
      this.optEntireRecipe.Location = new System.Drawing.Point(5, 7);
      this.optEntireRecipe.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
      this.optEntireRecipe.Name = "optEntireRecipe";
      this.optEntireRecipe.Size = new System.Drawing.Size(171, 17);
      this.optEntireRecipe.TabIndex = 0;
      this.optEntireRecipe.TabStop = true;
      this.optEntireRecipe.Text = "Show info for the entire recipe";
      this.optEntireRecipe.UseVisualStyleBackColor = true;
      this.optEntireRecipe.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // ctrlShowForServingSize
      // 
      this.tableLayoutPanel9.SetColumnSpan(this.ctrlShowForServingSize, 2);
      this.ctrlShowForServingSize.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlShowForServingSize.Location = new System.Drawing.Point(21, 96);
      this.ctrlShowForServingSize.Margin = new System.Windows.Forms.Padding(21, 3, 0, 3);
      this.ctrlShowForServingSize.Name = "ctrlShowForServingSize";
      this.ctrlShowForServingSize.Size = new System.Drawing.Size(240, 26);
      this.ctrlShowForServingSize.TabIndex = 4;
      this.ctrlShowForServingSize.ServingChanged += new System.EventHandler(this.ctrlShowForServingSize_ServingChanged);
      // 
      // optServingSize
      // 
      this.optServingSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.optServingSize.AutoSize = true;
      this.optServingSize.Location = new System.Drawing.Point(5, 69);
      this.optServingSize.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
      this.optServingSize.Name = "optServingSize";
      this.optServingSize.Size = new System.Drawing.Size(152, 17);
      this.optServingSize.TabIndex = 3;
      this.optServingSize.TabStop = true;
      this.optServingSize.Text = "Show info for serving size:";
      this.optServingSize.UseVisualStyleBackColor = true;
      this.optServingSize.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // numParts
      // 
      this.numParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numParts.Location = new System.Drawing.Point(204, 36);
      this.numParts.Name = "numParts";
      this.numParts.Size = new System.Drawing.Size(54, 21);
      this.numParts.TabIndex = 5;
      this.numParts.Text = "0.00";
      this.numParts.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(221, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name (you can leave this blank if you want):";
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(3, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(255, 21);
      this.txtName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(156, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "How much did the recipe make:";
      // 
      // ctrlRecipeAmount
      // 
      this.ctrlRecipeAmount.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlRecipeAmount.Location = new System.Drawing.Point(3, 73);
      this.ctrlRecipeAmount.Name = "ctrlRecipeAmount";
      this.ctrlRecipeAmount.Size = new System.Drawing.Size(255, 24);
      this.ctrlRecipeAmount.TabIndex = 3;
      this.ctrlRecipeAmount.ServingChanged += new System.EventHandler(this.ctrlRecipeAmount_ServingChanged);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(172, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "How should the info be calculated:";
      // 
      // okCancelPanel1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.okCancelPanel1, 2);
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(0, 245);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(486, 30);
      this.okCancelPanel1.TabIndex = 6;
      // 
      // ctrlViewNutritionalInfo
      // 
      this.ctrlViewNutritionalInfo.BackColor = System.Drawing.Color.White;
      this.ctrlViewNutritionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlViewNutritionalInfo.Location = new System.Drawing.Point(264, 3);
      this.ctrlViewNutritionalInfo.Name = "ctrlViewNutritionalInfo";
      this.ctrlViewNutritionalInfo.Padding = new System.Windows.Forms.Padding(1);
      this.tableLayoutPanel1.SetRowSpan(this.ctrlViewNutritionalInfo, 6);
      this.ctrlViewNutritionalInfo.Size = new System.Drawing.Size(219, 239);
      this.ctrlViewNutritionalInfo.TabIndex = 7;
      // 
      // CalculateNutritionalInfoDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(486, 275);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CalculateNutritionalInfoDialog";
      this.Text = "New Calculation";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel9.ResumeLayout(false);
      this.tableLayoutPanel9.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label2;
    private EditServingControl ctrlRecipeAmount;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private System.Windows.Forms.RadioButton optCutIntoParts;
    private System.Windows.Forms.RadioButton optEntireRecipe;
    private EditServingControl ctrlShowForServingSize;
    private System.Windows.Forms.RadioButton optServingSize;
    private System.Windows.Forms.Label label3;
    private OKCancelPanel okCancelPanel1;
    private ViewNutritionalInfoControl ctrlViewNutritionalInfo;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numParts;
  }
}