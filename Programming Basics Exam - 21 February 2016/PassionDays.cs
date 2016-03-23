using System;

namespace ProgrammingExercises
{
	class PassionDays
	{
		static void Main(string[] args)
		{
			decimal money = decimal.Parse(Console.ReadLine());
			decimal moneySpent = 0;
			int countPurchase = 0;

			string line = Console.ReadLine();

			if (line == "mall.Enter")
			{
				do
				{
					string purchases = Console.ReadLine();
					if (purchases == "mall.Exit")
					{
						break;
					}

					for (int i = 0; i < purchases.Length; i++)
					{
						int purchasesCode = Convert.ToInt32(purchases[i]);
						if (purchasesCode > 64 && purchasesCode < 91)
						{
							moneySpent = purchasesCode * 0.5m;
							if (money < moneySpent)
							{
								break;
							}

							money -= moneySpent;
							countPurchase++;
						}
						else if (purchasesCode > 96 && purchasesCode < 123)
						{
							moneySpent = purchasesCode * 0.3m;
							if (money < moneySpent)
							{
								break;
							}

							money -= moneySpent;
							countPurchase++;
						}
						else if (purchases[i] == '%')
						{
							moneySpent = money / 2;
							if (money < moneySpent)
							{
								break;
							}

							money -= moneySpent;
							countPurchase++;
						}
						else if (purchases[i] == '*')
						{
							money += 10;
						}
						else
						{
							moneySpent += purchasesCode;
							if (money < moneySpent)
							{
								break;
							}

							money -= moneySpent;
							countPurchase++;
						}
					}
				}
				while (true);
			}

			if (countPurchase == 0)
			{
				Console.WriteLine("No purchases. Money left: {1:f2} lv.", countPurchase, money);

			}
			else {
				Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", countPurchase, money);
			}

		}
	}
}