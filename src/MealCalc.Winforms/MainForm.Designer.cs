namespace MealCalc.Winforms
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.mainToolStrip = new System.Windows.Forms.ToolStrip();
      this.tbbSave = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.tbbCategories = new System.Windows.Forms.ToolStripButton();
      this.tbbIngredients = new System.Windows.Forms.ToolStripButton();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnRename = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.gridRecipes = new MealCalc.Winforms.GridView();
      this.progStatus = new System.Windows.Forms.ProgressBar();
      this.mainToolStrip.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).BeginInit();
      this.SuspendLayout();
      // 
      // mainToolStrip
      // 
      this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbbSave,
            this.toolStripSeparator1,
            this.tbbCategories,
            this.tbbIngredients});
      this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
      this.mainToolStrip.Name = "mainToolStrip";
      this.mainToolStrip.Size = new System.Drawing.Size(440, 25);
      this.mainToolStrip.TabIndex = 0;
      this.mainToolStrip.Text = "toolStrip1";
      // 
      // tbbSave
      // 
      this.tbbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbbSave.Image")));
      this.tbbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.Size = new System.Drawing.Size(51, 22);
      this.tbbSave.Text = "Save";
      this.tbbSave.Click += new System.EventHandler(this.tbbSave_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // tbbCategories
      // 
      this.tbbCategories.Image = ((System.Drawing.Image)(resources.GetObject("tbbCategories.Image")));
      this.tbbCategories.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbbCategories.Name = "tbbCategories";
      this.tbbCategories.Size = new System.Drawing.Size(83, 22);
      this.tbbCategories.Text = "Categories";
      this.tbbCategories.Click += new System.EventHandler(this.tbbCategories_Click);
      // 
      // tbbIngredients
      // 
      this.tbbIngredients.Image = ((System.Drawing.Image)(resources.GetObject("tbbIngredients.Image")));
      this.tbbIngredients.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbbIngredients.Name = "tbbIngredients";
      this.tbbIngredients.Size = new System.Drawing.Size(86, 22);
      this.tbbIngredients.Text = "Ingredients";
      this.tbbIngredients.Click += new System.EventHandler(this.tbbIngredients_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.gridRecipes, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 274);
      this.tableLayoutPanel1.TabIndex = 1;
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
      this.tableLayoutPanel6.Location = new System.Drawing.Point(360, 20);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 6;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(80, 220);
      this.tableLayoutPanel6.TabIndex = 2;
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
      this.btnRename.Location = new System.Drawing.Point(3, 193);
      this.btnRename.Name = "btnRename";
      this.btnRename.Size = new System.Drawing.Size(74, 23);
      this.btnRename.TabIndex = 4;
      this.btnRename.Text = "Rename";
      this.btnRename.UseVisualStyleBackColor = true;
      this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Recipes:";
      // 
      // gridRecipes
      // 
      this.gridRecipes.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridRecipes.Location = new System.Drawing.Point(7, 23);
      this.gridRecipes.Name = "gridRecipes";
      this.gridRecipes.Size = new System.Drawing.Size(350, 214);
      this.gridRecipes.TabIndex = 1;
      this.gridRecipes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRecipes_CellDoubleClick);
      this.gridRecipes.SelectionChanged += new System.EventHandler(this.gridRecipes_SelectionChanged);
      this.gridRecipes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridRecipes_KeyDown);
      // 
      // progStatus
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.progStatus, 3);
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 247);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(434, 24);
      this.progStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progStatus.TabIndex = 3;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(440, 299);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.mainToolStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MealCalc";
      this.mainToolStrip.ResumeLayout(false);
      this.mainToolStrip.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridRecipes)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip mainToolStrip;
    private System.Windows.Forms.ToolStripButton tbbSave;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripButton tbbCategories;
    private System.Windows.Forms.ToolStripButton tbbIngredients;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private MealCalc.Winforms.GridView gridRecipes;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnRename;
    private System.Windows.Forms.ProgressBar progStatus;
  }
}

