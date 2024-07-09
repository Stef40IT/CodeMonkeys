using Microsoft.AspNetCore.Identity;

namespace Monkey.Data.Data.Entities
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }

}
