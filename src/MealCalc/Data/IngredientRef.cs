using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [Serializable]
  [DataContract(Name = "IngredientRef", Namespace = SaveFile.Namespace)]
  public class IngredientRef : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public string IngredientID { get; set; }
    [DataMember]
    public Serving Serving { get; set; }
  }
}
