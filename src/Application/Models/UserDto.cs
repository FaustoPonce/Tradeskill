using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdate { get; set; }

        public static UserDto fromEntity(User user)
        {
            if (user == null) return null;
            var userDto = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                CreatedDate = user.CreatedDate,
                LastUpdate = user.LastUpdate
            };
            return userDto;
        }
        
        public static List<UserDto> fromEntityList(List<User> users)
        {
            var userDtos = new List<UserDto>();
            foreach (var user in users)
            {
                userDtos.Add(fromEntity(user));
            }
            return userDtos;
        }
    }
}
