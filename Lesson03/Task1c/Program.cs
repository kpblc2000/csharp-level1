using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kpblc;

namespace Task1c
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1в
	/// Добавить диалог с использованием switch демонстрирующий работу класса.
	/// Класс описан во внешнем файле, чтобы его можно было использовать в задаче 1б
	/// </summary>
	class Program
	{
		/// Запрашивает у пользователя число, проверяет
		/// </summary>
		/// <param name="Message"></param>
		/// <param name="AllowValues"></param>
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


		static void Main()
		{
			Random rnd = new Random();
			Complex val1 = new Complex(rnd.Next(-50, 50) / 2.0, rnd.Next(-20, 20) / 2.5);
			Complex val2 = new Complex(rnd.Next(-50, 50) / 5.0, rnd.Next(-20, 20) / 10.0);
			string sValues = string.Format("Значения чисел\n\t{0}\n\t{1}", val1, val2);

			Console.WriteLine(sValues);

			int answer = GetValue(@"
Выберите действие:
  1 : сложить числа
  2 : из первого вычесть второе
  3 : из второго вычесть первое
  4 : перемножить числа
  любое другое число : выход

Ваш выбор: ");

			switch (answer)
			{
				case 1:
					Console.WriteLine("{0} + {1} = {2}", val1, val2, val1.Plus(val2));
					break;
				case 2:
					Console.WriteLine("{0} - {1} = {2}", val1, val2, val1.Minus(val2));
					break;
				case 3:
					Console.WriteLine("{0} - {1} = {2}", val2, val1, val2.Minus(val1));
					break;
				case 4:
					Console.WriteLine("{0} * {1} = {2}", val1, val2, val1.Multiple(val2));
					break;
				default:
					Console.WriteLine("Выход...");
					break;
			}

			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
