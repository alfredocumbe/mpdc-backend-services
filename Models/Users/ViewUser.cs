namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class ViewUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}