using Microsoft.AspNetCore.Mvc;
using MyMovies.Models;

namespace MyMovies.Controllers
{
    public class HomeController : Controller
    {
        private static List<Movie> _movies = new()
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", RunTime = "2h 28m", Synopsis = "A thief steals secrets via dream-sharing.", Rating = "PG-13" },
            new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", RunTime = "2h 32m", Synopsis = "Batman faces the Joker.", Rating = "PG-13" }
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
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _movies.Any() ? _movies.Max(m => m.Id) + 1 : 1;
                _movies.Add(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }
    }
}