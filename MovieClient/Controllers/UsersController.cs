using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using MovieClient.Models;

namespace MovieClient.Controllers
{
    public class UsersController : Controller
    {
        private readonly MovieClientContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager, MovieClientContext db)
        {
        _userManager = userManager;
        _db = db;
        }

        public async Task<ActionResult> Index()
        {
          var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;  
          var currentUser = await _userManager.FindByIdAsync(userId);

          User user = _db.Users.FirstOrDefault(entry => entry.UserAccount.Id == currentUser.Id);
          return View(user);
        }
    }
}