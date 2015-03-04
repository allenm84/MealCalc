using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Specialized;

namespace MealCalc.DevX
{
  public partial class EditRecipeDialog : BaseForm
  {
    static readonly int EntireRecipe;
    static readonly int CutIntoParts;
    static readonly int UseServingSize;

    static EditRecipeDialog()
    {
      EntireRecipe = BitVector32.CreateMask();
      CutIntoParts = BitVector32.CreateMask(EntireRecipe);
      UseServingSize = BitVector32.CreateMask(CutIntoParts);
    }

    private readonly Recipe recipe;
    private BitVector32 optionState = new BitVector32(0);
    private int lastState = -1;

    public EditRecipeDialog(Recipe recipe)
    {
      this.recipe = recipe;
      InitializeComponent();

      txtName.DataBindings.Add("Text", recipe, "Name");
      chkFavorite.DataBindings.Add("Checked", recipe, "Favorite");
      lstIngredients.SetupEditor(recipe.Ingredients);

      WireEvents();
    }

    private void WireEvents()
    {
      Load += updateNutritionalDisplayRequest_Force;

      lstIngredients.ListChanged += updateNutritionalDisplayRequest_Force;
      numParts.ValueChanged += updateNutritionalDisplayRequest_Force;
      ctrlEditServing.ServingChanged += updateNutritionalDisplayRequest_Force;

      optCutIntoParts.CheckedChanged += updateNutritionalDisplayRequest_NoForce;
      optEntireRecipe.CheckedChanged += updateNutritionalDisplayRequest_NoForce;
      optServingSize.CheckedChanged += updateNutritionalDisplayRequest_NoForce;
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

    private void UpdateNutritionalDisplay(bool force = true)
    {
      numParts.Enabled = optCutIntoParts.Checked;
      ctrlEditServing.Enabled = optServingSize.Checked;

      if (UpdateState() || force)
      {
        var info = lstIngredients.CalculateNutritionInfo();
        if (optCutIntoParts.Checked)
        {
          info = Calculator.Divide(info, numParts.Value);
        }
        else if (optServingSize.Checked)
        {
          try
          {
            var size = Factory.NewServing();
            ctrlEditServing.Dehydrate(size);
            size = Calculator.ToCups(size);

            decimal divisor = 0;
            if (size.Amount > 0)
            {
              divisor = info.ServingSize.Amount / size.Amount;
            }

            if (divisor != 0)
            {
              info = Calculator.Divide(info, divisor);
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
        ctrlViewNutritionalInfo.Populate(info);
      }
    }

    private void updateNutritionalDisplayRequest_Force(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay(true);
    }

    private void updateNutritionalDisplayRequest_NoForce(object sender, EventArgs e)
    {
      UpdateNutritionalDisplay(false);
    }
  }
}