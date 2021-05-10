using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews.DataTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnumCheckboxDataTemplate
    {
        public EnumCheckboxDataTemplate()
        {
            InitializeComponent();
        }


        private void TapGestureRecognizer_OnTapped(object sender, System.EventArgs e)
        {
            if (sender is EnumCheckboxDataTemplate template)
                template.MainCheckBox.IsChecked = !template.MainCheckBox.IsChecked;
        }
    }
}