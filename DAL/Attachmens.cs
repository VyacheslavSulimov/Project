using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Attachmens
    {
        public int id { get; set; }
        public int RecordId { get; set; }
        public Record Record { get; set; }
        public string FilePath { get; set; }
        public bool? IsActiveFile { get; set; }
    }
}
