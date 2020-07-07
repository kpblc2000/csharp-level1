using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Задача 2.
	/// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел.
	/// Сами числа и сумму вывести на экран, используя tryParse.
	/// </summary>
	class Program
	{
		/// Запрашивает у пользователя число, проверяет
		/// </summary>
		/// <param name="Message"></param>
		/// <returns></returns>
		static int GetValue(string Message)
		{
			int res;
			string answer;
			bool correctValue;
			do
			{
				Console.Write(Message);
				answer = Console.ReadLine();
				correctValue = int.TryParse(answer, out res);
			} while (!correctValue);
			return res;
		}

		static void Main(string[] args)
		{
			int answer;
			int sum = 0;
			do
			{
				answer = GetValue("Введите целое число (0 = выход) : ");
				if (answer > 0 && (answer % 2 == 1))
				{
					sum += answer;
				}
			} while (answer != 0);

			Console.WriteLine($"Сумма нечетных положительных чисел равна {sum}");
			Console.ReadKey();
		}
	}
}
