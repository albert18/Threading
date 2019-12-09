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
            Thread thread = new Thread(HelloWorld);

            thread.Start();

            HelloWorld();






        }

        private static void HelloWorld()
        {
            lock (lockCompleted)
            {
                if (!isCompleted)
                    {
                        isCompleted = true;
                        System.Console.WriteLine("Hello World!!");    
                    }
            }
        }
    }
}
