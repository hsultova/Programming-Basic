using System;

namespace CodingExam
{
	class TransportPrice
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string type = Console.ReadLine().ToLower();

			double taxi = double.MaxValue;
			double bus = double.MaxValue;
			double train = double.MaxValue;

			if (n >= 20)
			{
				bus = n * 0.09;
				if (n >= 100)
				{
					train = n * 0.06;
				}
			}

			if (type == "day")
			{
				taxi = 0.7 + n * 0.79;
			}
			else if (type == "night")
			{
				taxi = 0.7 + n * 0.9;
			}

			double result = Math.Min(Math.Min(bus, train), taxi);

			Console.WriteLine(result);
		}
	}
}