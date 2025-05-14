using MediBooking.DataAccessLayer;
using MediBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace MediBooking.UserServices
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> DeleteUser(User userToDelete)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userToDelete.Id);

            if (user == null)
            {
                return false;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<bool> UpdateUser(User userWithNewValues)
        {
            try
            {
                var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == userWithNewValues.Id);

                if (existingUser == null)
                {
                    return false;
                }

                existingUser.FirstName = userWithNewValues.FirstName;
                existingUser.LastName = userWithNewValues.LastName;
                existingUser.Location = userWithNewValues.Location;

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
