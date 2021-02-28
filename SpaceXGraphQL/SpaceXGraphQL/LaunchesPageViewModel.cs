using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using SpaceXGraphQL.Annotations;
using SpaceXGraphQL.SpaceX.gen;
using Xamarin.Forms;

namespace SpaceXGraphQL
{
    public class LaunchesPageViewModel : INotifyPropertyChanged
    {
        private readonly GraphQLHttpClient _client;
        private ObservableCollection<Types.Launch> _launches = new ObservableCollection<Types.Launch>();
        private bool _isLoading;
        private bool _isFetchingMore;
        private Command _loadMoreCommand;

        public LaunchesPageViewModel()
        {
            _client = new GraphQLHttpClient("https://api.spacex.land/graphql", new NewtonsoftJsonSerializer());
            Launches = new ObservableCollection<Types.Launch>();

            LoadMoreCommand = new Command(async () =>
            {
                if (_isFetchingMore)
                {
                    return;
                }

                try
                {
                    _isFetchingMore = true;
                    await GetLaunches();
                }
                finally
                {
                    _isFetchingMore = false;
                }
            });

            IsLoading = true;
            GetLaunches().ContinueWith((_, __) => IsLoading = false, null);
        }

        private async Task GetLaunches()
        {
            var launchesRequest = new GraphQLRequest
            {
                Query = @"query getLaunches($limit: Int, $offset: Int)
                                {
                                  launches(limit: $limit, offset: $offset) {
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
                    limit = 15,
                    offset = Launches.Count
                }
            };

            var response = await _client.SendQueryAsync<Types.Query>(launchesRequest);
            if (!(response.Errors ?? Array.Empty<GraphQLError>()).Any())
            {
                foreach (var launch in response.Data.launches)
                {
                    Launches.Add(launch);
                }
            }
        }

        public Command LoadMoreCommand
        {
            get => _loadMoreCommand;
            set
            {
                _loadMoreCommand = value;
                OnPropertyChanged();
            }
        }

        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Types.Launch> Launches
        {
            get => _launches;
            set
            {
                _launches = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}