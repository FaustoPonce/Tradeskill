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
    public interface ICategoryService
    {
        Category Create(CreationCategoryDto creationCategoryDto);

        void update(int id, CreationCategoryDto creationCategoryDto);
        void Delete(int id);
        CategoryDto GetById(int id);
        List<CategoryDto> GetAll();
    }
}
