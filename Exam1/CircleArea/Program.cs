using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int radius = random.Next(33, 187);
            Console.WriteLine("The circle random radius is {0}", radius);

            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The circle area = {0:0.00}", area);

        }
    }
}
