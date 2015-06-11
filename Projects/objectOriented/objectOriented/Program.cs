using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal Dog = new Animal();
            //Dog.Age = 12;
            //Console.WriteLine(Dog.Age);
            //Console.ReadLine();

            Dog Spot = new Dog();
            Spot.Age = 12;
            Spot.move();
            Spot.makeNoise();
        }
    }
}
