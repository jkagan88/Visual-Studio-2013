using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonReturningFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = Concatinate;
            Console.WriteLine(Concatinate(" BOO ", "yeah"));
            Console.ReadLine();
        }

       
        static string Concatinate(string first, string last)
        {
            string whole = first + last;
            return whole;
        }
       
    

      
    }
}
