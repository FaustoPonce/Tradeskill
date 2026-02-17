using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IOrderService
    {
        Order Create(CreationOrderDto creationOrderDto);

        void update(int id, CreationOrderDto CreationOrderDto);
        void Delete(int id);
        OrderDto GetById(int id);
        List<OrderDto> GetAll();
    }
}
