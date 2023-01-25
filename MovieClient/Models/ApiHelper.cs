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
  }
}