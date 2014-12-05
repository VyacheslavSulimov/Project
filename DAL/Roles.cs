using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Roles
    {
        public int id { get; set; }
        public string RoleName { get; set; }
        public int UnternalDownload { get; set; }
        public int InternalDownload { get; set; }
        public bool IsSolveDownload { get; set; }

    }
}
