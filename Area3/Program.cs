using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();

            Console.WriteLine("circle area is:" + s.area(5));
            Console.WriteLine("Rectangle area is:" + s.area(5f, 5f));
            Console.WriteLine("Triangle area is:" + s.area(7m, 6m));


            Console.ReadLine();
        }
        public class Shape
        {
            public float area(float r)
            {
                return 3.14f * r * r;
            }
            public float area(float l, float w)
            {
                return l * w;
            }
            public decimal area(decimal b, decimal h)
            {
                return 0.5m * b * h;
            }
        }
    }
}
      
