using System;

namespace ProgrammingBasicExam
{
	class Cinema
	{
		static void Main(string[] args)
		{
			string typeOfPrjection = Console.ReadLine().ToLower();
			double rows = double.Parse(Console.ReadLine());
			double columns = double.Parse(Console.ReadLine());

			double price = 0;

			if (typeOfPrjection == "premiere")
			{
				price = 12;
			}
			else if (typeOfPrjection == "normal")
			{
				price = 7.5;
			}
			else if (typeOfPrjection == "discount")
			{
				price = 5;
			}

			Console.WriteLine("{0:f2} leva", price * rows * columns);
		}
	}
}

