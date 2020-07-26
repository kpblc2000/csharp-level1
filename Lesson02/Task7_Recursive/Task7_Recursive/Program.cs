using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task7_Recursive
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 7
		/// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
		/// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
		/// </summary>
		static void Main()
		{
			int min = 2;
			int max = 10;
			RecursiveShowRange(min, max);
			Console.WriteLine("Сумма чисел от {0} до {1} равна {2}", min, max, RecursiveSumm(min, max));
			Console.ReadKey();
		}

		static void RecursiveShowRange(int MinValue, int MaxValue)
		{
			if (MinValue == MaxValue)
			{
				Console.WriteLine(MaxValue);
			}
			else
			{
				Console.WriteLine(MinValue);
				RecursiveShowRange(++MinValue, MaxValue);
			}
		}

		static int RecursiveSumm(int MinValue, int MaxValue)
		{
			if (MinValue==MaxValue)
			{
				return MinValue;
			}
			else
			{
				return MinValue + RecursiveSumm(++MinValue, MaxValue);
			}
		}
	}
}
