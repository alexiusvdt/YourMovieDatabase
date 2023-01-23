using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MovieClient.Models
{
  public class Movie
  {
    public int MovieId { get; set; }
    public string Genre { get; set; }
    public string Title { get; set; }
    public string Overview { get; set; }
    public string ReleaseDate { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string Poster { get; set; }
    public string Review { get; set; }
  
  public static List<Movie> GetMovies()
  {

  }
  
  public static Movie GetDetails(int id)
  {

  }

  public static void Post(Movie movie)
  {

  }

  public static void Put(Movie movie)
  {

  }

  public static void Delete(int id)
  {
    
  }


  }

}