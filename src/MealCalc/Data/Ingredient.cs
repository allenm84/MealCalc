﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [Serializable]
  [DataContract(Name = "Ingredient", Namespace = SaveFile.Namespace)]
  public class Ingredient : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string CategoryID { get; set; }
    [DataMember]
    public NutritionalInfo Info { get; set; }
  }
}
