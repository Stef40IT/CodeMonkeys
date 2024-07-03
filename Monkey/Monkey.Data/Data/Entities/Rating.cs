namespace codeMonkeys.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        public Game Game { get; set; }
        public User User { get; set; }
        public int Rate { get; set; }
    }
}
