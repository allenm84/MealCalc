using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MealCalc
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public sealed class SaveFile : IExtensibleDataObject
  {
    #region IExtensibleDataObject Members

    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }

    #endregion

    [DataMember]
    public List<Category> Categories { get; set; }
    [DataMember]
    public List<Ingredient> Ingredients { get; set; }
    [DataMember]
    public List<Recipe> Recipes { get; set; }

    public SaveFile()
    {
      Categories = new List<Category>();
      Ingredients = new List<Ingredient>();
      Recipes = new List<Recipe>();
    }

    public const string Namespace = @"http://www.mapa-apps/paige/mealcalc";

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    static extern int GetModuleFileName(HandleRef hModule, StringBuilder buffer, int length);

    static SaveFile sInstance;
    static string sFilepath;
    static DataContractSerializer sDcs;

    static SaveFile()
    {
      sDcs = new DataContractSerializer(typeof(SaveFile));
      var nullHandleRef = new HandleRef(null, IntPtr.Zero);
      var stringBuilder = new StringBuilder(260);
			GetModuleFileName(nullHandleRef, stringBuilder, stringBuilder.Capacity);
			var startupPath = Path.GetDirectoryName(stringBuilder.ToString());
      sFilepath = Path.Combine(startupPath, "saved.xml");
    }

    public static SaveFile Instance { get { return sInstance; } }

    public static void Load()
    {
      if (File.Exists(sFilepath))
      {
        using (var stream = File.OpenRead(sFilepath))
        {
          try
          {
            sInstance = sDcs.ReadObject(stream) as SaveFile;
            return;
          }
          catch { }
        }
      }
      sInstance = new SaveFile();
    }

    public static void Save()
    {
      using (var stream = File.Create(sFilepath))
      {
        sDcs.WriteObject(stream, sInstance);
      }
    }
  }
}
