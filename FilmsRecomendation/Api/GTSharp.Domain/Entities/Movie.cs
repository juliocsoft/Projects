using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTSharp.Domain.Entities
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdMovie { get; private set; }
        public decimal Budget { get; private set; }
        [MaxLength(400)]
        public string OriginalTitle { get; private set; }
        public decimal Popularity { get; private set; }
        [MaxLength(100)]
        public string PosterPath { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public double VoteAverage { get; private set; }
        public double VoteCount { get; private set; }
        public List<Genre> Genres { get; set; }
        public List<Overview> Overviews { get; set; }

        public Movie(int idMovie, decimal budget, string originalTitle, decimal popularity, string posterPath, DateTime releaseDate, double voteAverage, double voteCount)
        {
            IdMovie = idMovie;
            Budget = budget;
            OriginalTitle = originalTitle;
            Popularity = popularity;
            PosterPath = posterPath;
            ReleaseDate = releaseDate;
            VoteAverage = voteAverage;
            VoteCount = voteCount;
            Genres = new List<Genre>();
            Overviews = new List<Overview>();
        }
    }
}