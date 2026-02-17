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
    public interface IFreelancerService
    {
        Freelancer Create(CreationFreelancerDto creationFreelancerDto);

        void update(int id, CreationFreelancerDto creationFreelancerDto);
        void Delete(int id);
        FreelancerDto GetById(int id);
        List<FreelancerDto> GetAll();
    }
}
