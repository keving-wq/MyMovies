using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Title
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Text { get; set; } = string.Empty;
    }
}