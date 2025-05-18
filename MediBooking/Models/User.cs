using MediBooking.Enums;

namespace MediBooking.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public UserRole UserRole { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public string Amka { get; set; } = string.Empty;

        public string PatientHistory { get; set; } = string.Empty;

        public string ProfilePicture { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Appointment> AppointmentsAsPatient { get; set; } = new List<Appointment>();
        public ICollection<Appointment> AppointmentsAsDoctor { get; set; } = new List<Appointment>();
        public List<DoctorSpecialty> Specialties { get; set; } = new List<DoctorSpecialty>();
    }
}
