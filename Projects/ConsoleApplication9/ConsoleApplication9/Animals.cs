using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Animals
    {
        private string type;
        private string color;
        private string weight;
        private string height;
        private int age;
        int numOfLegs;

        public int Age
        {
            get { return this.age; }
            set
            { 
            if (value < 0)
            {

            }
            }

        }

        public void move()
        {
            Console.WriteLine("moved");
        }

        public void makeNoise()
        {

        }
    }

}
