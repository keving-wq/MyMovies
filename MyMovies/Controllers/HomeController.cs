using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

namespace MyMovies.Controllers
{
    public class HomeController : Controller
    {
        // Mock dataset balancing beginner readable logic with structured data access
        private static List<Movies> _movies = new()
        {
            new Movies { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16), Director = "Christopher Nolan", Description = "A thief who steals corporate secrets through dream-sharing technology." },
            new Movies { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18), Director = "Christopher Nolan", Description = "Batman faces the Joker in Gotham City." }
        };

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movies movies)
        {
            if (ModelState.IsValid)
            {
                movies.Id = _movies.Max(m => m.Id) + 1;
                _movies.Add(movies);
                return RedirectToAction(nameof(Index));
            }
            return View(movies);
        }
    }
}