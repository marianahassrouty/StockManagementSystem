using Stock.Domain.Users.Entities;

namespace Stock.Application.Users.Interfaces
{
    public interface IUserService
    {
        Task<User?> LoginAsync(string email, string password);
    }
}
