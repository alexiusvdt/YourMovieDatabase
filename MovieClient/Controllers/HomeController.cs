using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using MovieClient.Models;

namespace MovieClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _apikey;   
        private readonly MovieClientContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, MovieClientContext db, IConfiguration configuration)
        {
        _apikey = configuration["TMDB"];
        _userManager = userManager;
        _db = db;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
        return View(Movie.GetMovies(_apikey));
        }

        // public IActionResult Index()
        // {
        //     return View(Movie.GetMovies(_apikey));
        // }

        [HttpGet("/privacy")]
        public async Task<ActionResult> Privacy()
        {
        return View();
        }
    }
}