using MediBooking.DataAccessLayer;
using MediBooking.Models;

namespace MediBooking.Services.TrackingService
{
    public class SessionService : ISessionService
    {
        private readonly DataContext _context;

        public SessionService(DataContext context)
        {
            _context = context;
        }
        public async Task<string> CreateSession(string username)
        {
            var token = Guid.NewGuid().ToString();

            var session = new SessionToken
            {
                Username = username,
                Token = token,
                LoginTime = DateTime.UtcNow
            };

            _context.SessionTokens.Add(session);
            await _context.SaveChangesAsync();

            return token;
        }

        public async Task EndSession(string token)
        {
            var session = _context.SessionTokens.FirstOrDefault(s => s.Token == token && s.LogoutTime == null);
            if (session != null)
            {
                session.LogoutTime = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<SessionToken> GetSession(string token)
        {
            return await _context.SessionTokens.FindAsync(Guid.Parse(token));
        }
    }
}
