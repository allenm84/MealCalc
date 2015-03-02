namespace MealCalc.JanusControls
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.nutritionalInfoEditor = new MealCalc.JanusControls.EditNutritionalInfoControl();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.cboCategories = new System.Windows.Forms.ComboBox();
      this.btnAddNewCategory = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.nutritionalInfoEditor, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 6;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 253);
      this.tableLayoutPanel1.TabIndex = 0;
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
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Location = new System.Drawing.Point(3, 25);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(222, 20);
      this.txtName.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Category:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Nutrition Facts:";
      // 
      // nutritionalInfoEditor
      // 
      this.nutritionalInfoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.nutritionalInfoEditor.Location = new System.Drawing.Point(3, 123);
      this.nutritionalInfoEditor.Name = "nutritionalInfoEditor";
      this.nutritionalInfoEditor.Size = new System.Drawing.Size(222, 127);
      this.nutritionalInfoEditor.TabIndex = 5;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.cboCategories, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnAddNewCategory, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 70);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(228, 30);
      this.tableLayoutPanel2.TabIndex = 6;
      // 
      // cboCategories
      // 
      this.cboCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCategories.FormattingEnabled = true;
      this.cboCategories.Location = new System.Drawing.Point(3, 4);
      this.cboCategories.Name = "cboCategories";
      this.cboCategories.Size = new System.Drawing.Size(142, 21);
      this.cboCategories.TabIndex = 3;
      // 
      // btnAddNewCategory
      // 
      this.btnAddNewCategory.Location = new System.Drawing.Point(151, 3);
      this.btnAddNewCategory.Name = "btnAddNewCategory";
      this.btnAddNewCategory.Size = new System.Drawing.Size(74, 23);
      this.btnAddNewCategory.TabIndex = 4;
      this.btnAddNewCategory.Text = "Create";
      this.btnAddNewCategory.UseVisualStyleBackColor = true;
      this.btnAddNewCategory.Click += new System.EventHandler(this.btnAddNewCategory_Click);
      // 
      // EditIngredientControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "EditIngredientControl";
      this.Size = new System.Drawing.Size(228, 253);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cboCategories;
    private System.Windows.Forms.Label label3;
    private EditNutritionalInfoControl nutritionalInfoEditor;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnAddNewCategory;
  }
}
