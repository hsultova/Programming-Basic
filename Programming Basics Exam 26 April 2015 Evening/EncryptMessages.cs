using System;

namespace ProgrammingBasicExam
{
	class EncryptMessages
	{
		static void Main(string[] args)
		{
			string line;
			string encryptedMessage = "";
			int countMessages = 0;

			do
			{
				line = Console.ReadLine().ToLower();
			}
			while (line != "start");

			do
			{
				line = Console.ReadLine();

				if (line.ToLower() == "end")
				{
					break;
				}

				for (int i = line.Length - 1; i >= 0; i--)
				{
					encryptedMessage += ConvertLetter(line[i]);
				}

				if (line != "")
				{
					countMessages++;
					encryptedMessage += "\n";
				}
			}
			while (true);

			if (countMessages == 0)
			{
				Console.WriteLine("No messages sent.");
			}
			else
			{
				Console.WriteLine("Total number of messages: {0}", countMessages);
				Console.WriteLine(encryptedMessage);
			}
		}


		static char ConvertLetter(char letter)
		{
			char convertedLetter;
			int code = Convert.ToInt32(letter);

			if ((code >= 65 && code <= 77) || (code >= 97 && code <= 109)) // Convert 'A-M' -> 'N-Z' || 'a-m' -> 'n-z'
			{
				code += 13;
			}
			else if ((code >= 78 && code <= 90) || (code >= 110 && code <= 122)) // Convert 'N-Z' -> 'A-M' || 'n-z' -> 'a-m'
			{
				code -= 13;
			}
			else if (code == 32) // Convert ' ' -> '+'
			{
				code = 43;
			}
			else if (code == 44) // Convert ',' -> '%'
			{
				code = 37;
			}
			else if (code == 46) // Convert '.' -> '&'
			{
				code = 38;
			}
			else if (code == 63) // Convert '?' -> '#'
			{
				code = 35;
			}
			else if (code == 33) // Convert '!' -> '$'
			{
				code = 36;
			}

			convertedLetter = Convert.ToChar(code);
			return convertedLetter;
		}
	}
}
