using Microsoft.AspNetCore.Identity;

namespace MovieClient.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string Name { get; set; }
  }
}