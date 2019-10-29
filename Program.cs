using System;

namespace Opdracht_1
{
	class Program
	{
		static void Main(string[] args)
		{
			string naam;

			Console.WriteLine("Geef uw naam: ");

			naam = Console.ReadLine();

			Console.WriteLine("Geef uw leeftijd: ");

			string leeftijd = Console.ReadLine();

			Console.WriteLine("Uw naam is " + naam);
			Console.WriteLine("Uw leeftijd is " + leeftijd);

			Console.ReadLine(); 
		}
	}
}
