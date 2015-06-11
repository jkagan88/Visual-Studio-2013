using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorldProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string str = Console.ReadLine();
            Console.WriteLine("Why hello there {0}", str);



            Console.ReadLine();
        }
    }
}
