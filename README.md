# MediBooking 🏥
📌 Prerequisites Ensure you have the following installed:

SQL Server Express (or another SQL Server version) .NET SDK

NuGet Packages
Microsoft.EntityFrameworkCore(9.0.5) Microsoft.EntityFrameworkCore.Design(9.0.5) Microsoft.EntityFrameworkCore.SqlServer(9.0.5) Microsoft.EntityFrameworkCore.Tools(9.0.5) Microsoft.Extensions.Hosting(9.0.5).

Configuration Steps 🛠️
1️⃣ Step 1 📂 Locate the appsettings.json file in your project. Add or update the ConnectionStrings section:

"ConnectionStrings": { "DefaultConnection": "Server=WISDOM\SQLEXPRESS;Database=DateApidb;Trusted_Connection=True;TrustServerCertificate=True" }

💡 Example:
If you’re using SQL Server Express (on your local machine) and a database named DateApidb, the connection string will look like this: "ConnectionStrings": { "DefaultConnection": "Server=MY_SERVER\SQLEXPRESS;Database=MyDatabase;Trusted_Connection=True;TrustServerCertificate=True" }

2️⃣ Step 2 ⚙️ Apply the connection string in your Program.cs or Startup.cs:

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); builder.Services.AddDbContext(options => options.UseSqlServer(connectionString));

3️⃣ Step 3
Apply migrations (using Entity Framework Core):

  dotnet ef migrations add InitialCreate
  dotnet ef database update
  
4️⃣ Step 4
🚀 Run the project:
         dotnet run
5️⃣ Step 5
💾 Verify database connection in SQL Server Management Studio (SSMS) or another SQL tool.
