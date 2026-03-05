using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string State { get; set; }
        public string PaymentMethod { get; set; }
        public string ClientName { get; set; }
        public string ServiceTitle { get; set; }
        public string ReviewComment { get; set; }

        public static OrderDto fromEntity(Order order)
        {
            if (order == null) return null;
            var orderDto = new OrderDto
            {
                Id = order.Id,
                ClientId = order.ClientId,
                ServiceId = order.ServiceId,
                CreatedDate = order.CreatedDate,
                TotalAmount = order.TotalAmount,
                State = order.State.ToString(),
                PaymentMethod = order.PaymentMethod.ToString(),
                ClientName = order.Client.FirstName + " " + order.Client.LastName,
                ServiceTitle = order.Service.Title,
                ReviewComment = order.Review != null ? order.Review.Comment : null
            };
            return orderDto;
        }
    }
}
