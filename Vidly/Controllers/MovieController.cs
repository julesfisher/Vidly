using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var _context = new VidlyContext();
            var movies = _context.Movies.ToList();

            return View(movies);
        }
    }


}
       
    
