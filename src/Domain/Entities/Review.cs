using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public Order Order { get; set; }
    }
}
