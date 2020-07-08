using System;

namespace Task1
{
	class IntArray
	{
		private int[] _array;
		private int _len;
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

		public int Length { get { return _len; } }

		public override string ToString()
		{
			string res = "";
			foreach (int item in _array)
			{
				res = res + item.ToString() + " ";
			}
			return res;
		}

	}
}
