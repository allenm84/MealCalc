namespace MealCalc.JanusControls
{
  partial class SelectIngredientDialog
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
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.gridIngredients = new Janus.Windows.GridEX.GridEX();
      this.ctrlEditServing = new MealCalc.JanusControls.EditServingControl();
      this.okCancelPanel1 = new MealCalc.JanusControls.OKCancelPanel();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.ctrlEditServing, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.okCancelPanel1, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 297);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Ingredient:";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.gridIngredients, 0, 1);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 20);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 195);
      this.tableLayoutPanel2.TabIndex = 3;
      // 
      // gridIngredients
      // 
      this.gridIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridIngredients.Location = new System.Drawing.Point(3, 3);
      this.gridIngredients.Name = "gridIngredients";
      this.gridIngredients.Size = new System.Drawing.Size(239, 189);
      this.gridIngredients.TabIndex = 1;
      this.gridIngredients.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridIngredients_RowDoubleClick);
      this.gridIngredients.SelectionChanged += new System.EventHandler(this.gridIngredients_SelectionChanged);
      // 
      // ctrlEditServing
      // 
      this.ctrlEditServing.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ctrlEditServing.Location = new System.Drawing.Point(3, 218);
      this.ctrlEditServing.MaximumSize = new System.Drawing.Size(0, 24);
      this.ctrlEditServing.MinimumSize = new System.Drawing.Size(0, 24);
      this.ctrlEditServing.Name = "ctrlEditServing";
      this.ctrlEditServing.Size = new System.Drawing.Size(239, 24);
      this.ctrlEditServing.TabIndex = 4;
      // 
      // okCancelPanel1
      // 
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(0, 267);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(245, 30);
      this.okCancelPanel1.TabIndex = 5;
      // 
      // linkLabel1
      // 
      this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(41, 249);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(162, 13);
      this.linkLabel1.TabIndex = 6;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "I don\'t see the ingredient I want";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // SelectIngredientDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(245, 297);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectIngredientDialog";
      this.Text = "Select Ingredient";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridIngredients)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private EditServingControl ctrlEditServing;
    private OKCancelPanel okCancelPanel1;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private Janus.Windows.GridEX.GridEX gridIngredients;
  }
}