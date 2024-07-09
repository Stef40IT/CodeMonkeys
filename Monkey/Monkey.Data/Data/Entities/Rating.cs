namespace Monkey.Data.Data.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public ApplicationUser User { get; set; }
        public int Rate { get; set; }
    }
}
