namespace MealCalc.Winforms
{
  partial class EditRecipeDialog
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
      this.okCancelPanel1 = new MealCalc.Winforms.OKCancelPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.txtName = new System.Windows.Forms.TextBox();
      this.chkFavorite = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.gridIngredients = new MealCalc.Winforms.GridView();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.ctrlViewNutritionalInfo = new MealCalc.ViewNutritionalInfoControl();
      this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
      this.numParts = new MealCalc.Winforms.NumericEdit();
      this.optCutIntoParts = new System.Windows.Forms.RadioButton();
      this.optEntireRecipe = new System.Windows.Forms.RadioButton();
      this.ctrlEditServing = new MealCalc.Winforms.EditServingControl();
      this.optServingSize = new System.Windows.Forms.RadioButton();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).BeginInit();
      this.tableLayoutPanel6.SuspendLayout();
      this.tableLayoutPanel7.SuspendLayout();
      this.tableLayoutPanel9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numParts)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.okCancelPanel1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 370);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // okCancelPanel1
      // 
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(0, 340);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(560, 30);
      this.okCancelPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(560, 340);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 3);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 4;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(290, 340);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel4.Controls.Add(this.txtName, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.chkFavorite, 1, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 20);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(290, 30);
      this.tableLayoutPanel4.TabIndex = 1;
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(3, 4);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(204, 21);
      this.txtName.TabIndex = 0;
      // 
      // chkFavorite
      // 
      this.chkFavorite.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.chkFavorite.AutoSize = true;
      this.chkFavorite.Location = new System.Drawing.Point(217, 6);
      this.chkFavorite.Name = "chkFavorite";
      this.chkFavorite.Size = new System.Drawing.Size(66, 17);
      this.chkFavorite.TabIndex = 1;
      this.chkFavorite.Text = "Favorite";
      this.chkFavorite.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ingredients:";
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel5.Controls.Add(this.gridIngredients, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 70);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(290, 270);
      this.tableLayoutPanel5.TabIndex = 3;
      // 
      // gridIngredients
      // 
      this.gridIngredients.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridIngredients.Location = new System.Drawing.Point(3, 3);
      this.gridIngredients.Name = "gridIngredients";
      this.gridIngredients.Size = new System.Drawing.Size(204, 264);
      this.gridIngredients.TabIndex = 0;
      this.gridIngredients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIngredients_CellDoubleClick);
      this.gridIngredients.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridIngredients_CellFormatting);
      this.gridIngredients.SelectionChanged += new System.EventHandler(this.gridIngredients_SelectionChanged);
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 1;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.Controls.Add(this.btnAdd, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnEdit, 0, 1);
      this.tableLayoutPanel6.Controls.Add(this.btnRemove, 0, 2);
      this.tableLayoutPanel6.Controls.Add(this.btnClear, 0, 3);
      this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel6.Location = new System.Drawing.Point(210, 0);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 5;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(80, 270);
      this.tableLayoutPanel6.TabIndex = 1;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(3, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(74, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(3, 33);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(74, 23);
      this.btnEdit.TabIndex = 1;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(3, 63);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(74, 23);
      this.btnRemove.TabIndex = 2;
      this.btnRemove.Text = "Remove";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(3, 93);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(74, 23);
      this.btnClear.TabIndex = 3;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.ColumnCount = 1;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.ctrlViewNutritionalInfo, 0, 1);
      this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 2);
      this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel7.Location = new System.Drawing.Point(295, 0);
      this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 3;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(265, 340);
      this.tableLayoutPanel7.TabIndex = 0;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(162, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Nutrional Information for recipe:";
      // 
      // ctrlViewNutritionalInfo
      // 
      this.ctrlViewNutritionalInfo.BackColor = System.Drawing.SystemColors.Window;
      this.ctrlViewNutritionalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlViewNutritionalInfo.Location = new System.Drawing.Point(3, 23);
      this.ctrlViewNutritionalInfo.Name = "ctrlViewNutritionalInfo";
      this.ctrlViewNutritionalInfo.Padding = new System.Windows.Forms.Padding(1);
      this.ctrlViewNutritionalInfo.ShowServingSize = true;
      this.ctrlViewNutritionalInfo.Size = new System.Drawing.Size(259, 194);
      this.ctrlViewNutritionalInfo.TabIndex = 1;
      // 
      // tableLayoutPanel9
      // 
      this.tableLayoutPanel9.ColumnCount = 2;
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel9.Controls.Add(this.numParts, 1, 1);
      this.tableLayoutPanel9.Controls.Add(this.optCutIntoParts, 0, 1);
      this.tableLayoutPanel9.Controls.Add(this.optEntireRecipe, 0, 0);
      this.tableLayoutPanel9.Controls.Add(this.ctrlEditServing, 0, 3);
      this.tableLayoutPanel9.Controls.Add(this.optServingSize, 0, 2);
      this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 220);
      this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel9.Name = "tableLayoutPanel9";
      this.tableLayoutPanel9.RowCount = 4;
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel9.Size = new System.Drawing.Size(265, 120);
      this.tableLayoutPanel9.TabIndex = 4;
      // 
      // numParts
      // 
      this.numParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numParts.Location = new System.Drawing.Point(208, 34);
      this.numParts.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numParts.Name = "numParts";
      this.numParts.Size = new System.Drawing.Size(54, 21);
      this.numParts.TabIndex = 2;
      this.numParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.numParts.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numParts.ValueChanged += new System.EventHandler(this.numParts_ValueChanged);
      // 
      // optCutIntoParts
      // 
      this.optCutIntoParts.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.optCutIntoParts.AutoSize = true;
      this.optCutIntoParts.Location = new System.Drawing.Point(3, 36);
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
      this.optEntireRecipe.Location = new System.Drawing.Point(3, 6);
      this.optEntireRecipe.Name = "optEntireRecipe";
      this.optEntireRecipe.Size = new System.Drawing.Size(171, 17);
      this.optEntireRecipe.TabIndex = 0;
      this.optEntireRecipe.TabStop = true;
      this.optEntireRecipe.Text = "Show info for the entire recipe";
      this.optEntireRecipe.UseVisualStyleBackColor = true;
      this.optEntireRecipe.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // ctrlEditServing
      // 
      this.tableLayoutPanel9.SetColumnSpan(this.ctrlEditServing, 2);
      this.ctrlEditServing.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlEditServing.Location = new System.Drawing.Point(21, 93);
      this.ctrlEditServing.Margin = new System.Windows.Forms.Padding(21, 3, 0, 3);
      this.ctrlEditServing.Name = "ctrlEditServing";
      this.ctrlEditServing.Size = new System.Drawing.Size(244, 24);
      this.ctrlEditServing.TabIndex = 4;
      this.ctrlEditServing.ServingChanged += new System.EventHandler(this.ctrlEditServing_ServingChanged);
      // 
      // optServingSize
      // 
      this.optServingSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.optServingSize.AutoSize = true;
      this.optServingSize.Location = new System.Drawing.Point(3, 66);
      this.optServingSize.Name = "optServingSize";
      this.optServingSize.Size = new System.Drawing.Size(152, 17);
      this.optServingSize.TabIndex = 3;
      this.optServingSize.TabStop = true;
      this.optServingSize.Text = "Show info for serving size:";
      this.optServingSize.UseVisualStyleBackColor = true;
      this.optServingSize.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // EditRecipeDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 370);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "EditRecipeDialog";
      this.Text = "EditRecipeDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).EndInit();
      this.tableLayoutPanel6.ResumeLayout(false);
      this.tableLayoutPanel7.ResumeLayout(false);
      this.tableLayoutPanel7.PerformLayout();
      this.tableLayoutPanel9.ResumeLayout(false);
      this.tableLayoutPanel9.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numParts)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.CheckBox chkFavorite;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private GridView gridIngredients;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private System.Windows.Forms.Label label3;
    private ViewNutritionalInfoControl ctrlViewNutritionalInfo;
    private System.Windows.Forms.RadioButton optEntireRecipe;
    private System.Windows.Forms.RadioButton optCutIntoParts;
    private MealCalc.Winforms.NumericEdit numParts;
    private OKCancelPanel okCancelPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    private EditServingControl ctrlEditServing;
    private System.Windows.Forms.RadioButton optServingSize;
  }
}