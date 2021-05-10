using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews.Models
{
    public abstract class EnumBindableCollectionView<T> : StackLayout where T : struct, Enum
    {
        private List<EnumModel<T>> EnumValues { get; }

        protected EnumBindableCollectionView()
        {
            EnumValues = EnumModel<T>.GetModelsForType();
            foreach (var enumValue in EnumValues)
            {
                enumValue.PropertyChanged += EnumValueOnPropertyChanged;
            }
            BindableLayout.SetItemsSource(this, EnumValues);
        }

        private void EnumValueOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!(sender is EnumModel<T> enumModel))
                return;
            if (e.PropertyName != nameof(EnumModel.IsChecked))
                return;

            if (enumModel.IsChecked != enumModel.ShouldBeChecked(SelectedItem))
            {
                // Has been changed from the UI side
                SelectedItem = GetSelectedEnumValue();
                UpdateCheckedRadioButton(SelectedItem);
            }
        }

        private T GetSelectedEnumValue()
        {
            var values = GetSelectedEnumModels();
            if (values.Any())
                return (T) Enum.Parse(typeof(T), string.Join(" ,", values.Select(v => v.Name)));
            else
                return default;
        }

        private IList<EnumModel<T>> GetSelectedEnumModels()
        {
            return EnumValues.Where(rb => rb.IsChecked).ToList();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            OnSelectedItemChanged(this, SelectedItem, SelectedItem);
        }

        private void UpdateCheckedRadioButton(T newValueT)
        {
            foreach (var enumValue in EnumValues)
            {
                enumValue.SetShouldBeChecked(newValueT);
            }
        }

        private void ClearCheckedRadioButton()
        {
            var selectedModels = GetSelectedEnumModels();
            foreach (var selectedModel in selectedModels)
            {
                selectedModel.IsChecked = false;
            }
        }

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem),
                                                                                                   typeof(T),
                                                                                                   typeof(EnumBindableRadioButtons<T>),
                                                                                                   default(T),
                                                                                                   propertyChanged: OnSelectedItemChanged,
                                                                                                   defaultBindingMode: BindingMode.TwoWay);

        public T SelectedItem
        {
            get => (T) GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value);
        }

        private static void OnSelectedItemChanged(Xamarin.Forms.BindableObject bindable, object oldvalue, object newvalue)
        {
            if (!(bindable is EnumBindableCollectionView<T> collectionView))
                return;

            if (newvalue is T newValueT)
            {
                collectionView.UpdateCheckedRadioButton(newValueT);
            }
            else
            {
                collectionView.ClearCheckedRadioButton();
            }
        }
    }
}