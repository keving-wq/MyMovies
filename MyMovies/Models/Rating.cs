using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Required, StringLength(10)]
        public string Code { get; set; } = string.Empty;
    }
}