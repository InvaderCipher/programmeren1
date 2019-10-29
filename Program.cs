using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int getal1 = rnd.Next(101, 10000);
            int getal2 = rnd.Next(101, 10000);
            int getal3 = rnd.Next(101, 10000);
            int getal4 = rnd.Next(101, 10000);

            Console.WriteLine(getal1);
            Console.WriteLine(getal2);
            Console.WriteLine(getal3);
            Console.WriteLine(getal4);

            Console.WriteLine("Tel deze getallen bij elkaar op");
            Console.Write("Geef uw antwoord: "); 
            string invoer = Console.ReadLine();

            int gegevenantwoord = int.Parse(invoer);

            int antwoord = getal1 + getal2 + getal3 + getal4;

            if (gegevenantwoord == antwoord)
            {
                Console.WriteLine("Yaaaaay");

            }

            else 
            {
                Console.WriteLine("jammer");

            }

            Console.ReadKey(); 
        }
    }
}
