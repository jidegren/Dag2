using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vänligen fyll i ange temperaturen i Svedala och Jukkasjervi(tex såhär:25 20):");
            string input = Console.ReadLine();
            string [] splitTemperatures = input.Split(' ');
            double[] temperatures = new double[splitTemperatures.Length];

            Console.WriteLine($"Temperaturen i Svedala är {splitTemperatures[0]} och temperaturen i Jukkasjervi är {splitTemperatures[1]}");
            Console.ReadLine();

            for (int i = 0; i < splitTemperatures.Length; i++)
            {
                temperatures[i] = double.Parse(splitTemperatures[i]);
            }



            if (temperatures[0] < temperatures[1])
            {
                Console.WriteLine("Det är kallare i Svedala");
            }
            else if (temperatures[1] < temperatures[0])
            {
                Console.WriteLine("Det är gallare i Jukkasjervi");
            }
            else
            {
                Console.WriteLine("Det är lika temperatur i Svedala och Jukkasjervi");
            }




        }
    }
}
