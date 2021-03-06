﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.OOP
{
    /// <summary>
    /// be more and more carefully the keyword of override. this keyword will cut the root tree.
    /// and be carefull the keyword of virtual in the base class.
    /// </summary>
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ClassA a = new ClassD();
    //        ClassB b = new ClassD();
    //        ClassC c = new ClassD();
    //        ClassD d = new ClassD();

    //        a.XXX();
    //        b.XXX();
    //        c.XXX();
    //        d.XXX();

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
        public override void XXX()
        {
            Console.WriteLine("ClassB XXX");
        }
    }

    public class ClassC : ClassB
    {
        public virtual new void XXX()
        {
            Console.WriteLine("ClassC XXX");
        }
    }

    public class ClassD : ClassC
    {
        public override void XXX()
        {
            Console.WriteLine("ClassD XXX");
        }
    }
}
