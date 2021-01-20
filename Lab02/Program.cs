using System;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = GetNumber("Enter a number");
            decimal num2 = GetNumber("Enter a second number");
            decimal answer = SubtractNumber(num1, num2);
            PrintNumber(answer);
        }


        private static decimal GetNumber(string messege)
        {
            Console.WriteLine(messege);
            decimal input = int.Parse(Console.ReadLine());
            return input;
        }

        private static void PrintNumber(decimal answer)
        {
            Console.WriteLine($"Your subtracted number is {answer}");
        }

        public static decimal SubtractNumber(decimal num1, decimal num2)
        {
            decimal answer = num1 + num2;
            return answer;
        }
        //private static decimal GetFirstNumber()
        //{
        //    Console.WriteLine("Enter a second number");
        //    decimal num2 = int.Parse(Console.ReadLine());
        //    return num2;
        //}
        //private static decimal GetSecondNumber()
        //{
        //    Console.WriteLine("Enter a number");
        //    decimal num1 = int.Parse(Console.ReadLine());
        //    return num1;
        //}
    }
}
