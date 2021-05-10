using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Helpers.EnumBindableViews.DataTemplates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnumRadioButtonDataTemplate
    {
        public EnumRadioButtonDataTemplate()
        {
            InitializeComponent();


            // The class, property, or method you are attempting to use ('RadioButton') is part of RadioButton;
            // to use it, you must opt-in by calling Forms.SetFlags("RadioButton_Experimental") before calling Forms.Init()
        }

        private void TapGestureRecognizer_OnTapped(object sender, System.EventArgs e)
        {
            if (sender is EnumRadioButtonDataTemplate template)
                template.MainRadioButton.IsChecked = !template.MainRadioButton.IsChecked;
        }
    }
}