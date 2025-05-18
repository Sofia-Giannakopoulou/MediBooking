namespace MediBooking.Services.AuthenticationServices
{
    public interface IAuthenticationService
    {
        Task<bool> IsUserAuthenticated(string userName, string password);
    }  
}
