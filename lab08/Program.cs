using System;
using System.Collections.Generic;
using System.Linq;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa lista med tre orter
            //För varje ort i listan, fråga om temperatur
            //Räkna ut lägsta temp och använd den för att hitta ort med lägsta temp
            //Räkna ut högsta temp och använd den för att hitta ort med högsta  temp
            //Räkna ut medelvärdet på orterna

            List<Ort> orter = new List<Ort>();
            orter.Add (new Ort("Göteborg"));
            orter.Add(new Ort("Stockholm"));
            orter.Add(new Ort("Malmö"));
            //Ort ort = new Ort();
            //Console.WriteLine("Skriv in en stad");
            //ort.Name = Console.ReadLine();
            //orter.Add(ort);
            

            foreach (var ort in orter)
            {
                Console.WriteLine($"Skriv temperaturen i {ort.Name}");
                var temp = int.Parse(Console.ReadLine());
                ort.Temp = temp;
            }

            int lowestTemp = orter.Min(x => x.Temp);
            List<Ort> citysWithLowestTemp = orter.Where(x => x.Temp == lowestTemp).ToList();

            int highestTemp = orter.Max(x => x.Temp);
            List<Ort> citysWithHighestTemp = orter.Where(x => x.Temp == highestTemp).ToList();

            double averageTemp = orter.Average(x => x.Temp);

            if (citysWithHighestTemp.Count == 1)
            {
                Console.WriteLine($"The hottest city is {citysWithHighestTemp.First().Name}");
            }
            else
            {

            Console.WriteLine("There are at least two citys with the hottest temp, here they are:");
            foreach (var item in citysWithHighestTemp)
            {
                Console.WriteLine(item.Name);
            }
            }

            if (citysWithLowestTemp.Count == 1)
            {
                Console.WriteLine($"The coldest city is {citysWithLowestTemp.First().Name}");
            }
            else
            {
            Console.WriteLine("There are at least two citys with the coldest temp, here they are:");
            foreach (var item in citysWithLowestTemp)
            {
                Console.WriteLine(item.Name);
            }

            }

            Console.WriteLine($"Here is the average temp in all the citys {averageTemp}");









            //FirstSolution();





            //Fråga efter temepraturen i 3 städer

            //Berätta var det är kallast

            //Berätta var det är varmast

            //Berätta vad medeltemperaturen är
        }

        //private static void FirstSolution()
        //{
        //    List<Ort> orter = new List<Ort>();
        //    orter.Add(new Ort("Svedala"));
        //    orter.Add(new Ort("Jukkasjärvi"));
        //    orter.Add(new Ort("Visby"));

        //    foreach (var ort in orter)
        //    {
        //        Console.WriteLine($"Vad är temperaturen i {ort.Name}:");
        //        int input = int.Parse(Console.ReadLine());
        //        ort.Temp = input;
        //    }

        //    int lowestTemp = orter.Min(x => x.Temp); //Tar fram lägsta temperaturen
        //    Ort ortWithLowestTemp = orter.Where(x => x.Temp == lowestTemp).First(); //Här jämför vi vilken ort som har den lägsta temperaturen

        //    int higestTemp = orter.Max(x => x.Temp);
        //    Ort ortWithHigestTemp = orter.Where(x => x.Temp == higestTemp).First();

        //    double avarageTemp = orter.Average(x => x.Temp);

        //    Console.WriteLine($"The lowest temp is in {ortWithLowestTemp.Name} and the temp is {ortWithLowestTemp.Temp}");
        //    Console.WriteLine($"The highest temp is in {ortWithHigestTemp.Name} and the temp is {ortWithHigestTemp.Temp}");
        //    Console.WriteLine($"The avvarage temp in all places is {avarageTemp}");
        //}
    }
}
