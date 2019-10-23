
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Worker
    {
        public delegate int WorkPerformedHandler(int hoursOfWork, WorkType workType);

        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;


        public  void DoWork(int hours, WorkType workTypw)
        {

        }

    }
}
