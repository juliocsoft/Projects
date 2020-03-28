namespace FR.Models
{
    public class Genre
    {
        public int IdGenre { get; private set; }

        public string Name { get; private set; }

        public Movie Movie { get; set; }
    }
}
