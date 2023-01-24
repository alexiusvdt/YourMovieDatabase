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
        private readonly MovieClientContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager, MovieClientContext db)
        {
        _userManager = userManager;
        _db = db;
        }

        // [HttpGet("/")]
        // public async Task<ActionResult> Index()
        // {
        // Flavor[] flavors = _db.Flavors.ToArray();
        // Treat[] treats = _db.Treats.ToArray();
        // Dictionary<string, object[]> model = new Dictionary<string, object[]>();
        // model.Add("flavors", flavors);
        // model.Add("treats", treats);
        // return View(model);
        // }
    }
}