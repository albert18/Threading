using System;
using System.Threading;

namespace coreConsole
{
    //Thread


    class Program
    {
        static void Main(string[] args)
        {
            
            Thread thread = new Thread(WriteNewThread);
               thread.Start();

            //Main Thread
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(" A" + i);
            }

            
        }

        private static void WriteNewThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                System.Console.WriteLine(" Z" + i);
            }
        }
    }
}
