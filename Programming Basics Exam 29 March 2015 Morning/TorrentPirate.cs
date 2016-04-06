using System;

namespace ProgrammingBasicExam
{
	class TorrentPirate
	{
		static void Main(string[] args)
		{
			int data = int.Parse(Console.ReadLine());
			int price = int.Parse(Console.ReadLine());
			int wifeSpending = int.Parse(Console.ReadLine());

			double downloadTime = data / 2.0 / 60 / 60;
			double priceDownload = downloadTime * wifeSpending;
			double numberOfMovies = data / 1500.0;
			double priceCinema = numberOfMovies * price;

			if (priceDownload <= priceCinema)
			{
				Console.WriteLine("mall -> {0:f2}lv", priceDownload);
			}
			else
			{
				Console.WriteLine("cinema -> {0:f2}lv", priceCinema);
			}		
		}
	}
}
