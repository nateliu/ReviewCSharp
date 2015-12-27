using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.Windbg
{
    public class StayStringPool
    {
        //static void Main(string[] args)
        //{
        //    int i = 0;
        //    while (true)
        //    {
        //        SimpleString(i++);

        //        Console.WriteLine(i + " : Run GC.Collect()");
        //        GC.Collect();
        //        Console.ReadLine();
        //    }
        //}

        private static void SimpleString(int i)
        {
            string s = "SimpleString method ";
            string c = "Concat String";

            Console.WriteLine(s + c);
            Console.WriteLine(s + i.ToString());
            Console.ReadLine();
        }
    }
}
