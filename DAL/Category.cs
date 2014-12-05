using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Category
    {
        public int id { get; set; }
        public string NameCategory { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        protected Category Category { get; set; }
    }
}
