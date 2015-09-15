using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.Windbg
{
    /// <summary>
    /// this was from http://www.cnblogs.com/developersupport/p/4212102.html
    /// how to use Windbg, then can refer here http://www.cnblogs.com/happyhippy/archive/2007/04/08/710933.html    
    /// http://www.cnblogs.com/springyangwc/archive/2011/11/15/2249887.html
    /// http://blogs.msdn.com/b/tess/archive/2008/02/04/net-debugging-demos-information-and-setup-instructions.aspx
    /// </summary>
    public class VSString
    {
        //static void Main(string[] args)
        //{
        //    Comparation();
        //}
       
        private static void Comparation()
        {
            string a = "Test String";
            string b = "Test String";
            string c = a;
            string d = "aa";

            Console.WriteLine("a vs b : " + object.ReferenceEquals(a, b));
            Console.WriteLine("a vs c : " + object.ReferenceEquals(a, c));

            SimpleObject smp1 = new SimpleObject(a);
            SimpleObject smp2 = new SimpleObject(a);

            Console.WriteLine("smp1 vs smp2 : " + object.ReferenceEquals(smp1, smp2));
            Console.ReadLine();

        }

        class SimpleObject
        {
            public string name = string.Empty;

            public SimpleObject(string name)
            {
                this.name = name;
            }
        }
    }
}
