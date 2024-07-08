namespace Monkey.Data.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public ApplicationUser User { get; set; }
        public Game Game { get; set; }
        public string Text { get; set; }
        public DateTime Hour { get; set; }
    }
}
