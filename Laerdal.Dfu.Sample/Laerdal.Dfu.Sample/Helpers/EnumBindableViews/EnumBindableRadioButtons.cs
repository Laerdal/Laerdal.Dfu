using Laerdal.Dfu.Sample.Helpers.EnumBindableViews.DataTemplates;
using Laerdal.Dfu.Sample.Helpers.EnumBindableViews.Models;

using System;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews
{
    public class EnumBindableRadioButtons<T> : EnumBindableCollectionView<T> where T : struct, Enum
    {

        public EnumBindableRadioButtons()
        {
            BindableLayout.SetItemTemplate(this, new DataTemplate(typeof(EnumRadioButtonDataTemplate)));
        }


    }
}