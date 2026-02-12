using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        private readonly ApplicationDbContext _context;
        public ReviewRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override List<Review> GetAll()
        {
            return _context.Reviews.Include(r => r.Order).ThenInclude(o => o.Client)
                           .Include(r => r.Order).ThenInclude(o => o.Service)
                           .ToList();
        }
        public override Review? GetById(int Id)
        {
            return _context.Reviews.Include(r => r.Order).ThenInclude(o => o.Client)
                           .Include(r => r.Order).ThenInclude(o => o.Service)
                           .FirstOrDefault(r => r.Id == Id);
        }
    }
}
