using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace MealCalc.DevX
{
  public static class Extensions
  {
    public static void SetIsEnabled(this Bar bar, bool enabled)
    {
      ((DockedBarControl)(((IDockableObject)bar).BarControl)).Enabled = enabled;
    }

    public static bool GetIsVisible(this BaseLayoutItem item)
    {
      return item.Visibility != LayoutVisibility.Never;
    }

    public static void SetIsVisible(this BaseLayoutItem item, bool visible)
    {
      item.Visibility = visible
        ? LayoutVisibility.Always
        : LayoutVisibility.Never;
    }

    public static void FillWithEnum<T>(this LookUpEdit lookUp, Func<T, string> getText = null)
    {
      lookUp.Properties.FillWithEnum(getText);
    }

    public static void FillWithEnum<T>(this RepositoryItemLookUpEdit lookUp, Func<T, string> getText = null)
    {
      if (getText == null)
      {
        getText = (x) => x.ToString();
      }

      var values = (T[])Enum.GetValues(typeof(T));
      lookUp.DataSource = values
        .Select(v => new { Value = v, Display = getText(v) })
        .ToArray();
      lookUp.DisplayMember = "Display";
      lookUp.ValueMember = "Value";
      lookUp.ShowHeader = false;
      lookUp.Columns.Add(new LookUpColumnInfo("Display")
      {
        Visible = true,
        SortOrder = ColumnSortOrder.Ascending
      });
    }

    public static TAttribute GetAttribute<TAttribute>(this Enum value)
      where TAttribute : Attribute
    {
      var type = value.GetType();
      var info = type.GetMember(value.ToString()).FirstOrDefault();
      if (info == null)
        return null;
      return info.GetCustomAttribute<TAttribute>();
    }
  }
}
