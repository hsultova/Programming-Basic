using System;

namespace ProgrammingExercises
{
	class HungryGarfield
	{
		static void Main(string[] args)
		{
			var money = decimal.Parse(Console.ReadLine());
			var rate = decimal.Parse(Console.ReadLine());
			var pizzaPrice = decimal.Parse(Console.ReadLine());
			var lasagnaPrice = decimal.Parse(Console.ReadLine());
			var sandwichPrice = decimal.Parse(Console.ReadLine());
			var pizzaQuantity = uint.Parse(Console.ReadLine());
			var lasagnaQuantity = uint.Parse(Console.ReadLine());
			var sandwichQuantity = uint.Parse(Console.ReadLine());

			var moneyNedeed = pizzaPrice / rate * pizzaQuantity + lasagnaPrice / rate * lasagnaQuantity + sandwichPrice / rate * sandwichQuantity;

			if (money >= moneyNedeed)
			{
				Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", money - moneyNedeed);
			}
			else
			{
				Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", moneyNedeed - money);
			}
		}
	}
}