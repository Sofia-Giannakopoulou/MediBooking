using MediBooking.Models;

namespace MediBooking.UserServices
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAppointmentsAsync();
        Task<Appointment?> GetAppointmentByIdAsync(int id);
        Task<bool> CreateAppointment(Appointment appointment);
        Task<bool> UpdateAppointment(Appointment appointment);
        Task<bool> DeleteAppointmentAsync(int id);

    }
}
