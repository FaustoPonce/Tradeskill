using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class CreationFreelancerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Bio { get; set; }
        public string? PortfolioUrl { get; set; }
        public List<int> ServicesIds { get; set; } = new List<int>();
        public List<int> SkillsIds { get; set; } = new List<int>();
    }
}
