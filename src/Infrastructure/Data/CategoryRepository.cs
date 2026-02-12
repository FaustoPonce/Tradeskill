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
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }

        public override List<Category> GetAll()
        {
            return _context.Categories.Include(c => c.Services).ToList();
        }
        public override Category? GetById(int id)
        {
            return _context.Categories.Include(c => c.Services).FirstOrDefault(c => c.Id == id);

        }
    }
}
