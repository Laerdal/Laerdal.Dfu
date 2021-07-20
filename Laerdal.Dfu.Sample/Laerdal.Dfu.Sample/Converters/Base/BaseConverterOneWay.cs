using System;
using System.Globalization;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.Converters.Base
{
    /// <inheritdoc cref="Xamarin.Forms.IValueConverter" />
    /// <summary>
    /// Pre-setting the type of the output of the converter
    /// </summary>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverterOneWay<TTo> : ValueConverterExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!typeof(TTo).IsAssignableFrom(targetType))
            {
                throw new ArgumentException($"{nameof(targetType)} needs to be typeof {typeof(TTo)}");
            }
            else
            {
                return ConvertFrom(value, parameter);
            }
        }

        protected abstract TTo ConvertFrom(object value, object parameter);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new
                NotImplementedException("Impossible to revert to original value. Consider setting BindingMode to OneWay.");
    }

    /// <inheritdoc cref="Xamarin.Forms.IValueConverter" />
    /// <summary>
    /// Pre-setting the type of the input and output of the converter
    /// </summary>
    /// <typeparam name="TFrom">input type</typeparam>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverterOneWay<TFrom, TTo> : ValueConverterExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TFrom valueFrom))
            {
                throw new ArgumentException($"{nameof(value)} needs to be of type {typeof(TFrom)}");
            }
            else if (!typeof(TTo).IsAssignableFrom(targetType))
            {
                throw new ArgumentException($"{nameof(targetType)} needs to be typeof {typeof(TTo)}");
            }
            else
            {
                return ConvertFrom(valueFrom, parameter);
            }
        }

        protected abstract TTo ConvertFrom(TFrom value, object parameter);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new
                NotImplementedException("Impossible to revert to original value. Consider setting BindingMode to OneWay.");
    }

    /// <inheritdoc cref="Xamarin.Forms.IValueConverter" />
    /// <summary>
    /// Pre-setting the type of the input, parameter and output of the converter
    /// </summary>
    /// <typeparam name="TFrom">input type</typeparam>
    /// <typeparam name="TParameter">parameter type</typeparam>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverterOneWay<TFrom, TParameter, TTo> : ValueConverterExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TFrom valueFrom))
            {
                throw new ArgumentException($"{nameof(value)} needs to be of type {typeof(TFrom)}");
            }
            else if (!typeof(TTo).IsAssignableFrom(targetType))
            {
                throw new ArgumentException($"{nameof(targetType)} needs to be typeof {typeof(TTo)}");
            }
            else if (!(parameter is TParameter param))
            {
                throw new ArgumentException($"{nameof(parameter)} needs to be typeof {typeof(TParameter)}");
            }
            else
            {
                return ConvertFrom(valueFrom, param);
            }
        }

        protected abstract TTo ConvertFrom(TFrom value, TParameter parameter);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new
                NotImplementedException("Impossible to revert to original value. Consider setting BindingMode to OneWay.");
    }
}