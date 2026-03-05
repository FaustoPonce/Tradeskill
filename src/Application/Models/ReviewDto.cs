using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ReviewDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public string client { get; set; }

        public static ReviewDto fromEntity(Review review)
        {
            if (review == null) return null;
            var reviewDto = new ReviewDto
            {
                Id = review.Id,
                OrderId = review.OrderId,
                rating = review.rating,
                Comment = review.Comment,
                CreatedDate = review.CreatedDate,
                client = review.Order.Client.FirstName + " " + review.Order.Client.LastName
            };
            return reviewDto;

        }
        public static List<ReviewDto> fromEntityList(List<Review> reviews)
            {
                var reviewDtos = new List<ReviewDto>();
                foreach (var review in reviews)
                {
                    reviewDtos.Add(fromEntity(review));
                }
                return reviewDtos;
        }
    }
}
