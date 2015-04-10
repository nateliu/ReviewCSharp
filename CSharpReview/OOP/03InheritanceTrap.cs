using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.OOP.Trap
{
    //public class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        ClassA a = new ClassB();
    //        a.XXX();
    //        Console.ReadLine();
    //    }
    //}

    public class ClassA
    {
        public virtual void XXX()
        {
            Console.WriteLine("ClassA XXX");
        }
    }

    public class ClassB : ClassA
    {
        /// <summary>
        /// this wil occured a exceiption of 'Cannot evaluate expression because the current thread is in a stack overflow state.'
        /// the root cause is the keyword of override, as I mentioned in 02RuntimePolymorphism.cs the override cut the root tree at all.
        /// In this kind of case, no casting will stop the infinite loop. 
        /// Therefore even though this is being cast to a class ClassA, 
        /// it will always call XXX from class ClassB and not ClassA. So we get no output.
        /// remove the overrdie keyword or change the keyword from override to new, then will output ClassA XXX.
        /// </summary>
        public override void XXX()
        {
            ((ClassA)this).XXX();
            Console.WriteLine("ClassB XXX");
        }
    }   
}
