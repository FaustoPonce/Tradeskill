using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Freelancer : User
    {
        public string Bio { get; set; }
        public string PortfolioUrl { get; set; }
        public decimal AverageRating { get; set; }
        public ICollection<Service> Services { get; set; } = new List<Service>();
        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

    }
}
