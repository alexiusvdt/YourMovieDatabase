namespace MovieClient.Models
{
  public class Review
  {
    public string ReviewId { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
  }
}