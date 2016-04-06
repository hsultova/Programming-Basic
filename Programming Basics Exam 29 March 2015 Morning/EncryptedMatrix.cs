using System;

namespace ProgrammingBasicExam
{
	class EncryptedMatrix
	{
		static void Main(string[] args)
		{
			string message = Console.ReadLine();
			char direction = char.Parse(Console.ReadLine());

			string messageToNumber = "";
			string convertedNumber = "";

			for (int i = 0; i < message.Length; i++)
			{
				int digit = Convert.ToInt32(message[i]) % 10;
				messageToNumber += digit;
			}

			for (int i = 0; i < messageToNumber.Length; i++)
			{
				int digit = int.Parse(messageToNumber[i].ToString());
				if (digit % 2 == 0 || digit == 0)
				{
					convertedNumber += digit * digit;
				}
				else
				{
					if (i == 0 && messageToNumber.Length != 1)
					{
						convertedNumber += (digit + int.Parse(messageToNumber[i + 1].ToString()));
					}
					else if (i == messageToNumber.Length - 1 && messageToNumber.Length != 1)
					{
						convertedNumber += (digit + int.Parse(messageToNumber[i - 1].ToString()));
					}
					else if (messageToNumber.Length == 1)
					{
						convertedNumber += digit;
					}
					else
					{
						convertedNumber += (digit + int.Parse(messageToNumber[i - 1].ToString()) + int.Parse(messageToNumber[i + 1].ToString()));
					}
				}
			}

			string left = "";
			string mid = "";
			string right = "";
			char[] line;
			for (int i = 0; i < convertedNumber.Length; i++)
			{
				if (direction == '\\')
				{
					left = new string('0', i);
					mid = convertedNumber[i].ToString();
					right = new string('0', convertedNumber.Length - i - 1);
				}
				else if (direction == '/')
				{
					left = new string('0', convertedNumber.Length - i - 1);
					mid = convertedNumber[convertedNumber.Length - i - 1].ToString();
					right = new string('0', i);
				}

				line = (left + mid + right).ToCharArray();
				for (int j = 0; j < line.Length; j++)
				{
					Console.Write(line[j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
