
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int WorkPerformedHandler(int hoursOfWork, WorkType workType);

    public class Worker
    {
       
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;


        public void DoWork(int hours, WorkType workType)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(hours + 1, workType);
            }

            OnWorkCompleted();
        }


        protected virtual void OnWorkPerformed(int hours,WorkType workType)
        {
            /* *** Raise an event version 1 *** */

            //if (WorkPerformed!=null)
            //{
            //    WorkPerformed(hours + 1, workType);
            //}

            /* *** Raise an event version 2 *** */

            var del = WorkPerformed as WorkPerformedHandler;
            if (del!=null)
            {
                del(hours + 1, workType);
            }
          
        }

        protected virtual void OnWorkCompleted()
        {
            /* *** Raise an event version 1 *** */
            //if (WorkCompleted!=null)
            //{
            //    WorkCompleted(this, EventArgs.Empty);
            //}

            /* *** Raise an event handler version 2 *** */
            var del = WorkCompleted as EventHandler;
            if (del!=null)
            {
                del(this, EventArgs.Empty);
            }



        }
    }
}
