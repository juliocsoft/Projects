using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FR.Models
{
    public class Movie
    {
        [JsonProperty("idmovie")]
        public int IdMovie { get; private set; }

        [JsonProperty("budget")]
        public decimal Budget { get; private set; }

        [JsonProperty("originaltitle")]
        public string OriginalTitle { get; private set; }

        [JsonProperty("popularity")]
        public decimal Popularity { get; private set; }

        [JsonProperty("posterpath")]
        public string PosterPath { get; private set; }

        [JsonProperty("releasedate")]
        public DateTime ReleaseDate { get; private set; }

        [JsonProperty("voteaverage")]
        public double VoteAverage { get; private set; }

        [JsonProperty("votecount")]
        public double VoteCount { get; private set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("overviews")]
        public List<Overview> Overviews { get; set; }
    }
}

