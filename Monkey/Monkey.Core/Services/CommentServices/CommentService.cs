using Monkey.Data.Data.Entities;
using Monkey.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Monkey.Core.Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddCommentAsync(Comment comment)
        {
            var res = _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCommentAsync(Comment comment)
        {
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetCommentsByGameIdAsync(int gameId)
        {
           var res = await _context.Comments
                .Where(c => c.GameId == gameId)
                .Include(c => c.User)
                .OrderByDescending(g => g.Hour)
                .ToListAsync();
            return res;
        }
    }
}
