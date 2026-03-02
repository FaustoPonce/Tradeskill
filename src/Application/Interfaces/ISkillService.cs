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
    public interface ISkillService
    {
        Skill Create(CreationSkillDto creationSkillDto);

        void update(int id, CreationSkillDto creationSkillDto);
        void Delete(int id);
        SkillDto GetById(int id);
        List<SkillDto> GetAll();
    }
}
