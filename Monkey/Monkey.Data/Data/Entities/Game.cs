namespace Monkey.Data.Data.Entities
{
    public class Game : IIdentifiable
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int Count { get; set; }
        public ICollection<Rating> Raitings { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public bool isBooked { get; set; }

    }
}
