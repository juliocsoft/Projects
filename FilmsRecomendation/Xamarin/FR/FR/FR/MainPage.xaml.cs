using FR.Interfaces;
using FR.Models;
using FR.Services;
using FR.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

            
            //_api = ApiService.Instance;
            //_movieViewModel = new MovieViewModel(_api);
            //var movies =_movieViewModel.GetMovies();

            //Page = GetPage();
        }

        public void Click()
        {
        }
        async void Click(object sender, EventArgs args)
        {
            using (var client = new HttpClient())
            {
                try
                {

                // envia a requisição GET
                var uri = "https://localhost:5001/v1/movies";
                var result = await client.GetStringAsync(uri);
                // processa a resposta
                var posts = JsonConvert.DeserializeObject<Movie>(result);
                // gera a saida
                var post = posts.OriginalTitle;
                label.Text = "Primeiro get:\n\n" + post;
                }
                catch (Exception ex)
                {
                    label.Text = ex.Message;
                }
            }
            await label.RelRotateTo(360, 1000);
        }

        private AppPage GetPage()
        {
            return new AppPage { Name = "Movie", Icon = "menu_live", Type = AppPageType.Live, ViewModel = _movieViewModel };
        }

    }
}
