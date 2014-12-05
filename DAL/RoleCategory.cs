using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class RoleCategory
    {
        public int RoleId { get; set; }
        protected  Roles Role { get; set; }
        public int CategoryId { get; set; }
        protected  Category Categoty { get; set; }
    }
}
