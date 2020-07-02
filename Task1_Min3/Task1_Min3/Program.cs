using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Min3
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 1
		/// Написать метод, возвращающий минимальное из трёх чисел.
		/// </summary>
		static void Main()
		{
			double a = 16.35;
			double b = -65;
			double c = 1;

			Console.WriteLine($"{a}, {b}, {c}; min={MinTriple(a, b, c)}");
			Console.WriteLine("Press any key");
			Console.ReadKey();
		}

		static double MinTriple(double Value1, double Value2, double Value3)
		{
			double res;
			res = Value1 < Value2 ? Value1 : Value2;
			res = res < Value3 ? res : Value3;
			return res;
		}
	}
}
