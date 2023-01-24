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
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse.ToString());
    
      return movieList;
    }
    
    public static Movie GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Movie movie = JsonConvert.DeserializeObject<Movie>(jsonResponse.ToString());
  
      return movie;
    }

    public static void Post(Movie movie)
    {
      string jsonMovie = JsonConvert.SerializeObject(movie);
      ApiHelper.Post(jsonMovie);
    }

    public static void Put(Movie movie)
    {
      string jsonMovie = Jsonconvert.SerializeObject(movie);
      ApiHelper.Put(movie.MovieId, jsonMovie);
    }

    public static void Delete(int id)
    {
      ApiHelper.Delete(id);
    }
  }
}