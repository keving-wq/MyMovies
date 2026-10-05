using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class Synopsis
    {
        public int Id { get; set; }

        [Required, StringLength(1000)]
        public string Text { get; set; } = string.Empty;
    }
}