using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieClient.Models
{
  public class User
  {
    public int UserId { get; set; }
    // if someone clicks mark as watched, we add string movie to moviesWatched
    // in the Update ApplicationUser controller, we do user.moviesWatched += movie + ", "
    public string MoviesWatched { get; set; }
    public string Name { get; set; }
    public List<UserMovie> JoinEntities { get; }
    public ApplicationUser UserAccount { get; set; }
  }
}