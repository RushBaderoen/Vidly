﻿using System;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;
using Vidly.Controllers;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Tests.Controllers
{
    [TestFixture]
    public class MovieTests
    {
        [Test]
        public void Random_WhenCalled_ReturnsRandomMovieViewModel()
        {
            MoviesController moviesController = new MoviesController();

            ViewResult result = moviesController.Random() as ViewResult;
            var vm = result.Model as RandomMovieViewModel;

            Assert.IsNotNull(vm.Movie);
        }
        [Test]
        public void ByReleaseDate_WhenCalled_ReturnReleaseDateAsContent()
        {
            const int year = 2000;
            const int month = 1;
            MoviesController moviesController = new MoviesController();

            ContentResult result = moviesController.ByReleaseDate(year, month) as ContentResult;

            Assert.AreEqual(result.Content, (year + "/" + month));
        }
    }
}
