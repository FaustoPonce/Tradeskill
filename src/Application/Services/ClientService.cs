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
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client Create(CreationClientDto creationClientDto)
        {
            if (string.IsNullOrWhiteSpace(creationClientDto.FirstName) ||
                string.IsNullOrWhiteSpace(creationClientDto.LastName) ||
                string.IsNullOrWhiteSpace(creationClientDto.Email) ||
                string.IsNullOrWhiteSpace(creationClientDto.Password) ||
                string.IsNullOrWhiteSpace(creationClientDto.PhoneNumber)) 
            { 
             throw new ValidationException("Todos los campos son requeridos / All fields are required");
            }
            if (!creationClientDto.Email.Contains("@"))
            {
                throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var newClient = new Client
            {
                FirstName = creationClientDto.FirstName,
                LastName = creationClientDto.LastName,
                Email = creationClientDto.Email,
                Password = creationClientDto.Password,
                PhoneNumber = creationClientDto.PhoneNumber
            };
            return _clientRepository.create(newClient);
        }

        public void Delete(int id)
        {
            var clientToDelete = _clientRepository.GetById(id);
            if (clientToDelete != null)
            {
                throw new NotFoundException($"El cliente con id {id} no se encontro / Client with id {id} not found");
            }
            _clientRepository.Delete(clientToDelete);
        }

        public List<ClientDto> GetAll()
        {
            var clients = _clientRepository.GetAll();
            if (clients == null || clients.Count == 0)
            {
                throw new NotFoundException("No se encontraron clientes / No clients found");
            }
            var clientsDtos = ClientDto.fromEntityList(clients);
            return clientsDtos;
        }

        public ClientDto GetById(int id)
        {
            var client = _clientRepository.GetById(id);
            if (client == null)
            {
                throw new NotFoundException($"El cliente con id {id} no se encontro / Client with id {id} not found");
            }
            var clientDto = ClientDto.fromEntity(client);
            return clientDto;   
        }

        public void update(int id, CreationClientDto creationClientDto)
        {
            if (string.IsNullOrWhiteSpace(creationClientDto.FirstName) ||
                string.IsNullOrWhiteSpace(creationClientDto.LastName) ||
                string.IsNullOrWhiteSpace(creationClientDto.Email) ||
                string.IsNullOrWhiteSpace(creationClientDto.Password) ||
                string.IsNullOrWhiteSpace(creationClientDto.PhoneNumber))
            {
                throw new ValidationException("Todos los campos son requeridos / All fields are required");
            }
            if (!creationClientDto.Email.Contains("@"))
            {
                throw new ValidationException("El correo electrónico no es válido / The email is not valid");
            }
            var clientToUpdate = _clientRepository.GetById(id);
            if (clientToUpdate == null) 
            {
                throw new NotFoundException($"no existe un cliente con id {id} / client with id {id} not found");
            }
            clientToUpdate.FirstName = creationClientDto.FirstName;
            clientToUpdate.LastName = creationClientDto.LastName;
            clientToUpdate.Email = creationClientDto.Email;
            clientToUpdate.Password = creationClientDto.Password;
            clientToUpdate.PhoneNumber = creationClientDto.PhoneNumber;
            clientToUpdate.LastUpdate = DateTime.Now;
            _clientRepository.Update(clientToUpdate);
        }
    }
}
