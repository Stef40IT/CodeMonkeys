namespace Monkey.Data.Data.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }

        public DateTime BookDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
