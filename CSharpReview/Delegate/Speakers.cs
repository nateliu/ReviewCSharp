using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.Common
{
    public class ChineseSpeaker
    {
        public static void Greeting(string name)
        {
            Console.WriteLine(string.Format("你好，{0}", name));
        }
    }

    public class EnglishSpeaker
    {
        public static void Greeting(string name)
        {
            Console.WriteLine(string.Format("Hello,{0}", name));
        }
    }

}
