using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Adding(5, 7);
            Console.ReadLine();
        }



        static void Adding(int first, int last)
        {
            int answer = first + last;
            Console.WriteLine(answer);
        }
        
    }
}
