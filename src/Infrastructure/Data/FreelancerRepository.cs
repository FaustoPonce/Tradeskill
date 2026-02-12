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
    public class FreelancerRepository : RepositoryBase<Freelancer>, IFreelancerRepository
    {
        private readonly ApplicationDbContext _context;
        public FreelancerRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override List<Freelancer> GetAll()
        {
           return _context.Freelancers.Include(f => f.Services).Include(f => f.Skills).ToList();
        }

        public override Freelancer? GetById(int id)
        {
            return _context.Freelancers.Include(f => f.Services).Include(f => f.Skills).FirstOrDefault(f => f.Id == id);
        }
    }
}
