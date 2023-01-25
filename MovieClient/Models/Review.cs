using System.ComponentModel.DataAnnotations;

namespace MovieClient.Models

{
  public class Review
  {
    public int ReviewId { get; set; }

    [Required(ErrorMessage = "The review can't be empty!")]
    public string Text { get; set; }

    [Range(1, 10, ErrorMessage = "Please enter a rating on a scale from 1 to 10!")]
    public int Rating { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
  }
}