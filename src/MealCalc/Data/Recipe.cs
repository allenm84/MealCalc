using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [Serializable]
  [DataContract(Name = "Recipe", Namespace = SaveFile.Namespace)]
  public class Recipe : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public bool Favorite { get; set; }
    [DataMember]
    public List<IngredientRef> Ingredients { get; set; }
    [DataMember]
    public List<Calculation> Calculations { get; set; }

    [OnDeserialized]
    private void OnDeserialized(StreamingContext c)
    {
      if (Ingredients == null)
        Ingredients = new List<IngredientRef>();
      if (Calculations == null)
        Calculations = new List<Calculation>();
    }
  }
}
