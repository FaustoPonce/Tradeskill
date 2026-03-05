using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AdminDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? LastLogin { get; set; }

        public static AdminDto Fromentity(Admin admin) 
        { 
            if (admin == null) return null;
            AdminDto adminDto = new AdminDto 
            { 
                Id = admin.Id,
                Firstname = admin.FirstName,
                Lastname = admin.LastName,
                Email = admin.Email,
                Password = admin.Password,
                CreatedDate = admin.CreatedDate,
                UpdatedDate = admin.LastUpdate,
                LastLogin = admin.lastLogin

            };
            return adminDto;
        }

        public static List<AdminDto> FromEntityList(List<Admin> admins)
        {
            var adminDtos = new List<AdminDto>();
            foreach (var admin in admins)
            {
                adminDtos.Add(Fromentity(admin));
            }
            return adminDtos;
        }
    }
}
