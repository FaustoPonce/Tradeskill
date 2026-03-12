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
    public class CategoryService : ICategoryService
    {
        public Category Create(CreationCategoryDto creationCategoryDto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void update(int id, CreationCategoryDto creationCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
