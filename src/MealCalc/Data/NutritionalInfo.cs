using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [Serializable]
  [DataContract(Name = "NutritionalInfo", Namespace = SaveFile.Namespace)]
  public class NutritionalInfo : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public decimal Calories { get; set; }
    [DataMember]
    public decimal Carbs { get; set; }
    [DataMember]
    public decimal Fat { get; set; }
    [DataMember]
    public decimal Protein { get; set; }
    [DataMember]
    public decimal Sodium { get; set; }
    [DataMember]
    public decimal Sugar { get; set; }
    [DataMember]
    public Serving ServingSize { get; set; }
    [DataMember]
    public bool NoMeasurement { get; set; }
  }
}
