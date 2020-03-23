using System;

namespace GTSharp.Domain.Entities
{
    public class Genre
    {
        public int Id { get; private set; }
        public int IdGenre { get; private set; }
        public string Name { get; private set; }
        public Genre(int idGenre, string name)
        {
            IdGenre = idGenre;
            Name = name;
        }
    }
}