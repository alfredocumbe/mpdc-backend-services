namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class Login
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}