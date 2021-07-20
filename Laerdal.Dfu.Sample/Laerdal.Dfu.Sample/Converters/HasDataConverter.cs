using Laerdal.Dfu.Sample.Converters.Base;

using System.Collections;
using System.Data.SqlTypes;

namespace Laerdal.Dfu.Sample.Converters
{
    public class HasDataConverter : BaseConverterOneWay<bool>
    {
        protected override bool ConvertFrom(object value, object parameter)
        {
            if (value == null)
            {
                return false;
            }

            if (value is INullable nullable)
            {
                return !nullable.IsNull;
            }
            
            if (value is string s)
            {
                return !string.IsNullOrWhiteSpace(s);
            }

            if (value is IList list)
            {
                return list.Count > 0;
            }

            return true;
        }
    }
}