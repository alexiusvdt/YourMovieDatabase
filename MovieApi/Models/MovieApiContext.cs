using Microsoft.EntityFrameworkCore;

namespace MovieApi.Models
{
  public class MovieApiContext : DbContext
  {
    public DbSet<Movie> Movies { get; set; }
    

    public MovieApiContext(DbContextOptions<MovieApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
      //   new Animal { AnimalId = 1, Name = "Denna", Species = "Cat", SubSpecies = "Himalayan", Age = 7 },
      //   new Animal { AnimalId = 2, Name = "Kvothe", Species = "Dog", SubSpecies = "Borzoi", Age = 2 },
      //   new Animal { AnimalId = 3, Name = "Haliax", Species = "Dog", SubSpecies = "Poodle", Age = 5 },
      //   new Animal { AnimalId = 4, Name = "Bast", Species = "Cat", SubSpecies = "Domestic Shorthair", Age = 5 },
      //   new Animal { AnimalId = 5, Name = "OreSeur", Species = "Dog", SubSpecies = "Wolfhound", Age = 10 },
      //   new Animal { AnimalId = 6, Name = "Elend", Species = "Dog", SubSpecies = "Jack Russel Terrier", Age = 4 },
      //   new Animal { AnimalId = 7, Name = "Kjelvin", Species = "Cat", SubSpecies = "Abyssinian", Age = 3 }
      );
    }
  }
}