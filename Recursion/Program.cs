using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Method Started");
            fun1(4);
            Console.WriteLine("Main Method Finish");

        }

        static void fun1(int x) { Console.WriteLine(x); }
    }
}
