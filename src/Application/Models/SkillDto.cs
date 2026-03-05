using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class SkillDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> FreelancersIds { get; set; } = new List<int>();
        public List<string> Freelancers { get; set; } = new List<string>();

        public static SkillDto FromEntity(Skill skill)
        {
            if (skill == null) return null;
            var skillDto = new SkillDto
            {
                Id = skill.Id,
                Name = skill.Name,
            };
            if (skill.Freelancers != null)
            {
                foreach (var freelancer in skill.Freelancers)
                {
                    skillDto.FreelancersIds.Add(freelancer.Id);
                    var freelancerDto = FreelancerDto.FromEntity(freelancer);
                    if (freelancerDto != null)
                    {
                        skillDto.Freelancers.Add(freelancer.FirstName + " " + freelancer.LastName);
                    }
                }
            }
            return skillDto;
        }

    }
}
