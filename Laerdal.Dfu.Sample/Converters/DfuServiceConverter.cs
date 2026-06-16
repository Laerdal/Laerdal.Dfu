using System.Globalization;

namespace Laerdal.Dfu.Sample.Converters;

// Returns true if the IEnumerable<Guid> contains either Nordic DFU service UUID.
public class DfuServiceConverter : IValueConverter
{
    private static readonly Guid LegacyDfu = new("00001530-1212-EFDE-1523-785FEABCD123");
    private static readonly Guid SecureDfu = new("0000FE59-0000-1000-8000-00805F9B34FB");

    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is IEnumerable<Guid> guids)
            return guids.Any(g => g == LegacyDfu || g == SecureDfu);
        return false;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotImplementedException();
}
