using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpblc
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1б
	/// Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
	/// </summary>

	class Complex
	{
		private double _real;
		private double _im;

		public Complex()
		{
			_real = 0.0;
			_im = 0.0;
		}
		public Complex(double Real)
		{
			_real = Real;
			_im = 0.0;
		}
		public Complex(double Real, double Im)
		{
			_real = Real;
			_im = Im;
		}
		public double Real { get { return _real; } set { _real = value; } }
		public double Im { get { return _im; } set { _im = value; } }
		public override string ToString()
		{
			if (_im == 0)
			{
				return _real.ToString();
			}
			else if (_im < 0)
			{
				return $"{_real}{_im}i";
			}
			else
			{
				return $"{_real}+{_im}i";
			}
		}
		public static Complex operator +(Complex Value1, Complex Value2)
		{
			return new Complex(Value1.Real + Value2.Real, Value1.Im + Value2.Im);
		}

		public static Complex operator -(Complex Value1, Complex Value2)
		{
			return new Complex(Value1.Real - Value2.Real, Value1.Im - Value2.Im);
		}

		public static Complex operator *(Complex Value1, Complex Value2)
		{
			return new Complex(Value1.Real * Value2.Real - Value1.Im * Value2.Im, Value1.Real * Value2.Im + Value2.Real * Value1.Im);
		}
	}

}
