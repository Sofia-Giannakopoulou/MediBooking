using MediBooking.Enums;
using System.ComponentModel.DataAnnotations;

namespace MediBooking.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public User Patient { get; set; }

        public int DoctorId { get; set; }

        public User Doctor { get; set; }

        public AppointmentStatus AppointmentStatus { get; set; }

        public string? ReasonForVisit { get; set; }

        public string? DoctorNotes { get; set; }

        public DateTime ScheduledDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
        public bool IsRemoteAppointment { get; set; } = false;
    }
}
