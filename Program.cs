using System;
using System.Threading;

namespace coreConsole
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
        
        
    }

}


#region ThreadPool
    //         public static void Main(string[] args)
    //     {
    //         System.Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

    //         Employee employee = new Employee();
    //         employee.Name = "Albert";
    //         employee.CompanyName = "SomeWhere";

    //         ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployee), employee);

    //         var processorCount = Environment.ProcessorCount;
    //         ThreadPool.SetMaxThreads(20,30);
    //         int workerThreads = 0;
    //         int completionPortThreads = 0;
    //         ThreadPool.GetAvailableThreads(out workerThreads, out completionPortThreads);

    //         System.Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

            
    //     }

    //     private static void DisplayEmployee(object employee)
    //     {
    //         System.Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
    //         Employee emp = employee as Employee;
    //         System.Console.WriteLine("Person Name is {0} and the company name {1}", emp.Name, emp.CompanyName);
    //     } 
    // }

    // class Employee
    // {
    //     public string Name { get; set; }
    //     public string CompanyName { get; set; }
    // }

#endregion


// private static bool isCompleted;

// static readonly object lockCompleted = new object();

// static void Main(string[] args)
// {   
//     #region 1
//     // Thread thread = new Thread(HelloWorld);

//     // thread.Start();

//     // HelloWorld();                


//     // new Thread(PrintOneToThirty).Start();

//     // PrintOneToThirty();
//     #endregion

// }

// #region 1
// // private static void HelloWorld()
// // {
// //     lock (lockCompleted)
// //     {
// //         if (!isCompleted)
// //             {
// //                 isCompleted = true;
// //                 System.Console.WriteLine("Hello World!!");    
// //             }
// //     }
// // }    

// // private static void PrintOneToThirty()
// // {
// //     for (int i = 0; i < 30; i++)
// //     {
// //         System.Console.WriteLine(i + 1 + " ");
// //     }
// // }
// #endregion