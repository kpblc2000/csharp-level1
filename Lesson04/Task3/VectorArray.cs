using System;

namespace Task3
{
	class VectorArray
	{

		private int[] _array;
		private int _len;

		/// <summary>
		/// Создание массива целых чисел, начиная с определенного числа и с указанным шагом
		/// </summary>
		/// <param name="ArrayRange">Размер создаваемого массива</param>
		/// <param name="StartValue">Начальное значение</param>
		/// <param name="Step">Шаг заполнения массива</param>
		public VectorArray(int ArrayRange, int StartValue = 0, int Step = 1)
		{
			_array = new int[ArrayRange];
			_len = ArrayRange;
			int idx = 0;
			while (idx < ArrayRange)
			{
				_array[idx] = StartValue + Step * idx;
				idx++;
			}
		}

		/// <summary>
		/// Длина внутреннего массива
		/// </summary>
		public int Length { get { return _len; } }

		public int this[int i] { get { return _array[i]; } set { _array[i] = value; } }

		public override string ToString()
		{
			string res = _array[0].ToString();

			for (int i = 1; i < _len; i++)
			{
				res += $" {_array[i]}";
			}
			return res;
		}

		/// <summary>
		/// Сумма всех чисел массива
		/// </summary>
		public int Sum
		{
			get
			{
				int sum = 0;
				foreach (int item in _array)
				{
					sum += item;
				}
				return sum;
			}
		}

		/// <summary>
		/// Изменение знака всех элементов массива
		/// </summary>
		/// <param name="IncomeArray"></param>
		/// <returns></returns>
		public int[] Inverse(VectorArray IncomeArray)
		{
			int[] res = new int[IncomeArray.Length];
			for (int i = 0; i < IncomeArray.Length; i++)
			{
				res[i] = -IncomeArray[i];
			}
			return res;
		}

		/// <summary>
		/// Умножение всех элементов массива на указанное число
		/// </summary>
		/// <param name="Scale">На сколько умножать элементы массива</param>
		/// <returns></returns>
		public int[] Multi(int Scale)
		{
			for (int i = 0; i < _len; i++)
			{
				_array[i] *= Scale;
			}
			return _array;
		}

		/// <summary>
		/// Количество максимальных элементов в массиве
		/// </summary>
		public int MaxCount
		{
			get
			{
				int[] _locAr = new int[_len];
				for (int i = 0; i < _len; i++)
				{
					_locAr[i] = _array[i];
				}
				Array.Sort(_locAr);
				Array.Reverse(_locAr);
				int res = 1;
				int max = _locAr[0];
				for (int i = 1; i < _locAr.Length; i++)
				{
					if (_locAr[i] == max) res++;
					else
						break;
				}
				return res;
			}
		}
	}
}
