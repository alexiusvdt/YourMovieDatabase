using System.Threading.Tasks;
using RestSharp;

namespace MovieClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("Http://localhost:5001/");
      RestRequest request = new RestRequest($"api/movies", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("Http://localhost:5001/");
      RestRequest request = new RestRequest($"api/movies{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post(string newMovie)
    {
      RestClient client = new RestClient("Http://localhost:5001/");
      RestRequest request = new RestRequest($"api/movies", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonbody(newMovie);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string newMovie)
    {
      RestClient client = new RestClient("Http://localhost:5001/");
      RestRequest request = new RestRequest($"api/movies{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonbody(newMovie);
      await client.PostAsync(request);
    }
    
    public static async void Delete(int id)
    {
      RestClient client = new RestClient("Http://localhost:5001/");
      RestRequest request = new RestRequest($"api/movies{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request)
    }
  }
}