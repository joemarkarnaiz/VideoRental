﻿using System.Web;
using System.Web.Mvc;

namespace VideoRental
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // To require HTTPS requests
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
