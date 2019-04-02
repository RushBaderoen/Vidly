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
            var viewModel = GetRandomMovie();
            return View(viewModel);
        }
        // GET: Movie/Edit
        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }
        // Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        // Movies/Details/{id}
        [Route("Movies/Details/{id}")]
        public ActionResult Details(int? id)
        {
            var model = _context.Movies.SingleOrDefault(m => m.Id == id);

            return View(model);
        }
        private RandomMovieViewModel GetRandomMovie()
        {
            var movie = new Movie() { Name = "The Fast & The Furious", Id = 1 };
            var customers = new List<Customer>
            {
                new Customer {Name = "Johnny Customer" },
                new Customer {Name = "Jane Customer" },
            };

            return new RandomMovieViewModel
            {
                //Movie = movie,
                Customers = customers
            };
        }
    }
}
