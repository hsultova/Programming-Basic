using System;

namespace ProgrammingBasicExam
{
	class FruitMarket
	{
		static void Main(string[] args)
		{
			string day = Console.ReadLine().ToLower();
			double quantity1 = double.Parse(Console.ReadLine());
			string product1 = Console.ReadLine().ToLower();
			double quantity2 = double.Parse(Console.ReadLine());
			string product2 = Console.ReadLine().ToLower();
			double quantity3 = double.Parse(Console.ReadLine());
			string product3 = Console.ReadLine().ToLower();

			double totalPrice = GetPrice(product1, quantity1, day) + GetPrice(product2, quantity2, day) + GetPrice(product3, quantity3, day);
			Console.WriteLine("{0:f2}", totalPrice);
		}

		static double GetPrice(string product, double quantity, string day)
		{
			double price = 0;
			double banana = 1.8;
			double cucumber = 2.75;
			double tomato = 3.2;
			double orange = 1.60;
			double apple = 0.86;

			if (day == "friday")
			{
				banana *= 0.9;
				cucumber *= 0.9;
				tomato *= 0.9;
				orange *= 0.9;
				apple *= 0.9;
			}
			else if (day == "sunday")
			{
				banana *= 0.95;
				cucumber *= 0.95;
				tomato *= 0.95;
				orange *= 0.95;
				apple *= 0.95;
			}
			else if (day == "tuesday")
			{
				banana *= 0.8;
				orange *= 0.8;
				apple *= 0.8;
				//tomato *= 0.8;
			}
			else if (day == "wednesday")
			{
				cucumber *= 0.9;
				tomato *= 0.9;
			}
			else if (day == "thursday")
			{
				banana *= 0.7;
			}

			if (product == "banana")
			{
				price = quantity * banana;
			}
			else if (product == "cucumber")
			{
				price = quantity * cucumber;
			}
			else if (product == "tomato")
			{
				price = quantity * tomato;
			}
			else if (product == "orange")
			{
				price = quantity * orange;
			}
			else if (product == "apple")
			{
				price = quantity * apple;
			}
			return price;
		}
	}
}
