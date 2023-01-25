using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MovieClient.Models;
using MovieClient.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MovieClient.Controllers
{
  [Authorize]
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

    public IActionResult Details(int id)
    {
      Movie movie = Movie.GetDetails(id, _apikey);

      if ((_db.Movies.FirstOrDefault(entry => movie.Id == entry.Id)) == null)
      {
        _db.Movies.Add(movie);
        _db.SaveChanges();
      }

      return View(movie);
    }

    [HttpPost]
    public async Task<ActionResult> AddToUser (int inputId)
    { 
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);

      User thisUser = _db.Users.FirstOrDefault(entry => entry.UserAccount.Id == currentUser.Id);

      // currentUser.Id changed to 
      _db.UserMovies.Add(new UserMovie() { MovieId = inputId, UserId = thisUser.UserId});
      _db.SaveChanges();

      return RedirectToAction("Details", new { id = inputId});
    }

    public ActionResult CreateReview (int inputId)
    {
      Movie movie = _db.Movies.FirstOrDefault(movie => movie.Id == inputId);
      ViewBag.MovieId = movie.Id;
      ViewBag.MovieTitle = movie.Title;

      return View();
    }

    [HttpPost]
    public async Task<ActionResult> CreateReview (Review review, int MovieId)
    {
      Movie movie = _db.Movies.FirstOrDefault(movie => movie.Id == review.MovieId);

      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      User thisUser = _db.Users.FirstOrDefault(entry => entry.UserAccount.Id == currentUser.Id);
      review.UserId = thisUser.UserId;

      _db.Reviews.Add(review);

      movie.NumberOfRatings = movie.NumberOfRatings + 1;
      movie.Rating = (movie.Rating + review.Rating) / movie.NumberOfRatings;

      _db.Movies.Update(movie);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = movie.Id });
    }
  }
}

    // [HttpPost]
    // public ActionResult RemoveFromUser (int id)
    // { 
    //   string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    //   ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
    //   UserMovie joinEntry = _db.UserMovies.FirstOrDefault(entry => entry.MovieId == id && entry.UserId == currentUser.Id);
    //   _db.UserMovies.Remove(joinEntry);
    //   _db.SaveChanges();

    //   return RedirectToAction("Details", new { id = id});
    // }
