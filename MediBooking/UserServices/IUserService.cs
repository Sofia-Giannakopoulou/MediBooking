using MediBooking.Models;

namespace MediBooking.UserServices
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
