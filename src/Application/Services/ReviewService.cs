using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReviewService : IReviewService
    {
        public Review Create(CreationReviewDto creationReviewDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReviewDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, CreationReviewDto creationReviewDto)
        {
            throw new NotImplementedException();
        }
    }
}
