using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTSharp.Domain.Entities
{
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdGenre { get; private set; }
        [MaxLength(400)]
        public string Name { get; private set; }
        public Movie Movie { get; set; }

        public Genre(int idGenre, string name)
        {
            IdGenre = idGenre;
            Name = name;
        }
    }
}