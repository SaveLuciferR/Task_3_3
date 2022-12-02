using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Task_3_3
{
	class Programm
	{
		static double f(double x)
		{
			double y;

			if (x < 0) y = -4;
			else if (x >= 0 && x <= 1) y = x * x + 3 * x + 4;
			else y = 2;
			return y;
		}

		static void f(double x, out double y)
		{
			if (x < 0) y = -4;
			else if (x >= 0 && x <= 1) y = x * x + 3 * x + 4;
			else y = 2;
		}

		static void Main(string[] agrs)
		{
			try
			{
				Console.Write("Введите H: ");
				double h = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите A: ");
				double a = Convert.ToDouble(Console.ReadLine());
				Console.Write("Введите B:");
				double b = Convert.ToDouble(Console.ReadLine());

				Console.WriteLine("\nПри возврате значения");
				for (double i = a; i <= b; i += h)
				{
					Console.WriteLine("При x = {0:f2}\ty = {1:f2}", i, f(i));
				}

				double y;

				Console.WriteLine("\nПри передаче по ссылке");

				for (double i = a; i <= b; i += h)
				{
					f(i, out y);
					Console.WriteLine("При x = {0:f2}\ty = {1:f2}", i, y);
				}
			}
			catch
			{
				Console.WriteLine("H, A и B должны быть числом");
			}
		}
	}
}