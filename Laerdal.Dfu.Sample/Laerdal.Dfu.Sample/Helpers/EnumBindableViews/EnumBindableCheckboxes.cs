using Laerdal.Dfu.Sample.Helpers.EnumBindableViews.DataTemplates;
using Laerdal.Dfu.Sample.Helpers.EnumBindableViews.Models;

using System;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews
{
    public class EnumBindableCheckboxes<T> : EnumBindableCollectionView<T> where T : struct, Enum
    {

        public EnumBindableCheckboxes()
        {
            BindableLayout.SetItemTemplate(this, new DataTemplate(typeof(EnumCheckboxDataTemplate)));
        }


    }
}