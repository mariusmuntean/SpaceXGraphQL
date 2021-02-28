using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpaceXGraphQL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LaunchPage : ContentPage
    {
        
        public LaunchPage(LaunchPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}