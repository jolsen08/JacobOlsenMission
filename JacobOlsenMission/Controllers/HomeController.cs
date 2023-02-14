using JacobOlsenMission.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JacobOlsenMission.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        /*Creating the movieContext method to save the data to the database later on*/
        private MovieFormContext movieContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            movieContext = someName;
        }

        /*Creating the Action for the Index Call, returning the index page view*/
        public IActionResult Index()
        {
            return View();
        }

        /*Creating the Action for the MyPodcasts Call, returning the view of that page*/
        public IActionResult MyPodcasts()
        {
            return View();
        }

        /*Here are the HttpGet and HttpPost methods for the MovieForm page*/
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            /*Adding and saving the new data to the database*/
            movieContext.Add(ar);
            movieContext.SaveChanges();

            /*Returning the user to the Confirmation page view*/
            return View("Confirmation", ar);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
