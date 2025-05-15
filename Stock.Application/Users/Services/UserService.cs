using Stock.Application.Users.Interfaces;
using Stock.Domain.Users.Entities;
using Stock.Domain.Users.Repository;

namespace Stock.Application.Users.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<User?> LoginAsync(string email, string password)
    {
        return await userRepository.GetByEmailAndPasswordAsync(email, password);
    }
}
