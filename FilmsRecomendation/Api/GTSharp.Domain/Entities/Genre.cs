using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTSharp.Domain.Entities
{
    public class Genre
    {
        [Key]
        public int IdGenre { get; private set; }

        [MaxLength(400)]
        public string Name { get; private set; }
         
        public Movie Movie { get; set; }
    }
}