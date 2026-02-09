using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public OrderState State { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Client Client { get; set; }
        public Service Service { get; set; }
        public Review Review { get; set; }

    }
}
