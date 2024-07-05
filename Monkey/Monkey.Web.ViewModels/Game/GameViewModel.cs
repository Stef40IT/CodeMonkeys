using System.ComponentModel.DataAnnotations;

namespace Monkey.Web.ViewModels.Game
{
    public class GameViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Name { get; set; }
        public int Difficulty { get; set; }
        public int Count { get; set; }
    }
}
