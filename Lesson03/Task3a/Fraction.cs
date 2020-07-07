using System;

namespace Task3a
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Задача 3
	/// Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
	/// Предусмотреть методы сложения, вычитания, умножения и деления дробей.
	/// Написать программу, демонстрирующую все разработанные элементы класса.
	/// 
	/// *Добавить свойства типа int для доступа к числителю и знаменателю;
	/// *Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
	/// **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
	/// ***Добавить упрощение дробей.
	/// </summary>

	class Fraction
	{
		private int num; // числитель
		private int denom; // знаменатель
		private int delim; // максимальный общий делитель

		#region Добавить упрощение дробей.
		/// <summary>
		/// Вычисление наибольшего общего делителя. Введено в конструктор класса, а также в назначение полей класса.
		/// Возможно, это неверное решение.
		/// </summary>
		/// <param name="Value1"></param>
		/// <param name="Value2"></param>
		/// <returns></returns>
		private static int EvalDelim(int Value1, int Value2)
		{
			int val1 = Math.Abs(Value1);
			int val2 = Math.Abs(Value2);

			if (val1 == 0 || val2 == 0 || val1 == 1 || val2 == 1)
				return 1;
			else
			{
				while (val1 != val2)
				{
					if (val1 > val2)
						val1 -= val2;
					else
						val2 -= val1;
				}
				return val1;
			}
		}
		#endregion

		public Fraction(int Numerator = 0, int Denominator = 1)
		{
			#region Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
			if (Denominator == 0)
			{
				throw new ArgumentException("Знаменатель не может быть равным 0");
			}
			else
			{
				delim = EvalDelim(Numerator, Denominator);
				num = Numerator / delim;
				denom = Denominator / delim;
				if (denom * num < 0)
				{
					num = -Math.Abs(num);
					denom = Math.Abs(denom);
				}
			}
			#endregion
		}

		#region *Добавить свойства типа int для доступа к числителю и знаменателю;
		public int Numerator
		{
			get { return num; }
			set
			{
				int temp = value;
				int delim = EvalDelim(temp, denom);
				num = value / delim;
				denom /= delim;
			}
		}
		public int Denominator
		{
			get { return denom; }
			set
			{
				int temp = value;
				int delim = EvalDelim(num, temp);
				num /= temp;
				denom = value / delim;
			}
		}
		#endregion

		#region Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
		public double Value { get { return num / (double)denom; } }
		#endregion

		public static Fraction operator +(Fraction Value1, Fraction Value2)
		{
			return new Fraction(Value1.Numerator * Value2.Denominator + Value1.Denominator * Value2.Numerator, Value1.Denominator * Value2.Denominator);
		}

		public static Fraction operator -(Fraction Value1, Fraction Value2)
		{ return new Fraction(Value1.Numerator * Value2.Denominator - Value1.Denominator * Value2.Numerator, Value1.Denominator * Value2.Denominator); }

		public static Fraction operator *(Fraction Value1, Fraction Value2)
		{ return new Fraction(Value1.Numerator * Value2.Numerator, Value1.Denominator * Value2.Denominator); }

		#region Эксперименты с операндами
		/*
		 *Просто эксперименты
		public static bool operator >(Fraction Value1, Fraction Value2)
		{ return Value1.Value > Value2.Value; }

		public static bool operator >=(Fraction Value1, Fraction Value2)
		{ return Value1.Value >= Value2.Value; }

		public static bool operator <(Fraction Value1, Fraction Value2)
		{ return Value1.Value < Value2.Value; }

		public static bool operator <=(Fraction Value1, Fraction Value2)
		{ return Value1.Value <= Value2.Value; }

		public static bool operator ==(Fraction Value1, Fraction Value2)
		{ return Value1.Value == Value2.Value; }

		public static bool operator !=(Fraction Value1, Fraction Value2)
		{ return Value1.Value != Value2.Value; }

		public bool Equals(Fraction Value1)
		{
			if (Value1 == null)
				return false;
			return Value1.Numerator == this.num && Value1.Denominator == this.denom;
		}

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;
			Fraction f = obj as Fraction;
			if (f as Fraction == null)
				return false;
			return f.Numerator == this.num && f.Denominator == this.denom;
		}

		public override int GetHashCode()
		{
			return num * denom;
		}
		*/
		#endregion

		public override string ToString()
		{
			string res;
			if (num == 0)
			{
				res = "0";
			}
			else if (denom == 1)
			{
				res = num.ToString();
			}
			else
			{
				res = (num * denom < 0 ? "-" : "") + Math.Abs(num) + (denom == 1 ? "" : ("/" + Math.Abs(denom)));
			}
			return res;
		}
	}
}
