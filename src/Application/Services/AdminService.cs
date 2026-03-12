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
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public Admin Create(CreationAdminDto creationAdminDto)
        {
            if (string.IsNullOrWhiteSpace(creationAdminDto.FirstName) ||
                string.IsNullOrWhiteSpace(creationAdminDto.LastName) ||
                string.IsNullOrWhiteSpace(creationAdminDto.Email) ||
                string.IsNullOrWhiteSpace(creationAdminDto.Password))
            {   throw new ValidationException("Todos los campos son requeridos / All fields are required"); }
            if (!creationAdminDto.Email.Contains("@")) 
            { 
                throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var newadmin = new Admin
            {
                FirstName = creationAdminDto.FirstName,
                LastName = creationAdminDto.LastName,
                Email = creationAdminDto.Email,
                Password = creationAdminDto.Password
            };
            return _adminRepository.create(newadmin);
        }

        public void Delete(int id)
        {
            var adminToDelete = _adminRepository.GetById(id);
            if (adminToDelete == null)
            {
                throw new NotFoundException($"El Admin con id {id} no se encontro / Admin with id {id} not found");
            }
            _adminRepository.Delete(adminToDelete);
        }

        public List<AdminDto> GetAll()
        {
            var admins = _adminRepository.GetAll();
            if (admins == null || admins.Count == 0)
            {
                throw new NotFoundException("No se encontraron Admins / No Admins found");
            }
            var adminDtos = AdminDto.FromEntityList(admins);
            return adminDtos;
        }

        public AdminDto GetById(int id)
        {
            var admin = _adminRepository.GetById(id);
            if (admin == null)
            {
                throw new NotFoundException($"El Admin con id {id} no se encontro / Admin with id {id} not found");
            }
            var adminDto = AdminDto.Fromentity(admin);
            return adminDto;
        }

        public void update(int id, CreationAdminDto creationAdminDto)
        {
            if (string.IsNullOrWhiteSpace(creationAdminDto.FirstName) ||
                string.IsNullOrWhiteSpace(creationAdminDto.LastName) ||
                string.IsNullOrWhiteSpace(creationAdminDto.Email) ||
                string.IsNullOrWhiteSpace(creationAdminDto.Password))
            { throw new ValidationException("Todos los campos son requeridos / All fields are required"); }
                if (!creationAdminDto.Email.Contains("@"))
                {
                    throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var adminToUpdate = _adminRepository.GetById(id);
            if (adminToUpdate == null)
            {
                throw new NotFoundException($"El Admin con id {id} no se encontro / Admin with id {id} not found");
            }
            adminToUpdate.FirstName = creationAdminDto.FirstName;
            adminToUpdate.LastName = creationAdminDto.LastName;
            adminToUpdate.Email = creationAdminDto.Email;
            adminToUpdate.Password = creationAdminDto.Password;
            adminToUpdate.LastUpdate = DateTime.Now;
            _adminRepository.Update(adminToUpdate);

        }
    }
}
