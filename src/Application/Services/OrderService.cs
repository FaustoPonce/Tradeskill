using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrderService : IOrderService
    {
        public Order Create(CreationOrderDto creationOrderDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, CreationOrderDto CreationOrderDto)
        {
            throw new NotImplementedException();
        }
    }
}
