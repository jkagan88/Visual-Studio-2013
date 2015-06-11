using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1978;
            myNewCar.Color = "Silver";

            Console.WriteLine("{0} - {1} - {2} - {3}",
                myNewCar.Make, myNewCar.Model, myNewCar.Year, myNewCar.Color);

          
            Console.ReadLine();
        }
        private static double detrmineMarketValue(Car car);
        double carValue = 100.0;

        return carValue;
    }
    class Car
    
    {
        private string Make {get; set; }
        public string  Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


    }
    
}
