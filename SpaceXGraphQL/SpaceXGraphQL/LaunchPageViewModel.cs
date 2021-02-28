using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using SpaceXGraphQL.Annotations;
using SpaceXGraphQL.SpaceX.gen;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SpaceXGraphQL
{
    public class LaunchPageViewModel : INotifyPropertyChanged
    {
        private readonly string _launchId;
        private readonly GraphQLHttpClient _client;
        private Types.Launch _launch;
        private bool _isLoading;

        public LaunchPageViewModel(string launchId)
        {
            _launchId = launchId;
            _client = new GraphQLHttpClient("https://api.spacex.land/graphql", new NewtonsoftJsonSerializer());

            ArticleLinkTappedCommand = new Command(() => Launcher.OpenAsync(Launch?.links?.article_link ?? "https://www.spaceX.com"));
            ImageTappedCommand = new Command((o) => Share.RequestAsync(new ShareTextRequest()
            {
                Uri = o?.ToString() ?? "https://www.spacex.com",
                Title = "Share"
            }));
            
            GetLaunch();
        }

        private async Task GetLaunch()
        {
            Launch = null;
            var launchRequest = new GraphQLRequest
            {
                Query = @"query getLaunch($id: ID!) {
                                      launch(id: $id) {
                                        id
                                        is_tentative
                                        upcoming
                                        mission_name
                                        links {
                                          article_link
                                          video_link
                                          flickr_images
                                          mission_patch
                                        }
                                        launch_date_utc
                                        details
                                      }
                                    }",
                Variables = new
                {
                    id = _launchId,
                }
            };

            var response = await _client.SendQueryAsync<Types.Query>(launchRequest);
            if (!(response.Errors ?? Array.Empty<GraphQLError>()).Any())
            {
                Launch = response.Data.launch;
            }
        }

        public Types.Launch Launch
        {
            get => _launch;
            set
            {
                _launch = value;
                OnPropertyChanged();
            }
        }

        public Command ArticleLinkTappedCommand { get; set; }
        public Command ImageTappedCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}