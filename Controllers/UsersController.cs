namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Models.Users;
using WebApi.Repositories;
using WebApi.utils;

[ApiController]
[Route("api/v1/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    public IActionResult Create(CreateUser createUser)
    {
        User user = new User();
        user.Email = createUser.Email;
        user.FirstName = createUser.FirstName;
        user.LastName = createUser.LastName;
        user.UserName = createUser.UserName;
        user.Password = AesEncryption.Encrypt(createUser.Password);
        _userRepository.Add(user);
        return Ok(new { message = "User created" });
    }

    [HttpPost("login")]
    public IActionResult Login(Login login)
    {
        LoginResponse response = new LoginResponse();
        User user = _userRepository.getUser(login.UserName, AesEncryption.Encrypt(login.Password));
        response.Exist = (user != null);
        if (response.Exist)
        {
            ViewUser viewUser = new ViewUser();
            viewUser.FirstName = user.FirstName;
            viewUser.LastName = user.LastName;
            viewUser.Email = user.Email;
            response.ViewUser = viewUser;
        }

        return Ok(response);
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userRepository.GetAll());
    }

}