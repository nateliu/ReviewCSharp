using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadFolder
{
    public delegate string HelloMessage();

    public delegate string ObjctHelloMessage(object @object);

    public class Message
    {
        public void ShowMessage()
        {
            string message = string.Format("Async threadId is :{0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(message);

            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(300);
                Console.WriteLine("Without parameter the number is:" + n.ToString());
            }
        }

        public void ShowMessage(object person)
        {
            if (null != person)
            {
                Person p = (Person)person;
                string message = string.Format("Async threadId is:{0},\n{1}'s age is {2}!\n", Thread.CurrentThread.ManagedThreadId, p.Name, p.Age);
                Console.WriteLine(message);
            }

            for (int n = 0; n < 10; n++)
            {
                Thread.Sleep(300);
                Console.WriteLine("With parameter the number is:" + n.ToString());
            }
        }

        public string HelloMessage()
        {
            string message = string.Format("Hello, Async threadId is :{0}", Thread.CurrentThread.ManagedThreadId);
            return message;
        }

        public string HelloMessage(object person)
        {
            if (null != person)
            {
                Person p = (Person)person;
                string message = string.Format("Async threadId is:{0},\n{1}'s age is {2}!\n", Thread.CurrentThread.ManagedThreadId, p.Name, p.Age);
                return message;
            }

            return "Empty object";
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
