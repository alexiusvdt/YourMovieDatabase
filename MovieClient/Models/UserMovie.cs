using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MovieClient.Models
{
  public class UserMovie
  {
    public int UserMovieId { get; set; }
    public int MovieId { get; set; }
    public int UserId { get; set; }
    public Movie Movie { get; set; }
    public User User { get; set; }
  }



}