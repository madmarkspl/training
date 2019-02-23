using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //float a = 1.0f;
            //float b = 3.0f;
            //float c = a / b;
            //double d = b * c;
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
            Console.ReadKey();
        }
    }
}
