namespace Task1a
{
	// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 3, задача 1а
	/// Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
	/// Из любопытства переопределил операнды для элементов структуры
	/// </summary>

	struct Complex
	{

		private double _real;
		private double _im;

		public Complex(double Real = 0, double Im = 0)
		{
			_real = Real;
			_im = Im;
		}

		public double Real { get { return _real; } set { _real = value; } }
		public double Im { get { return _im; } set { _im = value; } }

		public static Complex operator +(Complex Value1, Complex Value2)
		{
			return new Complex(Value1.Real + Value2.Real, Value1.Im + Value2.Im);
		}

		public static Complex operator-(Complex Value1, Complex Value2)
		{
			return new Complex(Value1.Real - Value2.Real, Value1.Im - Value2.Im);
		}

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
	}
}
