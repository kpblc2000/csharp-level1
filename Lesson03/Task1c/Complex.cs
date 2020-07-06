using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpblc
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1б, 1в
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
			return "(" + _real + (_im < 0 ? "" : "+") + _im + "i)";
		}
		public Complex Plus(Complex Value)
		{
			return new Complex(Value.Real + _real, Value.Im + _im);
		}
		public Complex Plus(double Value)
		{
			return Plus(new Complex(Value));
		}
		public Complex Plus(int Value)
		{
			return Plus((double)Value);
		}
		public Complex Minus(Complex Value)
		{
			return new Complex(_real - Value.Real, _im - Value.Im);
		}
		public Complex Minus(double Value)
		{
			return Minus(new Complex(Value));
		}
		public Complex Minus(int Value)
		{
			return Minus((double)Value);
		}
		public Complex Multiple(Complex Value)
		{
			return new Complex(_real * Value.Real - _im * Value.Im, _real * Value.Im + Value.Real * _im);
		}
	}

}
