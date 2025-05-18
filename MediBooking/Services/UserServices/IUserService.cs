using MediBooking.Models;

namespace MediBooking.Services.UserServices
{
    public interface IUserService
    {
        Task<bool> CreateUser(User user);
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserById(int id);
        Task<bool> UpdateUser(User user);
        Task<bool> DeleteUser(User userToDelete);
    }

}
