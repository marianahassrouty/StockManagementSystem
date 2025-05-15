using Microsoft.EntityFrameworkCore;
using Stock.Domain.Users.Entities;
using Stock.Domain.Users.Repository;
using Stock.Infrastructure.Configurations;
using static BCrypt.Net.BCrypt;

namespace Stock.Infrastructure.Users.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<User?> GetByEmailAndPasswordAsync(string email, string password)
    {
        User? user = await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
            return null;

        // Verify hashed password
        bool isPasswordValid = Verify(password, user?.Password);

        return isPasswordValid ? user : null;
    }
}
