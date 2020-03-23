using System;
using System.Collections.Generic;
using System.Linq;

namespace GTSharp.Domain.Entities
{
    public class Movie
    {
        public int Id { get; private set; }
        public int IdMovie { get; private set; }
        public decimal Budget { get; private set; }
        public string OriginalTitle { get; private set; }
        public string Overview { get; private set; }
        public decimal Popularity { get; private set; }
        public string PosterPath { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public double VoteAverage { get; private set; }
        public double VoteCount { get; private set; }
        public List<Genre> Genres { get; set; }

        public Movie(int idMovie, decimal budget, string originalTitle, string overview, decimal popularity, string posterPath, DateTime releaseDate, double voteAverage, double voteCount)
        {
            IdMovie = idMovie;
            Budget = budget;
            OriginalTitle = originalTitle;
            Overview = overview;
            Popularity = popularity;
            PosterPath = posterPath;
            ReleaseDate = releaseDate;
            VoteAverage = voteAverage;
            VoteCount = voteCount;
            Genres = new List<Genre>();
        }
    }
}