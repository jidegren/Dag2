using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num1 = GetNumber("Enter a number");
            decimal num2 = GetNumber("Enter a second number");
            decimal num3 = GetNumber("Enter a third number");
            SubtractNumber(num1, num2, num3);
            AverageNumber();
            PrintSubtractedNumber();
            PrintAverageNumber();
        }


        private static decimal GetNumber(string messege)
        {
            Console.WriteLine(messege);
            decimal input = Int32.Parse(Console.ReadLine());
            return input;
        }
        public static decimal SubtractNumber(decimal num1, decimal num2, decimal num3)
        {
            decimal subtractedAnswer = num1 + num2 + num3;
            return subtractedAnswer;
        }
        private static void AverageNumber()
        {
            throw new NotImplementedException();
        }
        private static decimal PrintSubtractedNumber(decimal subtractedAnswer)
        {
            throw new NotImplementedException();
        }
        private static decimal PrintAverageNumber(decimal answer)
        {
            throw new NotImplementedException();
        }


    }
}
