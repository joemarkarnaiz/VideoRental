using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //[Route("customer/index")]
        public ActionResult CustomerView()
        {
            //var customerModels = new CustomerModels() { Name="Joe Mark"};
            CustomerModels customerModels = new CustomerModels();
            customerModels.Name = "Lucille May Atillo";
            //customerModels.Name = "joe mark";
            //return View();
            ////return "test return11!";

            //.Message = "Your customer page.";

            return View(customerModels);
        }

        public ActionResult Customer()
        {
            //CustomerModels customerModels = new CustomerModels();
            //customerModels.Name = "joe mark";
            //return View();
            ////return "test return11!";
            ///return View();
            ///
            /// 
            /// 
            return View();
        }

        }


    }