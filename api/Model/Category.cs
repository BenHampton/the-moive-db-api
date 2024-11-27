using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Category
    {
        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        public List<Movie> Movies { get; set; } = new List<Movie>{};
    }
}