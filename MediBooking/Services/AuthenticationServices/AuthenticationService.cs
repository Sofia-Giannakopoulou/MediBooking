using MediBooking.DataAccessLayer;

namespace MediBooking.Services.AuthenticationServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly DataContext _context;

        public AuthenticationService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> IsUserAuthenticated(string userName, string password)
        {
            return _context.Users.Any(e => e.Username == userName && e.Password == password);
        }
    }
}
