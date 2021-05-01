using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Laerdal.Dfu.Sample.Helpers
{
    public abstract class BindableObject : INotifyPropertyChanged
    {
        private readonly ConcurrentDictionary<string, object> _values = new ConcurrentDictionary<string, object>();

        private void Store<T>(T value, string propertyName)
        {
            _values[propertyName] = value;
        }

        private bool HasValue(string propertyName)
        {
            return _values.ContainsKey(propertyName);
        }

        private T Retrieve<T>(string propertyName, T defaultValue = default)
        {
            if (_values.TryGetValue(propertyName, out var value))
            {
                return (T) value;
            }

            value = defaultValue;
            _values.TryAdd(propertyName, value);

            return (T) value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string GetPropertyName(LambdaExpression expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null)
            {
                throw new InvalidOperationException();
            }

            return memberExpression.Member.Name;
        }

        /// <summary>
        ///     Sets the value of a property.
        /// </summary>
        /// <param name="storage">Reference variable to store it in.</param>
        /// <param name="value">The property value.</param>
        /// <param name="propertyName">Name of the property</param>
        /// <typeparam name="T">The type of the property value.</typeparam>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            Store(value, propertyName);
            RaisePropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        ///     Sets the value of a property.
        /// </summary>
        /// <typeparam name="T">The type of the property value.</typeparam>
        /// <param name="propertySelector">Expression tree contains the property definition.</param>
        /// <param name="value">The property value.</param>
        protected bool SetValue<T>(Expression<Func<T>> propertySelector, T value)
        {
            var propertyName = GetPropertyName(propertySelector);

            return SetValue(propertyName, value);
        }

        /// <summary>
        ///     Sets the value of a property.
        /// </summary>
        /// <param name="value">The property value.</param>
        /// <param name="propertyName">The name of the property.</param>
        /// <typeparam name="T">The type of the property value.</typeparam>
        protected bool SetValue<T>(T value, [CallerMemberName] string propertyName = null)
        {
            return SetValue(propertyName, value);
        }

        /// <summary>
        ///     Sets the value of a property.
        /// </summary>
        /// <typeparam name="T">The type of the property value.</typeparam>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="value">The property value.</param>
        protected bool SetValue<T>(string propertyName, T value)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                throw new ArgumentException("Invalid property name", propertyName);
            }

            if (!HasValue(propertyName) || !Equals(Retrieve<T>(propertyName), value))
            {
                Store(value, propertyName);
                RaisePropertyChanged(propertyName);
                return true;
            }

            return false;
        }

        /// <summary>
        ///     Gets the value of a property.
        /// </summary>
        /// <typeparam name="T">The type of the property value.</typeparam>
        /// <param name="propertySelector">Expression tree contains the property definition.</param>
        /// <returns>The value of the property or default value if not exist.</returns>
        protected T GetValue<T>(Expression<Func<T>> propertySelector)
        {
            var propertyName = GetPropertyName(propertySelector);

            return GetValue<T>(propertyName: propertyName);
        }

        /// <summary>
        ///     Gets the value of a property.
        /// </summary>
        /// <typeparam name="T">The type of the property value.</typeparam>
        /// <param name="propertyName">The name of the property.</param>
        /// <param name="defaultValue"></param>
        /// <returns>The value of the property or default value if not exist.</returns>
        protected T GetValue<T>(T defaultValue = default, [CallerMemberName] string propertyName = null)
        {
            return Retrieve(propertyName, defaultValue);
        }

        /// <summary>
        ///     Raises the PropertyChanged event for the given property
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}