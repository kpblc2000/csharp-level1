using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kpblc;

namespace Task1b
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1б
	/// Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
	/// Класс описан во внешнем файле, чтобы его можно было использовать в задаче 1в
	/// </summary>


	class Program
	{
		static void Main(string[] args)
		{

			Random rnd = new Random();

			Complex[] ar = new Complex[]
			{
				new Complex(),
				new Complex(rnd.Next(-50,50)/2.0),
				new Complex(rnd.Next(-100,100)/3.0),
				new Complex(rnd.Next(-100, 100)/4.5, rnd.Next(-20, 20)*6.5),
				};

			Complex operand = new Complex((double)rnd.Next(-100, 100) * 0.5, (double)rnd.Next(-20, 20) * 0.5);

			Console.WriteLine("Доп.значение: {0}", operand);

			for (int i = 0; i < ar.Length; i++)
			{
				Console.WriteLine("{0}\n\t{0} + {1} = {2}" +
					"\n\t{0} - {1} = {3}" +
					"\n\t{1} - {0} = {4}" +
					"\n\t{0} * {1} = {5}",
					ar[i], operand, ar[i]+(operand),
					ar[i]-(operand),
					operand-(ar[i]),
					ar[i]* (operand)
					);
			}

			Console.WriteLine("Нажмите любую клавишу для выхода");
			Console.ReadKey();
		}
	}
}
