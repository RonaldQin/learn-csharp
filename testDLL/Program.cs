using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myDLL;

namespace testDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            string s = c.Hello();
            Console.WriteLine(s);
        }
    }
}
