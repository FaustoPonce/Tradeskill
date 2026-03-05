using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public List<int> ServicesIds { get; set; } = new List<int>();
        public List<string> Services { get; set; } = new List<string>();

        public static CategoryDto FromEntity(Category category)
        {
            if (category == null) return null;
            CategoryDto categoryDto = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                IconUrl = category.IconUrl,
           
            };
            if (category.Services != null)
            {
                foreach (var service in category.Services) 
                { 
                    categoryDto.ServicesIds.Add(service.Id);
                    var serviceDto = ServiceDto.FromEntity(service);
                    if (serviceDto != null)
                    {
                        categoryDto.Services.Add(service.Title);
                    }

                }
            }
            return categoryDto;
        }

        public static List<CategoryDto> FromEntityList(List<Category> categories)
        {
            var categoryDtos = new List<CategoryDto>();
            foreach (var category in categories)
            {
                categoryDtos.Add(FromEntity(category));
            }
            return categoryDtos;
        }
    }
}
