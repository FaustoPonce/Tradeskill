using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DeliveryTimeInDays { get; set; }
        public int FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
