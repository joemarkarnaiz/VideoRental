using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModels;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "joe mark" };
            var customer = new List<CustomerModels>()
            {
                new CustomerModels{ Name= "customer 1"},
                new CustomerModels{ Name= "customer 2"}
            };

            var viewModel = new RandonMovieViewModel {
                Movie = movie,
                CustomerModels = customer
            };
            return View(viewModel);
        }
    }
}