using MediBooking.Components;
using MediBooking.DataAccessLayer;
using MediBooking.DatabaseSeeder;
using MediBooking.Services.AuthorizationServices;
using MediBooking.Services.TrackingService;
using MediBooking.Services.UserServices;
using MediBooking.UserServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using MediBooking.Services.AuthenticationServices;
namespace MediBooking;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        //User Service
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IAppointmentService, AppointmentService>();
        builder.Services.AddScoped<IAuthorizationService, AuthorizationService>();
        builder.Services.AddScoped<Services.AuthenticationServices.IAuthenticationService, Services.AuthenticationServices.AuthenticationService>();
        builder.Services.AddScoped<ISessionService, SessionService>();
        builder.Services.AddControllers();

        //Connection String
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        var app = builder.Build();

        //DbInitializer.SeedAppointments(services);
        using (var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<DataContext>();
            DbInitializer.SeedUsers(services);
            
        }
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();
        app.UseStaticFiles();
        app.MapControllers();

        app.Run();
    }
}
