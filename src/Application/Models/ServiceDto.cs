using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DeliveryTimeInDays { get; set; }
        public int FreelancerId { get; set; }
        public string Freelancer { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }

        public static ServiceDto FromEntity(Service service)
        {
            if (service == null) return null;
            var serviceDto = new ServiceDto();
            serviceDto.Id = service.Id;
            serviceDto.Title = service.Title;
            serviceDto.Description = service.Description;
            serviceDto.Price = service.Price;
            serviceDto.DeliveryTimeInDays = service.DeliveryTimeInDays;
            serviceDto.FreelancerId = service.FreelancerId;
            if (service.Freelancer != null)
            {
                serviceDto.Freelancer = service.Freelancer.FirstName + " " + service.Freelancer.LastName;
            }
            serviceDto.CategoryId = service.CategoryId;
            if (service.Category != null)
            {
                serviceDto.Category = service.Category.Name;
            }
            return serviceDto;
        }

        public static List<ServiceDto> FromEntityList(List<Service> services)
        {
            var serviceDtos = new List<ServiceDto>();
            foreach (var service in services)
            {
                serviceDtos.Add(FromEntity(service));
            }
            return serviceDtos;
        }
    }
}

