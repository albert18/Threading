using System;
using System.Threading;

namespace coreConsole
{
    //Thread


    class Program
    {
        private static bool isCompleted;

        static readonly object lockCompleted = new object();

        static void Main(string[] args)
        {   
            #region 1
            // Thread thread = new Thread(HelloWorld);

            // thread.Start();

            // HelloWorld();                


            // new Thread(PrintOneToThirty).Start();

            // PrintOneToThirty();
            #endregion

 

        }




        #region 1
        // private static void HelloWorld()
        // {
        //     lock (lockCompleted)
        //     {
        //         if (!isCompleted)
        //             {
        //                 isCompleted = true;
        //                 System.Console.WriteLine("Hello World!!");    
        //             }
        //     }
        // }    

        // private static void PrintOneToThirty()
        // {
        //     for (int i = 0; i < 30; i++)
        //     {
        //         System.Console.WriteLine(i + 1 + " ");
        //     }
        // }
        #endregion

    }
}
