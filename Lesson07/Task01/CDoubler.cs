using System;

namespace Task01
{
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 7, задача 1
	/// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
	/// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
	/// Вся логика игры должна быть реализована в классе с удвоителем.

	public static class CDoubler
	{
		private static int _curValue;
		private static int _plusRange;
		private static int _multiRange;
		private static int _random;
		private static bool _inPlayMode;
		private static int _minSteps;

		static CDoubler()
		{
			_curValue = 0;
			_plusRange = 0;
			_multiRange = 0;
			_minSteps = 0;
		}

		/// <summary>
		/// Добавление 1
		/// </summary>
		/// <returns></returns>
		public static void Plus()
		{
			_curValue += 1;
			_plusRange += 1;
		}

		/// <summary>
		/// Удвоение
		/// </summary>
		/// <returns></returns>
		public static void Multi()
		{
			_curValue *= 2;
			_multiRange += 1;
		}

		/// <summary>
		/// Получение текущего значения
		/// </summary>
		public static int Value { get { return _curValue; } }

		/// <summary>
		/// Количество нажатий на "х 2"
		/// </summary>
		public static int MultiRange { get { return _multiRange; } }

		public static int GetValueForPlay { get { return _random; } }

		public static int GetMinimumSteps { get { return _minSteps; } }

		public static int GetUserSteps { get { return _plusRange + _multiRange; } }

		public static bool IsInPlayMode { get { return _inPlayMode; } set { _inPlayMode = value; } }

		public static int RandomInitialize()
		{
			_curValue = 0;
			_plusRange = 0;
			_multiRange = 0;
			_minSteps = 0;
			_inPlayMode = true;
			Random rnd = new Random();
			_random = rnd.Next(1, 1000);
			_random = 202;
			int temp = _random;
			while (temp > 0)
			{
				_minSteps += 1;
				if (temp % 2 == 0)
					temp /= 2;
				else
					temp -= 1;
			}
			return _random;
		}

	}
}
