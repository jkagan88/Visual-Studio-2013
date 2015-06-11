using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Honda = new Car();
            Honda.make = "Honda";
            Honda.model = "Civic";
            Honda.color = "White";
            Honda.Start();
            Honda.Stop();

        }
    }
}
