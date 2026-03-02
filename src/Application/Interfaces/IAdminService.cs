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
    public interface IAdminService
    {
        Admin Create(CreationAdminDto creationAdminDto);

        void update(int id, CreationAdminDto creationAdminDto);
        void Delete(int id);
        AdminDto GetById(int id);
        List<AdminDto> GetAll();

    }
}
