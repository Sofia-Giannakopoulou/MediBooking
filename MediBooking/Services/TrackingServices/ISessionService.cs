using MediBooking.Models;

namespace MediBooking.Services.TrackingService
{
    public interface ISessionService
    {
        Task<string> CreateSession(string username);
        Task EndSession(string token);
        Task<SessionToken> GetSession(string token);
    }
}
