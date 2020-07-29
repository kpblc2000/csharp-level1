using System;

namespace Task02
{
	/// <summary>
	/// Класс для предопределения угадываемого числа
	/// </summary>

	public class RandomValue
	{
		private int _value;

		public RandomValue()
		{
			Random rnd = new Random();
			_value = rnd.Next(100);
		}

		/// <summary>
		/// Значение загаданного числа
		/// </summary>
		public int GetValue { get { return _value; } }
	}
}
