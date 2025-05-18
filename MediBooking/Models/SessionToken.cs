namespace MediBooking.Models
{
    public class SessionToken
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Token { get; set; }
        public string Username { get; set; }
        public DateTime LoginTime { get; set; } = DateTime.UtcNow;
        public DateTime? LogoutTime { get; set; }
        public bool IsActive => LogoutTime == null;
    }
}
