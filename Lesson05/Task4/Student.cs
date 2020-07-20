namespace Task4
{
	/// <summary>
	/// Класс, описывающий ученика
	/// </summary>
	public class Student
	{
		private string _firstName;
		private string _lastName;
		private int _value1;
		private int _value2;
		private int _value3;
		private double _average;

		/// <summary>
		/// Создание объекта класса Student.
		/// </summary>
		/// <param name="Datas">Массив строк от 2 элементов. Первый элемент - фамилия, второй - имя. Дальше указываются числа от 1 до 5 (оценки). Учитываются до 3 оценок.
		/// Пропущенные значения приравниваются к 0 и учитываются в расчете средней оценки </param>
		public Student(string[] Datas)
		{
			if (Datas.Length > 1)
			{
				_firstName = Datas[1];
				_lastName = Datas[0];
				_value1 = Datas.Length > 2 ? int.Parse(Datas[2]) : 0;
				_value2 = Datas.Length > 3 ? int.Parse(Datas[3]) : 0;
				_value3 = Datas.Length > 4 ? int.Parse(Datas[4]) : 0;
				_average = (_value1 + _value2 + _value3) / 3.0;
			}
		}

		/// <summary>
		/// ФИО ученика
		/// </summary>
		public string Name { get { return _lastName + " " + _firstName; } }

		/// <summary>
		/// Значение средней оценки для ученика
		/// </summary>
		public double AverageValue { get { return _average; } }

		public override string ToString()
		{
			return $"{_lastName} {_firstName} ; сред.оценка {_average:f3}";
		}

	}
}
