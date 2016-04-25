using System;

namespace ProgrammingBasicExam
{
	class Nacepin
	{
		static void Main(string[] args)
		{
			decimal priceUS = decimal.Parse(Console.ReadLine()) / 0.58m;
			uint weightUS = uint.Parse(Console.ReadLine());
			decimal priceUK = decimal.Parse(Console.ReadLine()) / 0.41m;
			uint weightUK = uint.Parse(Console.ReadLine());
			decimal priceChinese = decimal.Parse(Console.ReadLine()) * 0.27m;
			uint weightChinese = uint.Parse(Console.ReadLine());

			decimal storeUS = priceUS / weightUS;
			decimal storeUK = priceUK / weightUK;
			decimal storeChinese = priceChinese / weightChinese;

			decimal lowestPrice = Math.Min(Math.Min(storeUK, storeUS), storeChinese);
			decimal highestPrice = Math.Max(Math.Max(storeUK, storeUS), storeChinese);

			if (lowestPrice == storeUS)
			{
				Console.WriteLine("US store. {0:f2} lv/kg", storeUS);
			}
			else if (lowestPrice == storeUK)
			{
				Console.WriteLine("UK store. {0:f2} lv/kg", storeUK);
			}
			else if (lowestPrice == storeChinese)
			{
				Console.WriteLine("Chinese store. {0:f2} lv/kg", storeChinese);
			}

			Console.WriteLine("Difference {0:f2} lv/kg", highestPrice - lowestPrice);
		}
	}
}