using JacobOlsenMission.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
      

        /*Creating the movieContext method to save the data to the database later on*/
        private MovieFormContext movieContext { get; set; }

        //Constructor
        public HomeController(MovieFormContext someName)
        {
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
            ViewBag.Categorys = movieContext.Categorys.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            /*To ensure that the form being submitted is valid, the program will evaluate this if statement
             to either allow the submission or throw errors if something is missing or not entered
            correctly.*/
            if (ModelState.IsValid)
            {
                /*Adding and saving the new data to the database*/
                movieContext.Add(ar);
                movieContext.SaveChanges();

                /*Returning the user to the Confirmation page view*/
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categorys = movieContext.Categorys.ToList();
                return View();
            }
            
        }

        /*Adding the MovieList action which will display the MovieList View as well as pass it the 
         movies object*/

        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

        /*Adding the Edit actions, which will change a record in the database*/

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categorys = movieContext.Categorys.ToList();

            var movie = movieContext.Responses.Single(x => x.MovieID == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse ap)
        {
            movieContext.Update(ap);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        /*Adding the Delete actions, which will delete a record from the database*/

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = movieContext.Responses.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            movieContext.Responses.Remove(ar);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
