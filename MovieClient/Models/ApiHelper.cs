using System.Threading.Tasks;
using RestSharp;


namespace MovieClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3");
      RestRequest request = new RestRequest($"movie/popular?api_key={apiKey}", Method.Get);
      RestResponse response = await client.ExecuteAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(string apiKey, int id)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3");
      RestRequest request = new RestRequest($"movie/{id}?api_key={apiKey}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> BasicSearch(string apiKey, string query)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3");
      RestRequest request = new RestRequest($"search/movie?api_key={apiKey}&language=en-US&query={query}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAdvSearch(string apiKey, string param, string query)
    {
      var GenreId = new Dictionary <string, int>()
      {
        {"Action", 28 },
        {"Adventure", 12}, 
        {"Animation", 16},
        {"Comedy", 35},
        {"Crime", 80},
        {"Documentary", 99},
        {"Drama", 18},
        {"Family", 10751},
        {"Fantasy", 14},
        {"History", 36},
        {"Horror", 27},
        {"Music", 10402},
        {"Mystery", 9648},
        {"Romance", 10749},
        {"Science Fiction", 878},
        {"TV Movie", 10770},
        {"Thriller", 53 },
        {" War", 10752},
        {"Western", 37} 
      };

      
      foreach (KeyValuePair<string, int> kvp in GenreId)
      {
        if (kvp.Key == query)
        {
          query = kvp.Value.ToString();
        }
      }

      var paramString = "";
      if (param == "0")
      {
        paramString = "with_genres";
      }
      if (param == "1")
      {
        paramString = "with_people";
      }

      RestClient client = new RestClient("https://api.themoviedb.org/3");
      RestRequest request = new RestRequest($"discover/movie?api_key={apiKey}&language=en-US&include_adult=false&{paramString}={query}", Method.Get);

      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}
