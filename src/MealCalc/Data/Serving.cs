using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [Serializable]
  [DataContract(Name = "Serving", Namespace = SaveFile.Namespace)]
  public class Serving : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public decimal Amount { get; set; }
    [DataMember]
    public Measurement Type { get; set; }

    public override string ToString()
    {
      return string.Format("{0} {1}{2}", Amount, Type, Amount == 1m ? "" : "s");
    }
  }
}
