using FR.Interfaces;
using FR.Models;
using MvvmHelpers;
using System;
using System.Threading.Tasks;

namespace FR.ViewModels
{
    public class MovieViewModel
    {
        private readonly IApi _api;
        private bool _alreadyInitialized = false;

        public ObservableRangeCollection<Movie> Movies { get; private set; }

        public MovieViewModel(IApi api)
        {
            _api = api;
            Movies = new ObservableRangeCollection<Movie>();
        }

        public async Task InitializeAsync()
        {
            if (_alreadyInitialized)
                return;

            await GetMovies();
            _alreadyInitialized = true;
        }

        public async Task GetMovies()
        {
            try
            {
                var movies = await _api.Get();
                Movies.AddRange(movies);
            }
            catch (Exception exception)
            {
                System.Diagnostics.Debug.WriteLine(exception.Message);
            }
        }
    }
}
