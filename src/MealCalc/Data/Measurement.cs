using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [DataContract(Name = "Measurement", Namespace = SaveFile.Namespace)]
  public enum Measurement : int
  {
    [Description("Tsp")]
    [EnumMember]
    TeaSpoon,
    [Description("Tbsp")]
    [EnumMember]
    TableSpoon,
    [EnumMember]
    Cup,
    [Description("Oz")]
    [EnumMember]
    Ounce,
  }
}
