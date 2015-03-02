using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MealCalc.JanusControls
{
  public partial class EditRecipeNutritionalInfoDialog : BaseForm
  {
    private BindingList<Calculation> calculations;
    private RecipeCalculatorSession session;

    public IEnumerable<Calculation> Calculations
    {
      get
      {
        foreach (var calc in calculations)
        {
          yield return calc;
        }
      }
    }

    public EditRecipeNutritionalInfoDialog()
    {
      InitializeComponent();
    }

    public void Populate(RecipeCalculatorSession session)
    {
      calculations = new BindingList<Calculation>();
      calculations.AddRange(session.Calculations);

      this.session = session;
      EmptyInfo();
    }

    private void EmptyInfo()
    {
      ctrlViewNutritionalInfo.ServingSize = "0 cups";
      ctrlViewNutritionalInfo.Populate(Factory.NewNutritionalInfo());
    }

    private void ViewCalculationFromRow(GridEXRow row)
    {
      if (row == null)
      {
        EmptyInfo();
        return;
      }
      ViewCalculationFromItem(row.DataRow as Calculation);
    }

    private void ViewCalculationFromItem(Calculation calculation)
    {
      if (calculation == null)
      {
        EmptyInfo();
        return;
      }

      var info = calculation.Info;
      ctrlViewNutritionalInfo.Populate(info);
      ctrlViewNutritionalInfo.ServingSize = Accessor.GetServingSizeText(info);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      gridCalculations.SetPropertiesToList(true, false);
      gridCalculations.DataSource = calculations;
      gridCalculations.RetrieveStructure();
      gridCalculations.RootTable.Columns.HideAllExcept("Name");
      gridCalculations.RootTable.SortKeys.Add("Name");
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
      using (var dlg = new CalculateNutritionalInfoDialog())
      {
        dlg.Setup(session.References, session.Ingredients);
        if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          var calculation = dlg.CreateCalculation();
          calculations.Add(calculation);

          var row = gridCalculations.GetRow(calculation);
          gridCalculations.MoveTo(row);
        }
      }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = MessageBox.Show(this, "Are you sure you want to remove the selected calculations?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      var selected = gridCalculations.GetSelectedItems<Calculation>().ToArray();
      gridCalculations.SuspendBinding();
      foreach (var value in selected)
      {
        calculations.Remove(value);
      }
      gridCalculations.ResumeBinding();
    }

    private void gridCalculations_SelectionChanged(object sender, EventArgs e)
    {
      ViewCalculationFromRow(gridCalculations.CurrentRow);
    }
  }
}
