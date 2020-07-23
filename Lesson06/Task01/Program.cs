using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	/// <summary>
	/// Алексей Кулик kpblc2000@gmail.com
	/// Урок 6, задача 1
	/// Изменить программу вывода таблицы функции так, чтобы можно было передавать
	/// функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x)
	/// </summary>
	class Program
	{

		public delegate double Function(double Koeff, double Value);

		/// <summary>
		/// Вывод результатов вычисления функции
		/// </summary>
		/// <param name="Fun">Вызываемая функция</param>
		/// <param name="Koeff">Коэффициент функции</param>
		/// <param name="StartValue">Начальное значение</param>
		/// <param name="EndValue">Максимальное значение</param>
		/// <param name="Step">Шаг изменения переменной</param>
		public static void TableToConsole(Function Fun, double Koeff, double StartValue, double EndValue, double Step = 1)
		{
			Console.WriteLine($"Koeff = {Koeff}");
			Console.WriteLine("----- X ----- Y ------ ");
			Console.WriteLine("|          |          |");
			while (StartValue <= EndValue)
			{
				Console.WriteLine($"| {StartValue,8:0.000} | {Fun(Koeff, StartValue),8:0.000} | ");
				StartValue += Step;
			}
			Console.WriteLine("|          |          |");
			Console.WriteLine("-----------------------");
		}

		public static double Square(double A, double Value)
		{ return A * Value * Value; }

		public static double SinX(double a, double Value)
		{ return a * Math.Sin(Value); }

		
		static void Main()
		{
			Console.WriteLine("a*x^2");
			TableToConsole(Square, 1, -5, 5, 0.5);

			Console.WriteLine("\na*sin(x)");
			TableToConsole(SinX, 1, -5, 5, 0.5);

			Console.WriteLine("Нажмите любую клавишу...");
			Console.ReadKey();
		}
	}
}
