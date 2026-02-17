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
    public interface IServiceService
    {
        Service Create(CreationServiceDto creationServiceDto);

        void update(int id, CreationServiceDto creationServiceDto);
        void Delete(int id);
        ServiceDto GetById(int id);
        List<ServiceDto> GetAll();
    }
}
