using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReviewService
    {
        Review Create(CreationReviewDto creationReviewDto);

        void update(int id, CreationReviewDto creationReviewDto);
        void Delete(int id);
        ReviewDto GetById(int id);
        List<ReviewDto> GetAll();
    }
}
