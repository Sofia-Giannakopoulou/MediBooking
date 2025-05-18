using MediBooking.Models;

namespace MediBooking.Services.AuthorizationServices
{
    public interface IAuthorizationService
    {
        User GetCurrentUser(string username);
    }
}
