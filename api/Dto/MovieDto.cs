using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;        
    }
}