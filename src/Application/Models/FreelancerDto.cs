using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class FreelancerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string PortfolioUrl { get; set; }
        public decimal AverageRating { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public List<int> ServiceIds { get; set; }
        public List<string> ServiceTitles { get; set; }
        public List<int> skillsIds { get; set; }
        public List<string> skillsNames { get; set; }

        public static FreelancerDto fromEntity(Freelancer freelancer)
        {
            if (freelancer == null) return null;
            var freelancerDto = new FreelancerDto
            {
                Id = freelancer.Id,
                FirstName = freelancer.FirstName,
                LastName = freelancer.LastName,
                Email = freelancer.Email,
                Bio = freelancer.Bio,
                PortfolioUrl = freelancer.PortfolioUrl,
                AverageRating = freelancer.AverageRating,
                CreatedDate = freelancer.CreatedDate,
                UpdatedDate = freelancer.LastUpdate,
            };
            if (freelancer.Services != null)
            {
                foreach (var service in freelancer.Services)
                {
                    freelancerDto.ServiceIds.Add(service.Id);
                    freelancerDto.ServiceTitles.Add(service.Title);
                }
            }
            if (freelancer.Skills != null)
            {
                foreach (var skill in freelancer.Skills)
                {
                    freelancerDto.skillsIds.Add(skill.Id);
                    freelancerDto.skillsNames.Add(skill.Name);
                }
            }
            return freelancerDto;
        }

        public static List<FreelancerDto> fromEntityList(List<Freelancer> freelancers)
        {
            var freelancerDtos = new List<FreelancerDto>();
            foreach (var freelancer in freelancers)
            {
                freelancerDtos.Add(fromEntity(freelancer));
            }
            return freelancerDtos;
        }

    }

}
