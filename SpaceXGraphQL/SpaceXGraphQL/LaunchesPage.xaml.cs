using System.Linq;
using SpaceXGraphQL.SpaceX.gen;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpaceXGraphQL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LaunchesPage : ContentPage
    {
        public LaunchesPage()
        {
            InitializeComponent();
            BindingContext = new LaunchesPageViewModel();
        }

        private async void OnLaunchSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any() && e.CurrentSelection.First() is Types.Launch launch)
            {
                await Navigation.PushAsync(new LaunchPage(new LaunchPageViewModel(launch.id)));

                if (sender is CollectionView cw)
                {
                    cw.SelectedItem = null;
                }
            }
        }
    }
}