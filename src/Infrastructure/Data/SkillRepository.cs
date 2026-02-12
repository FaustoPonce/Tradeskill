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
    public class SkillRepository : RepositoryBase<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext _context;

        public SkillRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public override List<Skill> GetAll()
        {
            return _context.Skills.Include(s => s.Freelancers).ToList();
        }
    }
}
