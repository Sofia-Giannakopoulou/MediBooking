using MediBooking.Enums;
using MediBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace MediBooking.DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.AppointmentsAsPatient)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.AppointmentsAsDoctor)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            //Seeding Appointments
            modelBuilder.Entity<Appointment>().HasData(
            new Appointment
            {
                Id = 1,
                PatientId = 4,
                DoctorId = 5,
                ScheduledDate = new DateTime(2025, 06, 01, 9, 0, 0), 
                AppointmentStatus = AppointmentStatus.Scheduled
            },
            new Appointment
            {
                Id = 2,
                PatientId = 6,
                DoctorId = 1,
                ScheduledDate = new DateTime(2025, 06, 02, 10, 0, 0),
                AppointmentStatus = AppointmentStatus.Scheduled
            },
            new Appointment
            {
                Id = 3,
                PatientId = 7,
                DoctorId = 5,
                ScheduledDate = new DateTime(2025, 06, 03, 14, 0, 0),
                AppointmentStatus = AppointmentStatus.Scheduled
            },
            new Appointment
            {
                Id = 4,
                PatientId = 9,
                DoctorId = 8,
                ScheduledDate = new DateTime(2025, 06, 04, 11, 0, 0),
                AppointmentStatus = AppointmentStatus.Rescheduled
            },
            new Appointment
            {
                Id = 5,
                PatientId = 10,
                DoctorId = 1,
                ScheduledDate = new DateTime(2025, 06, 05, 9, 0, 0),
                AppointmentStatus = AppointmentStatus.Cancelled
            },
            new Appointment
            {
                Id = 6,
                PatientId = 6,
                DoctorId = 8,
                ScheduledDate = new DateTime(2025, 06, 06, 15, 0, 0),
                AppointmentStatus = AppointmentStatus.Rescheduled
            },
            new Appointment
            {
                Id = 7,
                PatientId = 7,
                DoctorId = 5,
                ScheduledDate = new DateTime(2025, 06, 07, 13, 0, 0),
                AppointmentStatus = AppointmentStatus.Completed
            },
            new Appointment
            {
                Id = 8,
                PatientId = 10,
                DoctorId = 8,
                ScheduledDate = new DateTime(2025, 06, 08, 16, 0, 0),
                AppointmentStatus = AppointmentStatus.Completed
            }
        );
        }
    }
}
