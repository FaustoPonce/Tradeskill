using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public string phoneNumber { get; set; }

        public static ClientDto fromEntity(Client client)
        { 
         var clientDto = new ClientDto
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                Password = client.Password,
                CreatedDate = client.CreatedDate,
                LastUpdate = client.LastUpdate,
                phoneNumber = client.PhoneNumber
            };
            return clientDto;
        }

        public static List<ClientDto> fromEntityList(List<Client> clients)
        {
            var clientDtos = new List<ClientDto>();
            foreach (var client in clients)
            {
                clientDtos.Add(fromEntity(client));
            }
            return clientDtos;
        }
    }
}
