using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MovieClient.Models;
using MovieClient.ViewModels;

namespace MovieClient.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
      // return RedirectToAction("Index", "Movies");
    }
  }
}