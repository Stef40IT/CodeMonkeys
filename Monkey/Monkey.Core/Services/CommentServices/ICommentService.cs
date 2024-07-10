using Monkey.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.Core.Services.CommentServices
{
    public interface ICommentService
    {
        Task AddCommentAsync(Comment comment);
        Task<List<Comment>> GetCommentsByGameIdAsync(int gameId);
    }
}
