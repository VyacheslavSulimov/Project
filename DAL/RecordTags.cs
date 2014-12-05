using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class RecordTags
    {
        public int RecordId { get; set; }
        protected Record Record { get; set; }
        public int TagId { get; set; }
        protected Tags Tags { get; set; }
    }
}
