# MediBooking 🏥
MediBooking is a modern patient appointment management system that helps users find doctors by specialty and location, view profiles, and manage bookings—all in one place.
🧬Features

🔍Doctor Search
Filter doctors by specialty (e.g., cardiology, dermatology) and location to find the best match for your needs.

📅 Appointment Management

Schedule new appointments with just a few taps

Modify existing appointments

Cancel appointments when needed

👨‍⚕️ Doctor Profiles
View detailed profiles including doctor experience, availability, clinic location, and patient reviews.

📍 Location-Based Search
Easily find doctors near you using integrated location services or search by city/region.

📌 Prerequisites
Ensure you have the following installed:

SQL Server Express (or another SQL Server version) 
.NET SDK

NuGet Packages📦
Microsoft.EntityFrameworkCore (9.0.5)  
Microsoft.EntityFrameworkCore.Design (9.0.5)  
Microsoft.EntityFrameworkCore.SqlServer (9.0.5)  
Microsoft.EntityFrameworkCore.Tools (9.0.5)  
Microsoft.Extensions.Hosting (9.0.5)

Configuration Steps 🛠️

🛠️ Configuration Steps

1️⃣ Configure the Connection String:
Open appsettings.json and add or update the ConnectionStrings section:

"ConnectionStrings": {
  "DefaultConnection": "Server=WISDOM\\SQLEXPRESS;Database=DateApidb;Trusted_Connection=True;TrustServerCertificate=True"
}

2️⃣ Setup in Program.cs or Startup.cs:

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

3️⃣ Apply Migrations
Run the following commands to set up the database schema using Entity Framework Core:

dotnet ef migrations add InitialCreate
dotnet ef database update

4️⃣ 🚀 Run the project:
         dotnet run
         
5️⃣ 💾 Check your SQL Server instance using SQL Server Management Studio (SSMS) or another SQL tool to confirm successful connection and setup.
