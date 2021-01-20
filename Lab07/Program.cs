using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] orter = { "Göteborg", "Stockholm", "Malmö" };

            Console.WriteLine($"Hur många grader celcius är det i {orter[0]}");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine($"Hur många grader celcius är det i {orter[1]}");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine($"Hur många grader celcius är det i {orter[2]}");
            double third = double.Parse(Console.ReadLine());

            double average = 

            double[] tempratures = { first, second, third };

            if (tempratures.Max() == first)
            {
                Console.WriteLine($"Det är varmast i {orter[0]} och medeltemepraturen är {avarage});
            }
            else if (tempratures.Max() == second)
            {

            }
            else
            {

            }
        }
    }
}
