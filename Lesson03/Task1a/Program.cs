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

	struct Complex
	{
		public float Real;
		public float Im;

		public Complex Plus(Complex Value)
		{
			Complex temp;
			temp.Im = Im + Value.Im;
			temp.Real = Real + Value.Real;
			return temp;
		}


		public Complex Minus(Complex Value)
		{
			Complex temp;
			temp.Im = -Value.Im;
			temp.Real = -Value.Real;
			return Plus(temp);
		}

		public override string ToString()
		{
			return Real + "+" + Im + "i";
		}
	}

	class Program
	{
		static void Main()
		{
			Complex a = new Complex
			{
				Real = 10,
				Im = 5
			};
			Complex b = new Complex
			{
				Real = 2,
				Im = 3
			};
			Console.WriteLine("a = " + a); // ToString(), похоже, можно не прописывать
			Console.WriteLine("b = " + b);
			Console.WriteLine("a + b = " + a.Plus(b));
			Console.WriteLine("a - b = " + a.Minus(b));
			Console.WriteLine();

			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
