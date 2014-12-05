using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
//TODO: Здесь надо продумать побольше. Возможно вынести Name и Description в отдельную таблу и просто потом делать наподобие связи многие ко многим только + значене Value

   public class Properties
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public int RecordId { get; set; }
        protected Record Record { get; set; }

    }
}
