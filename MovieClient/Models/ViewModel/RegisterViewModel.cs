using System.ComponentModel.DataAnnotations;

namespace MovieClient.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }

    [Required]
    [Display(Name = "Your username")]
    public string Name { get; set; }

    // [Display(Image = "Image URL")]
    // public string Image { get; set; }
  }
}