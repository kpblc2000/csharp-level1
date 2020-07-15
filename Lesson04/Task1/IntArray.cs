using System;

namespace Task1
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 4, задача 1
	/// </summary>
	class IntArray
	{
		private int[] _array;
		private int _len;

		/// <summary>
		/// Массив целых чисел
		/// </summary>
		/// <param name="ArrayRange">Размер массива (без контроля)</param>
		/// <param name="MinValue">Минимальное возможное значение</param>
		/// <param name="MaxValue">Максимальное возможное значение</param>
		public IntArray(int ArrayRange, int MinValue = int.MinValue, int MaxValue = int.MaxValue)
		{
			_array = new int[ArrayRange];
			Random rnd = new Random();
			for (int i = 0; i < ArrayRange; i++)
			{
				_array[i] = rnd.Next(MinValue, MaxValue);
			}
			_len = ArrayRange;
		}

		public int this[int i] { get { return _array[i]; } set { _array[i] = value; } }

		/// <summary>
		/// Размер массива
		/// </summary>
		public int Length { get { return _len; } }

		/// <summary>
		/// Вывод всего массива в одну строку
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string res = $"{_array[0]}";
			for (int i = 1; i < _len; i++)
			{
				res += $" {_array[i]}";
			}
			return res;
		}

	}
}
