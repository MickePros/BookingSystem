using Microsoft.AspNetCore.Identity;

namespace BookingSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> Classes { get; set; } = new List<ApplicationUserGymClass>();
    }
}
