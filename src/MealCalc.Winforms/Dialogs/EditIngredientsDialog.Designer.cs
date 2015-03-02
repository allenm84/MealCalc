namespace MealCalc.Winforms
{
  partial class EditIngredientsDialog
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
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnRename = new System.Windows.Forms.Button();
      this.gridIngredients = new MealCalc.Winforms.GridView();
      this.okCancelPanel1 = new MealCalc.Winforms.OKCancelPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.okCancelPanel1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 285);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.gridIngredients, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(347, 255);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 1;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.Controls.Add(this.btnAdd, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnEdit, 0, 1);
      this.tableLayoutPanel6.Controls.Add(this.btnRemove, 0, 2);
      this.tableLayoutPanel6.Controls.Add(this.btnClear, 0, 3);
      this.tableLayoutPanel6.Controls.Add(this.btnRename, 0, 5);
      this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel6.Location = new System.Drawing.Point(267, 0);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 6;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(80, 255);
      this.tableLayoutPanel6.TabIndex = 3;
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
      // btnRename
      // 
      this.btnRename.Location = new System.Drawing.Point(3, 228);
      this.btnRename.Name = "btnRename";
      this.btnRename.Size = new System.Drawing.Size(74, 23);
      this.btnRename.TabIndex = 4;
      this.btnRename.Text = "Rename";
      this.btnRename.UseVisualStyleBackColor = true;
      this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
      // 
      // gridIngredients
      // 
      this.gridIngredients.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridIngredients.Location = new System.Drawing.Point(3, 3);
      this.gridIngredients.Name = "gridIngredients";
      this.gridIngredients.Size = new System.Drawing.Size(261, 249);
      this.gridIngredients.TabIndex = 0;
      this.gridIngredients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIngredients_CellDoubleClick);
      this.gridIngredients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridIngredients_KeyDown);
      // 
      // okCancelPanel1
      // 
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(0, 255);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(347, 30);
      this.okCancelPanel1.TabIndex = 1;
      // 
      // EditIngredientsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(347, 285);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "EditIngredientsDialog";
      this.Text = "EditIngredientsDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private GridView gridIngredients;
    private OKCancelPanel okCancelPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnRename;
  }
}