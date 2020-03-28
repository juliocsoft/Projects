using FR.Interfaces;
using FR.Models;
using FR.Services;
using FR.ViewModels;
using Xamarin.Forms;

namespace FR
{
    public partial class MainPage : ContentPage
    {
        private readonly IApi _api;
        private MovieViewModel _movieViewModel;

        public AppPage Page { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            _api = ApiService.Instance;
            _movieViewModel = new MovieViewModel(_api);
            var movies =_movieViewModel.GetMovies();
            int a = 1;

            //Page = GetPage();
        }

        private AppPage GetPage()
        {
            return new AppPage { Name = "Movie", Icon = "menu_live", Type = AppPageType.Live, ViewModel = _movieViewModel };
        }

    }
}
