using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingBasicExam
{
	class VehiclePark
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');
			var vehicles = new List<string>();

			foreach (string item in input)
			{
				vehicles.Add(item);
			}

			int allVehiclesNumber = vehicles.Count;

			string line = Console.ReadLine();
			while (line != "End of customers!")
			{
				string[] tokens = line.ToLower().Split(' ');
				string vehicle = tokens[0][0] + tokens[2];
				if (vehicles.Contains(vehicle))
				{
					vehicles.Remove(vehicle);
					Console.WriteLine("Yes, sold for {0}$", CalcPrice(vehicle));
				}
				else
				{
					Console.WriteLine("No");
				}
				line = Console.ReadLine();
			}

			Console.WriteLine("Vehicles left: {0}", String.Join(", ", vehicles));
			Console.WriteLine("Vehicles sold: {0}", allVehiclesNumber - vehicles.Count);
		}

		static double CalcPrice(string vehicle)
		{
			double price = Convert.ToInt32(vehicle[0]) * int.Parse(vehicle.Substring(1));
			return price;
		}
	}
}