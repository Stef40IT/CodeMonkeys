using System.Security.Cryptography.Xml;

namespace codeMonkeys.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
