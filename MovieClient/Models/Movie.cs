using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MovieClient.Models
{
  public class Movie
  {
    public int MovieId { get; set; }
    // public int TmdbId { get; set; } 

    //need to add logic to parse JSON "name" keys to string[], ignoring "id" keys
    // public string[] Genres { get; set; }
    public string Title { get; set; }
    public string Overview { get; set; }
    public string Release_Date { get; set; }
    public string Poster_Path { get; set; }
    // we add reviews
    public string Review { get; set; }
    // // add logic to dynamically change this
    // public int Rating { get; set; }
    // public int NumberOfRatings { get; set; }
    // public int UserId { get; set; }

      // NumberOfRatings += 1;
      // Rating = (Rating + Rating) / NumberOfRatings;


    public static List<Movie> GetMovies(string api_key)
    {
      var apiCallTask = ApiHelper.ApiCall(api_key);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse["results"].ToString());
    
      return movieList;
    }
    
    // public static Movie GetDetails(int id)
    // {
    //   var apiCallTask = ApiHelper.Get(id);
    //   var result = apiCallTask.Result;

    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   Movie movie = JsonConvert.DeserializeObject<Movie>(jsonResponse.ToString());
  
    //   return movie;
    // }

    // public static void Post(Movie movie)
    // {
    //   string jsonMovie = JsonConvert.SerializeObject(movie);
    //   ApiHelper.Post(jsonMovie);
    // }

    // public static void Put(Movie movie)
    // {
    //   string jsonMovie = Jsonconvert.SerializeObject(movie);
    //   ApiHelper.Put(movie.MovieId, jsonMovie);
    // }

    // public static void Delete(int id)
    // {
    //   ApiHelper.Delete(id);
    // }
  }
}