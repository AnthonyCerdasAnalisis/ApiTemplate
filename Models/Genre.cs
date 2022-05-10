using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiTemplate.Models
{
    public class Genre
    {
        [Key]
        public int IdGenre { get; set; }

        [Required]
        public string? Type { get; set; }

    }
}