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

   


    class Program
    {

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
            

            Console.ReadLine();

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
