using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User Create(CreationUserDto creationUserDto)
        {
            if (string.IsNullOrWhiteSpace(creationUserDto.FirstName) ||
               string.IsNullOrWhiteSpace(creationUserDto.LastName) ||
               string.IsNullOrWhiteSpace(creationUserDto.Email) ||
               string.IsNullOrWhiteSpace(creationUserDto.Password))
            { throw new ValidationException("Todos los campos son requeridos / All fields are required"); }
            if (!creationUserDto.Email.Contains("@"))
            {
                throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var newUser = new User
            {
                FirstName = creationUserDto.FirstName,
                LastName = creationUserDto.LastName,
                Email = creationUserDto.Email,
                Password = creationUserDto.Password
            };
            return _userRepository.create(newUser);
        }

        public void Delete(int id)
        {
            var userToDelete = _userRepository.GetById(id);
            if (userToDelete != null)
            { 
                throw new NotFoundException($"El usuario con id {id} no se encontro / User with id {id} not found");
            }
            _userRepository.Delete(userToDelete);
        }

        public List<UserDto> GetAll()
        {
            var users = _userRepository.GetAll();
            if (users == null || users.Count == 0)
            {
                throw new NotFoundException("No se encontraron usuarios / No users found");
            }
            var usersDtos = UserDto.fromEntityList(users);
            return usersDtos;
        }

        public UserDto GetById(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            { 
                throw new NotFoundException($"El usuario con id {id} no se encontro / User with id {id} not found");
            }
            var userDto = UserDto.fromEntity(user);
            return userDto;
        }

        public void update(int id, CreationUserDto creationUserDto)
        {
            if (string.IsNullOrWhiteSpace(creationUserDto.FirstName) ||
              string.IsNullOrWhiteSpace(creationUserDto.LastName) ||
              string.IsNullOrWhiteSpace(creationUserDto.Email) ||
              string.IsNullOrWhiteSpace(creationUserDto.Password))
            { throw new ValidationException("Todos los campos son requeridos / All fields are required"); }
            if (!creationUserDto.Email.Contains("@"))
            {
                throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var userToUpdate = _userRepository.GetById(id);
            if (userToUpdate == null)
            {
                throw new NotFoundException($"El usuario con id {id} no se encontro / User with id {id} not found");
            }
            userToUpdate.FirstName = creationUserDto.FirstName;
            userToUpdate.LastName = creationUserDto.LastName;
            userToUpdate.Email = creationUserDto.Email;
            userToUpdate.Password = creationUserDto.Password;
            userToUpdate.LastUpdate = DateTime.Now;
            _userRepository.Update(userToUpdate);
        }
    }
}
