using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoRental.Models;

namespace VideoRental.ViewModels
{
    public class RandonMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<CustomerModels> CustomerModels { get; set; }
    }
}