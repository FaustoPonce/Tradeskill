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
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public override List<Order> GetAll()
        {
            return _context.Orders
                .Include(o => o.Client)
                .Include(o => o.Service)
                .Include(o => o.Review)
                .ToList();
        }
        public override Order? GetById(int Id)
        {
            return _context.Orders
                .Include(o => o.Client)
                .Include(o => o.Service)
                .Include(o => o.Review)
                .FirstOrDefault(o => o.Id == Id);
        }
    }
}
