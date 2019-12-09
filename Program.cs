using System;
using System.Threading;

namespace coreConsole
{
    //Thread


    class Program
    {
        private static bool isCompleted;

        static void Main(string[] args)
        {   
            Thread thread = new Thread(HelloWorld);

            thread.Start();

            HelloWorld();






        }

        private static void HelloWorld()
        {
            
            if (!isCompleted)
            {
                System.Console.WriteLine("Hello World!!");    
                isCompleted = true;
            }
            
        }
    }
}
