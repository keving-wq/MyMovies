using System.ComponentModel.DataAnnotations;

namespace MyMovies.Models
{
    public class RunTime
    {
        public int Id { get; set; }

        [Required]
        public int Minutes { get; set; }
    }
}