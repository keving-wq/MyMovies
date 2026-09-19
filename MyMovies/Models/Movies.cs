using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Movies
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string Genre { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, StringLength(100)]
        public string Director { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}