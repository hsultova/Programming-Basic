using System;

namespace ProgrammingasBasic
{
	class TheBetterMusicProducer
	{
		static void Main(string[] args)
		{
			var numberAlbumsEurope = uint.Parse(Console.ReadLine());
			var priceEuro = decimal.Parse(Console.ReadLine());
			var numberAlbumsNorthAmerica = uint.Parse(Console.ReadLine());
			var priceDollar = decimal.Parse(Console.ReadLine());
			var numberAlbumsSouthAmerica = uint.Parse(Console.ReadLine());
			var pricePesos = decimal.Parse(Console.ReadLine());
			var numberConcerts = uint.Parse(Console.ReadLine());
			var profitEuro = decimal.Parse(Console.ReadLine());

			decimal allAlbums = numberAlbumsEurope * priceEuro * 1.94m + numberAlbumsSouthAmerica * pricePesos / 332.74m + numberAlbumsNorthAmerica * priceDollar * 1.72m;

			allAlbums -= 0.35m * allAlbums;
			allAlbums -= 0.2m * allAlbums;

			decimal concertProfit = numberConcerts * profitEuro * 1.94m;
			
			if (concertProfit > 100000)
			{
				concertProfit -= 0.15m * concertProfit;
			}

			if (concertProfit >= allAlbums)
			{
				Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", concertProfit);
			}
			else
			{
				Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", allAlbums);
			}
		}
	}
}