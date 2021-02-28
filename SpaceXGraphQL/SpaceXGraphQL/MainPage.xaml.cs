using System;
using Xamarin.Forms;

namespace SpaceXGraphQL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LaunchesPage());
        }
    }
}