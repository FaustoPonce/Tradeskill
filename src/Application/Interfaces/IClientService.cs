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
    public interface IClientService
    {
        Client Create(CreationClientDto creationClientDto);

        void update(int id, CreationClientDto creationClientDto);
        void Delete(int id);
        ClientDto GetById(int id);
        List<ClientDto> GetAll();
    }
}
