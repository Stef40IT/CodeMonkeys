using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Projections.Games
{
    public class GameEditProjection
    {
        public required int Id { get; init; }
        public required string Description { get; init; }
        public required string Picture { get; init; }
        public required string Name { get; init; }
        public required int Difficulty { get; init; }
        public required int Count { get; init; }
        public required ICollection<Rating> Raitings { get; init; }

        public required ICollection<Reservation> Reservations { get; init; }

        public required ICollection<Comment> Comments { get; init; }

        public required bool isBooked { get; init; }
    }
}
