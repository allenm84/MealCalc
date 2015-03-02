using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.JanusControls
{
  public partial class CalculateNutritionalInfoDialog : BaseForm
  {
    static readonly int EntireRecipe;
    static readonly int CutIntoParts;
    static readonly int UseServingSize;

    static CalculateNutritionalInfoDialog()
    {
      EntireRecipe = BitVector32.CreateMask();
      CutIntoParts = BitVector32.CreateMask(EntireRecipe);
      UseServingSize = BitVector32.CreateMask(CutIntoParts);
    }

    private IEnumerable<IngredientRef> references;
    private IEnumerable<Ingredient> ingredients;

    private BitVector32 optionState = new BitVector32(0);
    private int lastState = -1;

    private NutritionalInfo currentNutritionalInfo;

    private decimal Parts 
    {
      get 
      {
        decimal parts = (decimal)numParts.Value;
        return Math.Max(parts, 0.01m);
      } 
    }

    public CalculateNutritionalInfoDialog()
    {
      InitializeComponent();
      ctrlRecipeAmount.ServingSizeVisible = false;
      numParts.Value = 0.01m;
      numParts.ValueChanged += numParts_ValueChanged;
    }

    public void Setup(IEnumerable<IngredientRef> references, IEnumerable<Ingredient> ingredients)
    {
      this.references = references;
      this.ingredients = ingredients;
    }

    private bool UpdateState()
    {
      optionState[EntireRecipe] = optEntireRecipe.Checked;
      optionState[CutIntoParts] = optCutIntoParts.Checked;
      optionState[UseServingSize] = optServingSize.Checked;

      int state = optionState.Data;
      bool retval = (state != lastState);

      lastState = state;
      return retval;
    }

    public Calculation CreateCalculation()
    {
      var name = txtName.Text;
      if (string.IsNullOrWhiteSpace(name))
      {
        name = ctrlViewNutritionalInfo.ServingSize;
      }

      var calc = Factory.NewCalculation(name);
      calc.Info = currentNutritionalInfo;
      return calc;
    }

    private void UpdateNutritionalDisplay(bool force = true)
    {
      numParts.Enabled = optCutIntoParts.Checked;
      ctrlShowForServingSize.Enabled = optServingSize.Checked;

      if (UpdateState() || force)
      {
        var info = Calculator.CalculateNutritionalInfo(references, ingredients);
        if (optCutIntoParts.Checked)
        {
          // the user wishes to cut it into parts. Therefore, the serving size
          // is the number of parts.
          var parts = Parts;
          info = Calculator.Divide(info, parts);
          info.ServingSize.Amount = parts;
          info.NoMeasurement = true;
        }
        else if (optServingSize.Checked)
        {
          try
          {
            // the user wishes to cut in into servings. So the serving size will be the requested
            // serving size
            var size = new Serving();
            ctrlShowForServingSize.Dehydrate(size);
            var original = size;
            size = Calculator.ToCups(size);

            decimal divisor = 0;
            if (size.Amount > 0)
            {
              divisor = info.ServingSize.Amount / size.Amount;
            }

            if (divisor != 0)
            {
              info = Calculator.Divide(info, divisor);
              info.ServingSize = original;
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show(this,
              string.Format("Unable to calculate because {0}. Please let me know.", ex.Message),
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
          }
        }
        else
        {
          // the user wants all of the information
          var all = new Serving();
          ctrlRecipeAmount.Dehydrate(all);
          info.ServingSize = all;
        }

        ctrlViewNutritionalInfo.Populate(info);
        ctrlViewNutritionalInfo.ServingSize = Accessor.GetServingSizeText(info);

        currentNutritionalInfo = info;
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateNutritionalDisplay();
    }

    private void option_CheckedChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay(false);
    }

    private void ctrlRecipeAmount_ServingChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }

    private void numParts_ValueChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }

    private void ctrlShowForServingSize_ServingChanged(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay();
    }
  }
}
