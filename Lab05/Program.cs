using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is Arsenal the best fotballteam in the world?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "ja")
            {
                Console.WriteLine("Helt rätt!");
            }
        }
    }
}
