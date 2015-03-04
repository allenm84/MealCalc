namespace MealCalc.DevX
{
  partial class IngredientListEditor
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
      this.gridListControl1 = new MealCalc.DevX.GridListControl();
      this.SuspendLayout();
      // 
      // gridListControl1
      // 
      this.gridListControl1.AutoGenerateColumns = true;
      this.gridListControl1.DataSource = null;
      this.gridListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridListControl1.Editor = null;
      this.gridListControl1.Location = new System.Drawing.Point(0, 0);
      this.gridListControl1.Mode = MealCalc.DevX.GridListControlViewMode.Default;
      this.gridListControl1.Name = "gridListControl1";
      this.gridListControl1.Size = new System.Drawing.Size(361, 180);
      this.gridListControl1.TabIndex = 0;
      // 
      // IngredientListEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridListControl1);
      this.Name = "IngredientListEditor";
      this.Size = new System.Drawing.Size(361, 180);
      this.ResumeLayout(false);

    }

    #endregion

    private GridListControl gridListControl1;
  }
}
