using Laerdal.Dfu.Sample.Converters.Base;

namespace Laerdal.Dfu.Sample.Converters
{
    public class InvertedBooleanConverter : BaseConverter<bool, bool>
    {
        protected override bool ConvertFrom(bool value, object parameter)
        {
            return !value;
        }

        protected override bool ConvertBackTo(bool value, object parameter)
        {
            return !value;
        }
    }
}