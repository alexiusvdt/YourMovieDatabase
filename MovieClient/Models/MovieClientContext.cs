using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieClient.Models
{
  public class MovieClientContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Movie> Movies { get; set; }
    public DbSet<UserMovie> UserMovies { get; set; }

    public MovieClientContext(DbContextOptions options) : base(options) { }
  }
}
