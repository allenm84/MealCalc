namespace MealCalc.Winforms
{
  partial class EditServingControl
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
      this.numAmount = new MealCalc.Winforms.NumericEdit();
      this.cboMeasurement = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.numAmount, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.cboMeasurement, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 31);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Serving Size:";
      // 
      // numAmount
      // 
      this.numAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numAmount.DecimalPlaces = 2;
      this.numAmount.Location = new System.Drawing.Point(78, 5);
      this.numAmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
      this.numAmount.Name = "numAmount";
      this.numAmount.Size = new System.Drawing.Size(75, 20);
      this.numAmount.TabIndex = 1;
      // 
      // cboMeasurement
      // 
      this.cboMeasurement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboMeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboMeasurement.FormattingEnabled = true;
      this.cboMeasurement.Location = new System.Drawing.Point(159, 5);
      this.cboMeasurement.Name = "cboMeasurement";
      this.cboMeasurement.Size = new System.Drawing.Size(54, 21);
      this.cboMeasurement.TabIndex = 2;
      this.cboMeasurement.SelectedIndexChanged += new System.EventHandler(this.servingValue_Changed);
      // 
      // EditServingControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "EditServingControl";
      this.Size = new System.Drawing.Size(216, 31);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private MealCalc.Winforms.NumericEdit numAmount;
    private System.Windows.Forms.ComboBox cboMeasurement;
  }
}
