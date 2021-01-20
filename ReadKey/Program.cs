using System;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoReadKey();
        }

        private static void DemoReadKey()
        {

            //Att skriva true i Console readKey gör att man inte ser vilken knapp man trycker i under sin console.writeline. 
            //Alltså när man skriver ut tex hmm nedan.
            bool done = false;
            while (!done)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {

                    case ConsoleKey.A:
                        Console.WriteLine("Du tryckte A");
                        done = true;
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("Du tryckte B");
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine("Du tryckte c");
                        break;
                    case ConsoleKey.D1:
                        Console.WriteLine("Du tryckte 1");
                        break;

                    default:
                        Console.WriteLine("Du tryckte någon annan tangent än a,b,c!");
                        break;
                }
            }
        }
    }
}
