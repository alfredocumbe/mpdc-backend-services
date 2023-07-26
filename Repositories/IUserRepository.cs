namespace WebApi.Repositories;

using WebApi.Entities;

public interface IUserRepository{
    void Add(User user);
    User getUser(string UserName, string Password);
    IEnumerable<User> GetAll();
}