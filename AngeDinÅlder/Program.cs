using System;

namespace AngeDinÅlder
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = GetInt("Ange din ålder");
            Console.WriteLine($"Du angav åldern {age}");
        }

        private static int GetInt(string messege)
        {
            bool convertOK;
            int number;
            do
            {
                Console.Write($"{messege}: ");
                string input = Console.ReadLine();
                convertOK = int.TryParse(input, out number);
            } while (!convertOK);
            return number;
        }
    }
}
