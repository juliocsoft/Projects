using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GTSharp.Domain.Entities
{
    public class Overview
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        public int IdOverview { get; private set; }
        [MaxLength(400)]
        public string Description { get; private set; }
        public Movie Movie { get; set; }
    }
}