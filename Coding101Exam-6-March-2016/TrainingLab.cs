using System;

namespace CodingExam
{
	class TrainingLab
	{
		static void Main(string[] args)
		{
			decimal heightToMetres = decimal.Parse(Console.ReadLine());
			decimal widthToMetres = decimal.Parse(Console.ReadLine());

			decimal height = heightToMetres * 100;
			decimal width = widthToMetres * 100;

			int desk = (int)(width - 100) / 70;
			int row = (int)(height / 120);

			int workplace = desk * row - 3;

			Console.WriteLine(workplace);
		}
	}
}