using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MovieClient.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieClient.Models
{
  public class Movie
  {
    public int MovieId { get; set; }
    public int Id { get; set; } 
    public List<Genre> Genres { get; set; }
    public string Title { get; set; }
    public string Overview { get; set; }
    public string Release_Date { get; set; }
    public string Poster_Path { get; set; }
    public string Review { get; set; }
    public int Rating { get; set; }
    public int NumberOfRatings { get; set; }
    public UserMovie joinEntity { get; set; }



    public static List<Movie> GetMovies(string api_key)
    {
      var apiCallTask = ApiHelper.ApiCall(api_key);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse["results"].ToString());
    
      return movieList;
    }
    
    public static Movie GetDetails(int id, string apiKey)
    {
      var apiCallTask = ApiHelper.Get(apiKey, id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Movie movie = JsonConvert.DeserializeObject<Movie>(jsonResponse.ToString());
  
      return movie;
    }

    public static List<Movie> GetBasicSearch(string query, string apiKey)
    {
      var apiCallTask = ApiHelper.BasicSearch(apiKey, query);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Movie> resultsList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse["results"].ToString());
      return resultsList;
    }
  
    public static List<Movie> GetAdvSearch(string param, string query, string apiKey)
    {    
      // switch(dropdown/select) 
      // {
      //   case x:
      //     // code block
      //     break;
      //   case y:
      //     // code block
      //     break;
      //   default:
      //     // code block
      //     break;
      // }
     
      var apiCallTask = ApiHelper.GetAdvSearch(apiKey, param, query);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Movie> resultsList = JsonConvert.DeserializeObject<List<Movie>>(jsonResponse["results"].ToString());
      return resultsList;
    }
  } 
}
