using System;

namespace ProgrammingBasicExam
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			string element1 = line.Split('\\')[0];
			string element2 = line.Split('\\')[1];
			string command = line.Split('\\')[2].ToLower();

			string result = "";

			if (command == "join")
			{
				result = JoinElements(element1, element2);
			}
			else if (command == "right exclude")
			{
				result = RightExclude(element1, element2);
			}
			else if (command == "left exclude")
			{
				result = LeftExclude(element1, element2);
			}

			char[] resultArray = result.ToCharArray();
			Array.Sort(resultArray);

			Console.WriteLine(resultArray);
		}


		static string JoinElements(string element1, string element2)
		{
			string joinedElement = "";

			for (int i = 0; i < element1.Length; i++)
			{
				for (int j = 0; j < element2.Length; j++)
				{
					if (element1[i] == element2[j])
					{
						joinedElement += element1[i];
					}
				}
			}

			return joinedElement;
		}


		static string LeftExclude(string element1, string element2)
		{
			string joinedElements = JoinElements(element1, element2);
			string leftExcludeElement = "";

			for (int i = 0; i < element2.Length; i++)
			{
				if (!joinedElements.Contains(element2[i].ToString()))
				{
					leftExcludeElement += element2[i];
				}
			}

			return leftExcludeElement;
		}


		static string RightExclude(string element1, string element2)
		{
			string joinedElements = JoinElements(element1, element2);
			string rightExcludeElement = "";

			for (int i = 0; i < element1.Length; i++)
			{
				if (!joinedElements.Contains(element1[i].ToString()))
				{
					rightExcludeElement += element1[i];
				}
			}

			return rightExcludeElement;
		}
	}
}
