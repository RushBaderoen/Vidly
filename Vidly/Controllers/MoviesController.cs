using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "The Fast & The Furious", Id = 1 };
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith" },
                new Customer {Name = "Mary Williams" },
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        // movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
            //return View(GetMovies());
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        // movies/Details/{id}
        [Route("Movies/Details/{id}")]
        public ActionResult Details(int? id)
        {
            var model = _context.Movies.SingleOrDefault(m => m.Id == id);

            return View(model);
        }
        /// <summary>
        /// Hard coded movie list
        /// </summary>
        /// <returns></returns>
        //private IEnumerable<Movie> GetMovies()
        //{
        //    var movies = new List<Movie>();

        //    movies.Add(new Movie() { Name = "The Fast & The Furious", Id = 1 });
        //    movies.Add(new Movie() { Name = "2 Fast 2 Furious", Id = 2 });

        //    return movies.AsEnumerable();
        //}
    }
}