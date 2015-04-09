using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.OOP
{
    class OverloadingEarlyBindingCompilePolymorphism
    {
        public void Display()
        {
            DisplayOverload(200);
            DisplayOverload(200, 300);
            DisplayOverload(200, 300, 500, 600);
        }

        private void DisplayOverload(int x, int y)
        {
            Console.WriteLine("The two integers " + x + " " + y);
        }

        private void DisplayOverload(params int[] parameterArray)
        {
            Console.WriteLine("parameterArray");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        OverloadingEarlyBindingCompilePolymorphism obc = new OverloadingEarlyBindingCompilePolymorphism();
    //        obc.Display();
    //        Console.ReadLine();
    //    }
    //}
}
