using System;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews
{
    public class EnumBindablePicker<T> : Picker where T : struct
    {
        public EnumBindablePicker()
        {
            SelectedIndexChanged += OnSelectedIndexChanged;

            //Fill the Items from the enum
            foreach (var value in Enum.GetValues(typeof(T)))
            {
                Items.Add(value.ToString());
            }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            //if the current value is the same as the default,
            //it wouldn't recognize the change. Force OnSelectedItemChanged to handle this case.
            OnSelectedItemChanged(this, SelectedItem, SelectedItem);
        }

        public new static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem),
                                                                                                   typeof(T),
                                                                                                   typeof(EnumBindablePicker<T>),
                                                                                                   default(T),
                                                                                                   propertyChanged: OnSelectedItemChanged,
                                                                                                   defaultBindingMode: BindingMode.TwoWay);

        public new T SelectedItem
        {
            get => (T) GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        private void OnSelectedIndexChanged(object sender, System.EventArgs eventArgs)
        {
            if (SelectedIndex < 0 || SelectedIndex > Items.Count - 1)
            {
                SelectedItem = default;
            }
            else if (!Enum.TryParse(Items[SelectedIndex], out T match))
            {
                SelectedItem = (T) Enum.Parse(typeof(T), match.ToString());
            }
        }

        private static void OnSelectedItemChanged(Xamarin.Forms.BindableObject bindable, object oldvalue, object newvalue)
        {
            if (newvalue is T newTValue)
                if (bindable is EnumBindablePicker<T> bindablePicker)
                    bindablePicker.SelectedIndex = bindablePicker.Items.IndexOf(newTValue.ToString());
        }
    }
}