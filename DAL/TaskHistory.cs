using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaskHistory
    {
        public int id { get; set; }
        public DateTime StartDate { get; set; }
        public int recordGets { get; set; }
        public int recordAdded { get; set; }
        public int DateOfWeek { get; set; }

    }
}
