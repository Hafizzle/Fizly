﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fizly.Models;
using Fizly.ViewModels

namespace Fizly.Controllers
{
    public class MoviesController : Controller


        
    {

        
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };


            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        //Parameter set to only allow months (1-12)

        
        
        

        }
    }
