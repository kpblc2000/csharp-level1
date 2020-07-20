using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_GoodValues
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 6
		/// Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
		/// "Хорошим" называется число, которое делится на сумму своих цифр.
		/// Реализовать подсчёт времени выполнения программы, используя структуру DateTime
		/// </summary>
		static void Main()
		{
			Int64 counter = 0;
			int startValue = 1;
			int finalValue = (int)1e9;
			DateTime startTime = DateTime.Now;
			for (int i = startValue; i < finalValue; i++)
			{
				if (IsValueGood(i))
					counter++;
			}
			Console.WriteLine("В диапазоне {1:N0}..{2:N0} найдено {0:N0} \"хороших\" чисел", counter, startValue, finalValue);
			Console.WriteLine("Общее время выполнения: {0}", DateTime.Now - startTime);
			Console.ReadKey();
		}

		static int GetNumberSum(int Value)
		{
			int res = 0;
			while (Value > 0)
			{
				res += Value % 10;
				Value /= 10;
			}
			return res;
		}

		static bool IsValueGood(int Value)
		{
			return Value % GetNumberSum(Value) == 0;
		}
	}
}
