using System;

namespace ProgrammingBasic
{
	class ProspectInHospitality
	{
		static void Main(string[] args)
		{
			var builders = uint.Parse(Console.ReadLine());
			var receptionists = uint.Parse(Console.ReadLine());
			var chambermaids = uint.Parse(Console.ReadLine());
			var technicians = uint.Parse(Console.ReadLine());
			var other = uint.Parse(Console.ReadLine());
			var nikiSalary = decimal.Parse(Console.ReadLine());
			var usaRate = decimal.Parse(Console.ReadLine());
			var salary = decimal.Parse(Console.ReadLine());
			var budget = decimal.Parse(Console.ReadLine());

			decimal amount = 0;
			amount = builders * 1500.04m + receptionists * 2102.10m + chambermaids * 1465.46m + technicians * 2053.33m + other * 3010.98m + nikiSalary * usaRate + salary;

			Console.WriteLine("The amount is: {0:f2} lv.", amount);
			
			if (budget < amount)
			{
				Console.WriteLine("NO \\ Need more: {0:f2} lv.", amount - budget);
			}
			else
			{
				Console.WriteLine("YES \\ Left: {0:f2} lv.", budget - amount);
			}
		}
	}
}