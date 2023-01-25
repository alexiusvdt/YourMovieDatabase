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

    // gets invoked when someone tries to create a review for a movie on movie details page
    [HttpPost]
    public ActionResult CreateOrUpdate(Movie movie, int MovieId)
    {
      // IF movie does not exist, take new movie object, add to db
      // if ((_db.Movies.FirstOrDefault(entry => movie.MovieId == entry.MovieId)) == null)
      // {
      //   _db.Movies.Add(movie);
      //   _db.SaveChanges();
      // }
      
      // check IF movie does exist, _db.Update(movie), redirect to details page
      // movie.Review = movie.Review;
      movie.Rating = (movie.Rating + movie.Rating) / movie.NumberOfRatings;
      movie.NumberOfRatings += 1;
      _db.Update(movie);
      _db.SaveChanges();

      return RedirectToAction("Details", new { id = movie.MovieId });
    }

    public IActionResult Details(int id)
    {
      Movie movie = Movie.GetDetails(id, _apikey);

      // IF movie does not exist, take new movie object, add to db
      if ((_db.Movies.FirstOrDefault(entry => movie.Id == entry.Id)) == null)
      {
        _db.Movies.Add(movie);
        _db.SaveChanges();
      }

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