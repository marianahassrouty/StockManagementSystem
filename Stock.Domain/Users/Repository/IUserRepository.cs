using Stock.Domain.Users.Entities;

namespace Stock.Domain.Users.Repository
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAndPasswordAsync(string email, string password);
    }
}
