using System;
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

    public delegate void WorkPerformedHandler(int hoursOfWork, WorkType workType);


    class Program
    {

        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(MethodName1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(MethodName2);


            /* ***  Execution of the delegate is hardcoded *** */

            //del1(10, WorkType.GenerateReports);
            //del2(15, WorkType.Golf);


            /* *** This how to execute a delegate dynamically *** */
            DoWork(MethodName1);
            DoWork(MethodName2);

            Console.ReadLine();

        }


        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.GotoMovies);
        }


        private static void MethodName1(int hours, WorkType work)
        {
            Console.WriteLine("MethodName1 appealed "+hours.ToString());
        }

        private static void MethodName2(int hours,WorkType work)
        {
            Console.WriteLine("MethodName2 appealed "+ hours.ToString());
        }
    }
}
