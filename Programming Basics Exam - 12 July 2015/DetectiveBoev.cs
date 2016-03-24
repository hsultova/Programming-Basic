using System;
using System.Collections.Generic;

namespace ProgrammingBasic
{
	class  DetectiveBoev
	{
		static void Main(string[] args)
		{
			string secretWord = Console.ReadLine();
			string encryptedMessage = Console.ReadLine();
			
			string decryptedMessage = "";
			int mask = 0;

			foreach (char letter in secretWord)
			{
				mask += Convert.ToInt32(letter);
			}
			
			secretWord = mask.ToString();
			mask = 0;

			while (secretWord.Length != 1)
			{
				foreach (char letter in secretWord)
				{
					mask += int.Parse(letter.ToString());
				}
				secretWord = mask.ToString();
				mask = 0;
			}
			
			mask = int.Parse(secretWord);

			foreach (char letter in encryptedMessage)
			{
				int code = Convert.ToInt32(letter);
				if (code % mask == 0)
				{
					code += mask;
				}
				else
				{
					code -= mask;
				}
				decryptedMessage += Convert.ToChar(code);
			}

			for (int i = decryptedMessage.Length - 1; i >= 0; i--)
			{
				Console.Write(decryptedMessage[i]);
			}
		}
	}
}