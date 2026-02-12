using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public override List<Service> GetAll()
        {
            return _context.Services.Include(s => s.Freelancer).Include(s => s.Category).ToList();
        }

        public override Service? GetById(int id)
        {
            return _context.Services.Include(s => s.Freelancer).Include(s => s.Category).FirstOrDefault(s => s.Id == id);
        }
    }
}
