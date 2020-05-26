using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStateManagement.Models;

namespace MovieStateManagement.Controllers
{
    public class MovieController : Controller
    {

        public List<Movie> sessionMovies = new List<Movie>() { 
        new Movie("Holes", 95),
        new Movie("Titanic", 124),
        new Movie("The Shawshank Redemption", 133),
        new Movie("Toy Story", 83),
        new Movie("The Notebook", 112)
        };

        public List<Movie> sessionCart = new List<Movie>();

        
        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult MovieForm()
        {
            return View(sessionMovies);
        }

        public IActionResult SelectMovie(Movie t)
        {
             string movieJSON = HttpContext.Session.GetString("CartSession") ?? "FirstTimeDoingThis";
             if (movieJSON != "FirstTimeDoingThis")
             {
                 sessionCart = JsonSerializer.Deserialize<List<Movie>>(movieJSON);
             }

            if (sessionCart.Contains(t))
            {
                sessionCart.Add(t);
            }
            else
            {
                return View("ErrorPage");
            }
             
             movieJSON = JsonSerializer.Serialize(sessionCart);

             HttpContext.Session.SetString("CartSession", movieJSON);
             
            
            return View("MovieForm", sessionMovies);
        }

        public IActionResult ListCart()
        {
            string movieJSON = HttpContext.Session.GetString("CartSession") ?? "FirstTimeDoingThis";
            if (movieJSON != "FirstTimeDoingThis")
            {
                sessionCart = JsonSerializer.Deserialize<List<Movie>>(movieJSON);
            }

            
            movieJSON = JsonSerializer.Serialize(sessionCart);

            HttpContext.Session.SetString("CartSession", movieJSON);


            
            return View(sessionCart);
        }

        public IActionResult Reciept()
        {
            sessionCart.Clear();

            return View(sessionCart);
        }
    }
}