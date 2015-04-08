using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadFolder
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(string.Format("Without parameter, CurrentId {0} is begin.", Thread.CurrentThread.ManagedThreadId));
    //        ThreadPool.QueueUserWorkItem(x => new Message().ShowMessage());
    //        Console.WriteLine(string.Format("Without parameter, CurrentId {0} end.", Thread.CurrentThread.ManagedThreadId));

    //        Console.WriteLine(string.Format("With parameter, CurrentId {0} is begin.", Thread.CurrentThread.ManagedThreadId));
    //        ThreadPool.QueueUserWorkItem(new WaitCallback(new Message().ShowMessage), new Person() { Name = "Nate", Age = 33 });
    //        Console.WriteLine(string.Format("With parameter, CurrentId {0} end.", Thread.CurrentThread.ManagedThreadId));

    //        Console.ReadLine();//must have this statement,otherwise will exit immediately because ThreadPool are create backgroud thread.
    //    }
    
    //}
}
