using System;

namespace Task2_Count
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 2
		/// Написать метод подсчета количества цифр числа
		/// </summary>
		static void Main()
		{
			int value = 12;
			Console.WriteLine(NumRangeWhile(value));
			Console.WriteLine(NumRangeString(value));
			Console.ReadKey();
		}

		static int NumRangeString(int Value)
		{
			return Value.ToString().Length;
		}

		static int NumRangeWhile(int Value)
		{
			int res = 1;
			while (Value / 10 > 0)
			{
				res++;
				Value = Value / 10;
			}
			return res;
		}

	}
}
