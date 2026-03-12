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
    public class FreelancerService : IFreelancerService
    {
        public Freelancer Create(CreationFreelancerDto creationFreelancerDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FreelancerDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public FreelancerDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, CreationFreelancerDto creationFreelancerDto)
        {
            throw new NotImplementedException();
        }
    }
}
