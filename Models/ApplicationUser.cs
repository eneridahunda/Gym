namespace Gym.Models
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime TimeStamp { get; set; }


        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}
