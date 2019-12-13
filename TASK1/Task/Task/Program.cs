using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            

        }
    }
}



//class Program------------------------------------------Task with continuation
//Task<string> antecedent = Task.Run(() =>

//DateTime.Today.ToShortTimeString());
//Task<string> continuation = antecedent.ContinueWith(x => "Today is " + antecedent.Result);
//Console.WriteLine(continuation.Result);



//class Program------------------------------------------Task with I/O
//{
//    static void Main(string[] args)
//    {
//        Task<string> task = Task.Factory.StartNew<string>(() => GetPosts("https://jsonplaceholder.typicode.com/posts"));

//        SomethingElse();
//        task.Wait();

//        try
//        {
//            Console.WriteLine(task.Result);
//        }
//        catch (AggregateException ex)
//        {

//            Console.WriteLine(ex.Message);
//        }



//    }

//    private static void SomethingElse()
//    {
//        //Dummy
//    }

//    private static string GetPosts(string url)
//    {
//        using (var client = new System.Net.WebClient())
//        {
//            return client.DownloadString(url);
//        }
//    }

//}






//static void Main(string[] args)
//{
//    Task task = new Task(SimpleMethod);

//    task.Start();

//    Task<string> taskThatReturn = new Task<string>(MethodThatReturn);
//    taskThatReturn.Start();
//    taskThatReturn.Wait();
//    Console.WriteLine(taskThatReturn.Result);

//}

//private static string MethodThatReturn()
//{
//    Thread.Sleep(2000);
//    return "Hello";
//}

//private static void SimpleMethod()
//{
//    //System.Diagnostics.Debug.WriteLine("THIS IS A TEST!!");

//    Console.WriteLine("Hellow World");
//}