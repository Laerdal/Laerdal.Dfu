using System;
using System.Globalization;

namespace Laerdal.Dfu.Sample.Converters.Base
{
    /// <inheritdoc />
    /// <summary>
    /// Pre-setting the type of the output of the converter
    /// </summary>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverter<TTo> : BaseConverterOneWay<TTo>
    {
        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TTo valueFrom))
            {
                throw new ArgumentException($"{nameof(value)} needs to be of type {typeof(TTo)}");
            }
            else
            {
                return ConvertBackTo(valueFrom, parameter);
            }
        }

        protected abstract object ConvertBackTo(TTo value, object parameter);
    }


    /// <inheritdoc />
    /// <summary>
    /// Pre-setting the type of the input and output of the converter
    /// </summary>
    /// <typeparam name="TFrom">input type</typeparam>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverter<TFrom, TTo> : BaseConverterOneWay<TFrom, TTo>
    {
        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TTo valueFrom))
            {
                throw new ArgumentException($"{nameof(value)} needs to be of type {typeof(TTo)}");
            }
            else if (!targetType.IsAssignableFrom(typeof(TFrom)))
            {
                throw new ArgumentException($"{nameof(targetType)} needs to be typeof {typeof(TFrom)}");
            }
            else
            {
                return ConvertBackTo(valueFrom, parameter);
            }
        }

        protected abstract TFrom ConvertBackTo(TTo value, object parameter);
    }

    /// <inheritdoc />
    /// <summary>
    /// Pre-setting the type of the input, parameter and output of the converter
    /// </summary>
    /// <typeparam name="TFrom">input type</typeparam>
    /// <typeparam name="TParameter">parameter type</typeparam>
    /// <typeparam name="TTo">output type</typeparam>
    public abstract class BaseConverter<TFrom, TParameter, TTo> : BaseConverterOneWay<TFrom, TParameter, TTo>
    {
        public sealed override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TTo valueFrom))
            {
                throw new ArgumentException($"{nameof(value)} needs to be of type {typeof(TTo)}");
            }
            else if (!targetType.IsAssignableFrom(typeof(TFrom)))
            {
                throw new ArgumentException($"{nameof(targetType)} needs to be typeof {typeof(TFrom)}");
            }
            else if (!(parameter is TParameter param))
            {
                throw new ArgumentException($"{nameof(parameter)} needs to be typeof {typeof(TParameter)}");
            }
            else
            {
                return ConvertBackTo(valueFrom, param);
            }
        }

        protected abstract TFrom ConvertBackTo(TTo value, TParameter parameter);
    }
}