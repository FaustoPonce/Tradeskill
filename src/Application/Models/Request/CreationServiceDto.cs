using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class CreationServiceDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DeliveryTimeInDays { get; set; }
        public int FreelancerId { get; set; }
        public int CategoryId { get; set; }
    }
}
