﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public enum WorkType
    {
        GotoMovies,
        Golf,
        GenerateReports
    }

   


    class Program
    {
        //public static EventHandler<EventArgs> Worker_WorkCompleted { get; private set; }

        static void Main(string[] args)
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(MethodName1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(MethodName2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(MethodName3);


            /* ***  Execution of the delegate is hardcoded *** */

            //del1(10, WorkType.GenerateReports);
            //del2(15, WorkType.Golf);


            /* *** This how to execute a delegate dynamically *** */
            //DoWork(MethodName1);
            //DoWork(MethodName2);


            /* *** Invocation of the multicast delegate version 1*** */
            //del1 += del2;
            //del1 += del3;
            //del1(20, WorkType.Golf);

            /* *** Invocation of the multicast delegate version 2*** */
            //del1 += del2 + del3;
            //int final=del1(30, WorkType.GotoMovies);

            //Console.WriteLine("The final result is "+final);

            Worker worker = new Worker();

            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            //worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);

            /* *** Wiring up events with Delegate Inference *** */
            //worker.WorkPerformed += Worker_WorkPerformed1; // wiring up an event to an event handler with Delegate Inference
            //worker.WorkCompleted += Worker_WorkCompleted1; // wiring up an event to an event handler with Delegate Inference

            //worker.WorkCompleted -= Worker_WorkCompleted; // un-wiring up an event 

            /* *** Wiring up events with Anonymous Methods *** */
            worker.WorkPerformed += delegate (object sender, WorkPerformedEventArgs e)
             {
                 Console.WriteLine("Hours worked :" + e.Hours + " " + e.WorkType);
             };

            worker.WorkCompleted += delegate (object sender, EventArgs e)
              {
                  Console.WriteLine("I have completed");
              };

            worker.DoWork(8, WorkType.GenerateReports);

            Console.ReadLine();

        }

        //private static void Worker_WorkCompleted1(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void Worker_WorkPerformed1(object sender, WorkPerformedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked :"+ e.Hours +" "+e.WorkType);
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work is completed");
        }


        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GotoMovies);
        //}


        //private static int MethodName1(int hours, WorkType work)
        //{
        //    Console.WriteLine("MethodName1 appealed "+hours.ToString());
        //    return hours + 10;
        //}

        //private static int MethodName2(int hours,WorkType work)
        //{
        //    Console.WriteLine("MethodName2 appealed "+ hours.ToString());
        //    return hours + 20;
        //}

        //private static int MethodName3(int hours,WorkType workType)
        //{
        //    Console.WriteLine("MethodName3 appealed "+ hours);
        //    return hours + 30;
        //}
    }
}
