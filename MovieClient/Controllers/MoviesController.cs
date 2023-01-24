using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MovieClient.Models;
using MovieClient.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace MovieClient.Controllers
{
  public class MoviesController : Controller
  {
    private readonly string _apikey;
    private readonly MovieClientContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public MoviesController(UserManager<ApplicationUser> userManager, MovieClientContext db, IConfiguration configuration)
    {
      _apikey = configuration["TMDB"];
      _userManager = userManager;
      _db = db;
    }

    public IActionResult Index()
    {
        return View(Movie.GetMovies(_apikey));
    }

    // public ActionResult Create()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Movie movie)
    // {
    //   // 
    //   Movie.Post(movie);
    //   return RedirectToAction("Index");
    // }

    public IActionResult Details(int id)
    {
      Movie movie = Movie.GetDetails(id);
      var poster = Movie.Poster;
      ViewBag.Poster = "https://image.tmdb.org/t/p/w500" + poster;
      return View(movie);
    }

    // public ActionResult Edit(int id)
    // {
    //   Movie movie = Movie.GetDetails(id);
    //   return View(movie);
    // }

    // [HttpPost]
    // public ActionResult Edit(Movie movie)
    // {
    //   Movie.Put(movie);
    //   return RedirectToAction("Details", new { id = movie.MovieId });
    // }

    // public ActionResult Delete(int id)
    // {
    //   Movie movie = Movie.GetDetails(id);
    //   return View(movie);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Movie.Delete(id);
    //   return RedirectToAction("Index");
    // }

    // [HttpPost]
    // public ActionResult AddMovie(Tag tag, int movieId) // Tag being Movie category to add movie to
    // {
    //   #nullable enable
    //   UserMovies? joinEntity = // API call??????
    // }
  }
}
    // [HttpPost]
    // public ActionResult AddMovie(Tag tag, int movieId) // Tag being Movie category to add movie to
    // {
    //   #nullable enable
    //   UserMovies? joinEntity = // API call??????
    // }
  }
}