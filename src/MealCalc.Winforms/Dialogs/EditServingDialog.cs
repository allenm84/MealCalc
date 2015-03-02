using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCalc.Winforms
{
  public partial class EditServingDialog : BaseForm
  {
    public EditServingDialog()
    {
      InitializeComponent();
    }

    public void Hydrate(Serving serving)
    {
      editServingControl1.Hydrate(serving);
    }

    public void Dehydrate(Serving serving)
    {
      editServingControl1.Dehydrate(serving);
    }
  }
}
