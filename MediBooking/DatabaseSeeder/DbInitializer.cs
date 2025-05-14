using MediBooking.DataAccessLayer;
using MediBooking.Enums;
using MediBooking.Models;

namespace MediBooking.DatabaseSeeder
{
    public class DbInitializer
    {
        public static void SeedUsers(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<DataContext>();

            if(!context.Users.Any())
            {
                var users = new List<User>
                {
                    new User { Id = 1, FirstName = "Μεγάλος", LastName = "Φωτόπουλος", UserRole = UserRole.Doctor, Location = "Μαρούσι"},
                    new User { Id = 2, FirstName = "Σοφία", LastName = "Γιαννακοπούλου", UserRole = UserRole.Admin, Location = "Νέα Χαλκηδόνα"},
                    new User { Id = 3, FirstName = "Θωμάς", LastName = "Μπενχάφση", UserRole = UserRole.Admin, Location = "Πεύκη"},
                    new User { Id = 4, FirstName = "Ιάσονας", LastName = "Γιασούνης", UserRole = UserRole.Patient, Location = "Κατ" },
                    new User { Id = 5, FirstName = "Κώστας", LastName = "Καταιγίδας", UserRole = UserRole.Doctor, Location = "Κηφισιά"},
                    new User { Id = 6, FirstName = "Νίκος", LastName = "Βασιλείου", UserRole = UserRole.Patient, Location = "Δροσιά"},
                    new User { Id = 7, FirstName = "Θωμαή", LastName = "Γιασούνα", UserRole = UserRole.Patient, Location = "Κατ" },
                    new User { Id = 8, FirstName = "Μαρίλια", LastName = "Γκούτσι", UserRole = UserRole.Doctor, Location = "Παρίσι"},
                    new User { Id = 9, FirstName = "Πάρης", LastName = "Παρίκης", UserRole = UserRole.Patient, Location = "Βριλήσσια"},
                    new User { Id = 10, FirstName = "Μικρός", LastName = "Φωτόπουλος", UserRole = UserRole.Patient, Location = "Μαρούσι"},  
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }
        public static void SeedAppointments(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<DataContext>();

            if (!context.Appointments.Any())
            {
                var appointments = new List<Appointment>
            {
                new Appointment { Id = 1, PatientId = 4, DoctorId = 5, ScheduledDate = new DateTime(2025, 6, 1, 9, 0, 0), AppointmentStatus = AppointmentStatus.Scheduled },
                new Appointment { Id = 2, PatientId = 6, DoctorId = 1, ScheduledDate = new DateTime(2025, 6, 2, 10, 0, 0), AppointmentStatus = AppointmentStatus.Scheduled },
                new Appointment { Id = 3, PatientId = 7, DoctorId = 5, ScheduledDate = new DateTime(2025, 6, 3, 14, 0, 0), AppointmentStatus = AppointmentStatus.Scheduled },
                new Appointment { Id = 4, PatientId = 9, DoctorId = 8, ScheduledDate = new DateTime(2025, 6, 4, 11, 0, 0), AppointmentStatus = AppointmentStatus.Rescheduled },
                new Appointment { Id = 5, PatientId = 10, DoctorId = 1, ScheduledDate = new DateTime(2025, 6, 5, 9, 0, 0), AppointmentStatus = AppointmentStatus.Cancelled },
                new Appointment { Id = 6, PatientId = 6, DoctorId = 8, ScheduledDate = new DateTime(2025, 6, 6, 15, 0, 0), AppointmentStatus = AppointmentStatus.Rescheduled },
                new Appointment { Id = 7, PatientId = 7, DoctorId = 5, ScheduledDate = new DateTime(2025, 6, 7, 13, 0, 0), AppointmentStatus = AppointmentStatus.Completed },
                new Appointment { Id = 8, PatientId = 10, DoctorId = 8, ScheduledDate = new DateTime(2025, 6, 8, 16, 0, 0), AppointmentStatus = AppointmentStatus.Completed },
            };

                context.Appointments.AddRange(appointments);
                context.SaveChanges();
            }
        }
    }
}

