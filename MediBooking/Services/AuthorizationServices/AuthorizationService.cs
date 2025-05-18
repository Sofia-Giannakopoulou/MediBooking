using MediBooking.DataAccessLayer;
using MediBooking.Models;

namespace MediBooking.Services.AuthorizationServices
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly DataContext _context;

        public AuthorizationService(DataContext context)
        {
            _context = context;
        }

        public User GetCurrentUser(string username)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }
    }
}
