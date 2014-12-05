using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Record
    {
        public int id { get; set; }
        public string NameRecord { get; set; }
        public string Description { get; set; }
        public string ThumbnailPath { get; set; }
        public int CategoryId { get; set; }
        protected Category Category { get; set; }
        public int UserId { get; set; }
        protected User User { get; set; }
        public bool? IsActive { get; set; }
    }
}
