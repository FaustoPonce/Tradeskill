using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class CreationReviewDto
    {
        public int OrderId { get; set; }
        public int rating { get; set; }
        public string Comment { get; set; }
    }
}
