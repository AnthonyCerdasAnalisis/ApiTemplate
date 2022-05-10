using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiTemplate.Models
{
    public class Movie
    {
        [Key]
        public int IdMovie { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public Genre? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string? Director { get; set; }

    }
}