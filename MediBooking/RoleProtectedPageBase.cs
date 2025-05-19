
using MediBooking.Enums;
using MediBooking.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace MediBooking
{
    public class RoleProtectedPageBase : ComponentBase
    {
        [Inject] protected ProtectedLocalStorage LocalStorage { get; set; }
        [Inject] protected NavigationManager NavigationManager { get; set; }

        protected User CurrentUser { get; set; }

        protected async Task<bool> AuthorizeAsync(UserRole requiredRole)
        {
            var result = await LocalStorage.GetAsync<User>("currentUser");
            if (!result.Success)
            {
                NavigationManager.NavigateTo("/signin");
                return false;
            }

            CurrentUser = result.Value;
            if (CurrentUser.UserRole != requiredRole)
            {
                NavigationManager.NavigateTo("/unauthorized");
                return false;
            }

            return true;
        }
    }
}

