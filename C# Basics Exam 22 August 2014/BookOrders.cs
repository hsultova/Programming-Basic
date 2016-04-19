using System;

namespace ProgrammingBasicExam
{
	class BookOrders
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			int allBoughtBooks = 0;
			decimal priceAllBooks = 0;

			for (int i = 0; i < n; i++)
			{
				int numberOfPackets = int.Parse(Console.ReadLine());
				int booksPerPacket = int.Parse(Console.ReadLine());
				decimal bookPrice = decimal.Parse(Console.ReadLine());

				if (numberOfPackets >= 10 && numberOfPackets <= 19)
				{
					bookPrice *= 0.95m;
				}
				else if (numberOfPackets >= 20 && numberOfPackets <= 29)
				{
					bookPrice *= 0.94m;
				}
				else if (numberOfPackets >= 30 && numberOfPackets <= 39)
				{
					bookPrice *= 0.93m;
				}
				else if (numberOfPackets >= 40 && numberOfPackets <= 49)
				{
					bookPrice *= 0.92m;
				}
				else if (numberOfPackets >= 50 && numberOfPackets <= 59)
				{
					bookPrice *= 0.91m;
				}
				else if (numberOfPackets >= 60 && numberOfPackets <= 69)
				{
					bookPrice *= 0.9m;
				}
				else if (numberOfPackets >= 70 && numberOfPackets <= 79)
				{
					bookPrice *= 0.89m;
				}
				else if (numberOfPackets >= 80 && numberOfPackets <= 89)
				{
					bookPrice *= 0.88m;
				}
				else if (numberOfPackets >= 90 && numberOfPackets <= 99)
				{
					bookPrice *= 0.87m;
				}
				else if (numberOfPackets >= 100 && numberOfPackets <= 109)
				{
					bookPrice *= 0.86m;
				}
				else if(numberOfPackets >= 110)
				{
					bookPrice *= 0.85m;
				}

				allBoughtBooks += numberOfPackets * booksPerPacket;
				priceAllBooks += bookPrice * numberOfPackets * booksPerPacket;
			}

			Console.WriteLine(allBoughtBooks);
			Console.WriteLine("{0:f2}", priceAllBooks);
		}
	}
}