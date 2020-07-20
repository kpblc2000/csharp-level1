using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_SumOdd
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 3
		/// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
		/// </summary>
		static void Main()
		{
			int value, summ=0;
			Console.WriteLine("Вводите целые числа. 0 - выход из программы");
			value = int.Parse(Console.ReadLine());
			while (value != 0)
			{
				if ((value > 0) && (value % 2 == 1))
				{
					summ += value;
				}
				value = int.Parse(Console.ReadLine());
			}
			Console.WriteLine($"Сумма = {summ}");
			Console.ReadKey();
		}

	}
}
