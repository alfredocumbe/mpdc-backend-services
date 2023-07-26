namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class LoginResponse
{
    [Required]
    public bool Exist { get; set; }
    public ViewUser ViewUser { get; set; }

}