using System;
using System.Threading;
using System.Threading.Tasks;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {   

            Task task = new Task(SimpleMethod);
            
            task.Start();

            
        }

        private static void SimpleMethod()
        {
            System.Console.WriteLine("Hello World");
        }
    }
}



// Exercise 2 ----------------------------------------------------------------------------------------------------------------------- TASKS







































// Exercise 1 -----------------------------------------------------------------------------------------------------------------------
// private static void Demo()
// {
//     try
//     {
//         Execute();
//     }
//     catch (Exception ex)
//     {
//         System.Console.WriteLine(ex.Message);
        
//     }
// }

// private static void Execute()
// {
//     throw null;
// }


// Other Thread
// static void Main(string[] args)
// {   
//     Thread thread = new Thread(PrintHellowWorld);
//     thread.Start();
//     thread.Join();
//     System.Diagnostics.Debug.WriteLine("Hello World Printed");

//     // System.Console.WriteLine("Hello World Printed");


    
// }

// private static void PrintHellowWorld()
// {
//     System.Diagnostics.Debug.WriteLine("Hello World");
//     // System.Console.WriteLine("Hello World");
//     Thread.Sleep(5000);
// }

