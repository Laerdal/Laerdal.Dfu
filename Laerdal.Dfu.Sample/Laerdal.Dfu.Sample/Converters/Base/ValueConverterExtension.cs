using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Converters.Base
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class ValueConverterExtension : IMarkupExtension<IValueConverter>
    {
        private static Dictionary<string, ImageSource> _dictionary;

        protected ImageSource GetImageSource(string resourceName)
        {
            if (_dictionary == null)
                _dictionary = new Dictionary<string, ImageSource>();
            if (!_dictionary.ContainsKey(resourceName))
            {
                _dictionary.Add(resourceName, ImageSource.FromStream(() => GetType().Assembly.GetManifestResourceStream(resourceName)));
            }

            return _dictionary[resourceName];
        }

        public IValueConverter ProvideValue(IServiceProvider serviceProvider) => (IValueConverter) this;

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ((IMarkupExtension<IValueConverter>) this).ProvideValue(serviceProvider);
    }
}