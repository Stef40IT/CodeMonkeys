namespace Monkey.Data.Data.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public User User { get; set; }
        public Game Game { get; set; }
        public string Text { get; set; }
        public DateTime Hour { get; set; }
    }
}
