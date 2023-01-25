using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieClient.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string Name { get; set; }
    public List<UserMovie> JoinEntities { get; }
    public List<Review> Reviews { get; set; }
    public ApplicationUser UserAccount { get; set; }
  }
}