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
    public interface IUserService
    {
        User Create(CreationUserDto creationUserDto);

        void update(int id, CreationUserDto creationUserDto);
        void Delete(int id);
        UserDto GetById(int id);
        List<UserDto> GetAll();
    }
}
