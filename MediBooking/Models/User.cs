using MediBooking.Enums;

namespace MediBooking.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public UserRole UserRole { get; set; }

        public string Location { get; set; } = string.Empty;
        public ICollection<Appointment> AppointmentsAsPatient { get; set; } = new List<Appointment>();
        public ICollection<Appointment> AppointmentsAsDoctor { get; set; } = new List<Appointment>();
    }
}
