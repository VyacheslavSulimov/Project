using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
   public interface IScheduler
    {
      void SetDateTime(DateTime Time);
      void UpdateDateTime(DateTime OldTime, DateTime NewTime);
      void DeleteDateTime(DateTime Time);
      List<DateTime> GetTimes();
      void Scheduler();
    }
}
