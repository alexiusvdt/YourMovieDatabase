using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieClient.Models
{
  public class MovieClientContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Movie> Movies { get; set; }
    public DbSet<UserMovie> UserMovies { get; set; }

    public MovieClientContext(DbContextOptions options) : base(options) { }
  
    // protected override void OnModelCreating(ModelBuilder builder)
    // {   
    //   builder.Entity<Movie>()
    //   .HasData(
    //     new Movie { MovieId = 1, UserId = 1, ApiReferenceId = 135, Rating = 5, Genre = "Thriller", Title = "Troll 2", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 2, UserId = 1, ApiReferenceId = 187, Rating = 5, Genre = "Drama", Title = "Troll Hunter", Overview = "None shall survive", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 3, UserId = 1, ApiReferenceId = 13, Rating = 5, Genre = "Drama", Title = "Die Harder-er", Overview = "All Goblins Must Die", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 4, UserId = 1, ApiReferenceId = 186, Rating = 5, Genre = "Thriller", Title = "Troll 1", Overview = "Nilbog is Goblin backwa1rds?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 5, UserId = 1, ApiReferenceId = 1292, Rating = 5, Genre = "Mystery", Title = "Secrets of the Trolls", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 6, UserId = 1, ApiReferenceId = 1323, Rating = 5, Genre = "Comedy", Title = "Gonna be Trollin' trollin' trollin'", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 7, UserId = 1, ApiReferenceId = 355, Rating = 5, Genre = "Thriller", Title = "Troll 3: The Trollening", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 8, UserId = 1, ApiReferenceId = 2035, Rating = 5, Genre = "Horror", Title = "Trollin' 2: Electric Boogaloo", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 9, UserId = 2, ApiReferenceId = 293, Rating = 5, Genre = "Romance", Title = "Trollmance", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 11, UserId = 2, ApiReferenceId = 2135, Rating = 5, Genre = "Action", Title = "2 Troll 2 Furious", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" },
    //     new Movie { MovieId = 13, UserId = 2, ApiReferenceId = 13503, Rating = 5, Genre = "Thriller", Title = "Goblins vs Trolls", Overview = "Nilbog is Goblin backwards?!", ReleaseDate = "1/1/1970", Poster = "", Review = "It good" }
    //   );
    // }
  }
}