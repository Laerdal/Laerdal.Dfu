using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews.Models
{
    public class EnumModel<T> : EnumModel where T : struct, Enum
    {
        public T EnumValue { get; }

        private EnumModel(T enumValue)
        {
            EnumValue = enumValue;
            Name = enumValue.ToString();
            Description = GetDescription(enumValue);
            GroupName = typeof(T).Name;
        }

        private static string GetDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
                return null;
            var attribute = (DescriptionAttribute) fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute?.Description;
        }

        public bool ShouldBeChecked(T enumValue)
        {
            var isFlags = typeof(T).GetCustomAttributes<FlagsAttribute>().Any();

            if (isFlags)
            {
                var lValue = System.Convert.ToInt64(enumValue);
                var lFlag = System.Convert.ToInt64(EnumValue);
                return (lFlag & lValue) == lFlag;
            }
            else
            {
                return Equals(EnumValue, enumValue);
            }
        }

        public void SetShouldBeChecked(T enumValue)
        {
            if (IsChecked != ShouldBeChecked(enumValue))
                IsChecked = ShouldBeChecked(enumValue);
        }

        public static List<EnumModel<T>> GetModelsForType()
        {
            var output = new List<EnumModel<T>>();

            //Fill the Items from the enum
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                output.Add(new EnumModel<T>((T) value));
            }

            return output;
        }
    }

    public abstract class EnumModel : BindableObject, IEquatable<EnumModel>
    {
        protected EnumModel()
        {
            IsUsingDescriptionIfAvailable = true;
        }

        public string Name
        {
            get => GetValue<string>();
            protected set => SetValue(value);
        }

        public string Description
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string GroupName
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public bool IsChecked
        {
            get => GetValue<bool>();
            set => SetValue(value);
            // set
            // {
            //     var oldValue = GetValue<bool>();
            //     if (oldValue != value)
            //     {
            //         Logger.Trace($"{GroupName}.{Name} : {oldValue} => {value}");
            //         SetValue(value);
            //     }
            // }
        }

        public bool IsUsingDescriptionIfAvailable
        {
            get => GetValue<bool>();
            set => SetValue(value);
        }

        public override string ToString()
        {
            if (!String.IsNullOrWhiteSpace(Description) && IsUsingDescriptionIfAvailable)
                return Description;
            else
                return Name;
        }

        public bool Equals(EnumModel other)
        {
            return Name == other?.Name;
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj) || obj is EnumModel other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public static bool operator ==(EnumModel left, EnumModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EnumModel left, EnumModel right)
        {
            return !Equals(left, right);
        }
    }
}