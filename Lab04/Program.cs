using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal");
            double dec = double.Parse(Console.ReadLine());
            int wholenumber = (int)Math.Round(dec, MidpointRounding.AwayFromZero);
            Console.WriteLine(wholenumber);
          
        }

        
        
    }
}
