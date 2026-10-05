using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string Synopsis { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Genre { get; set; } = string.Empty;

        [Required]
        [StringLength(10)]
        public string Rating { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Run Time")]
        public string RunTime { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
    }
}