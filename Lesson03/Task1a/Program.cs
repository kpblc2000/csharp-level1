using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1a
{
	// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1а
	/// Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
	/// </summary>
	
	class Program
	{
		static void Main()
		{

			Complex a = new Complex(1, 2);

			Complex b = new Complex(2);
			Console.WriteLine($"a = {a}");
			Console.WriteLine($"b = {b}");
			Console.WriteLine($"({a}) + ({b}) = {a + b}");
			Console.WriteLine($"({a}) - ({b}) = {a - b}");
			Console.WriteLine();

			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
