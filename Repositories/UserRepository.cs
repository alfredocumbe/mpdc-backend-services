namespace WebApi.Repositories;

using System.Collections.Generic;
using WebApi.Entities;
using WebApi.Helpers;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{

    private readonly DataContext _context;

    public UserRepository(DataContext context)
    {
        _context = context;
    }

    public void Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public IEnumerable<User> GetAll()
    {
        return _context.Users.ToList();
    }

    public User getUser(string UserName, string Password)
    {
        return _context.Users.FirstOrDefault(c => c.UserName == UserName && c.Password == Password);
    }
}