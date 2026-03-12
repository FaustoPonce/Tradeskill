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
    public class ServiceService : IServiceService
    {
        public Service Create(CreationServiceDto creationServiceDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ServiceDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ServiceDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, CreationServiceDto creationServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
