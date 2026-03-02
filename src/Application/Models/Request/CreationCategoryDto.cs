using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class CreationCategoryDto
    {
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public List<int>? ServiceIds { get; set; } = new List<int>();
    }
}
