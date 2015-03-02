namespace MealCalc.JanusControls
{
  partial class TextInputDialog
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
      this.lblPrompt = new System.Windows.Forms.Label();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.okCancelPanel1 = new MealCalc.JanusControls.OKCancelPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.lblPrompt, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.okCancelPanel1, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 77);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // lblPrompt
      // 
      this.lblPrompt.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblPrompt.AutoSize = true;
      this.lblPrompt.Location = new System.Drawing.Point(3, 3);
      this.lblPrompt.Name = "lblPrompt";
      this.lblPrompt.Size = new System.Drawing.Size(36, 13);
      this.lblPrompt.TabIndex = 0;
      this.lblPrompt.Text = "Label:";
      // 
      // txtInput
      // 
      this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtInput.Location = new System.Drawing.Point(3, 23);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(278, 21);
      this.txtInput.TabIndex = 1;
      this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
      // 
      // okCancelPanel1
      // 
      this.okCancelPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.okCancelPanel1.Location = new System.Drawing.Point(0, 47);
      this.okCancelPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.okCancelPanel1.Name = "okCancelPanel1";
      this.okCancelPanel1.Size = new System.Drawing.Size(284, 30);
      this.okCancelPanel1.TabIndex = 2;
      // 
      // TextInputDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 77);
      this.Controls.Add(this.tableLayoutPanel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "TextInputDialog";
      this.Text = "TextInputDialog";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblPrompt;
    private System.Windows.Forms.TextBox txtInput;
    private OKCancelPanel okCancelPanel1;
  }
}