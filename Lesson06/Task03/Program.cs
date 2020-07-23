using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 6, задача 3
	/// Переделать программу Пример использования коллекций для решения следующих задач:
	/// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
	/// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
	/// в) отсортировать список по возрасту студента;
	/// г) *отсортировать список по курсу и возрасту студента;
	/// </summary>

	class Student
	{
		private string _firstName;
		private string _lastName;
		private int _courseNum;
		private const int _maxCourse = 6;

		public string Univercity;
		public string Faculty;
		public string Department;
		public int GroupNum;
		public string City;
		public int Age;

		public string FirstName { get { return _firstName; } }
		public string LastName { get { return _lastName; } }
		public int CourseNum
		{
			get { return _courseNum; }
			set
			{
				if (value > 0 && value <= _maxCourse)
				{
					_courseNum = value;
				}
			}
		}

		/// <summary>
		/// Создание экземпляра класса Student
		/// </summary>
		/// <param name="FirstName">Имя</param>
		/// <param name="LastName">Фамилия</param>
		/// <param name="Univercity">Университет</param>
		/// <param name="Faculty">Факультет</param>
		/// <param name="Department">Кафедра</param>
		/// <param name="CourseNum">Курс обучения</param>
		/// <param name="Age">Возраст студента</param>
		/// <param name="GroupNum">Номер группы</param>
		/// <param name="City">Город обучения</param>
		public Student(string FirstName, string LastName, string Univercity, string Faculty, string Department, int CourseNum, int Age, int GroupNum, string City)
		{
			_firstName = FirstName;
			_lastName = LastName;
			if (CourseNum > 0 && CourseNum <= _maxCourse)
				_courseNum = CourseNum;
			else _courseNum = 1;
			this.Age = Age;
			this.City = City;
			this.Department = Department;
			this.GroupNum = GroupNum;
			this.Univercity = Univercity;
			this.Faculty = Faculty;
		}
	}

	class Program
	{

		/// <summary>
		/// Чтение данных о студентах из csv-файла. Файл должен быть в кодировке UTF-8, первая строка - заголовки, игнорируется. Разделитель столбцов ";".
		/// Структура столбцов
		/// FirstName : string 0
		/// LastName  : string 1
		/// Univercity: string 2
		/// Faculity  : string 3
		/// Department: string 4
		/// Age       : int    5
		/// CourseNum : int    6
		/// GroupNum  : int    7
		/// City      : string 8
		/// </summary>
		/// <param name="FileName">Полное имя файла csv, откуда считывать данные</param>
		/// <returns>Список List объектов класса Student</returns>
		static List<Student> ReadFromFile(string FileName)
		{
			List<Student> lstRes = new List<Student>();

			if (File.Exists(FileName))
			{
				using (StreamReader sr = new StreamReader(FileName))
				{
					sr.ReadLine();
					while (!sr.EndOfStream)
					{
						string[] str = sr.ReadLine().Split(';');
						lstRes.Add(new Student(
							FirstName: str[0],
							LastName: str[1],
							Univercity: str[2],
							Faculty: str[3],
							Department: str[4],
							Age: int.Parse(str[5]),
							CourseNum: int.Parse(str[6]),
							GroupNum: int.Parse(str[7]),
							City: str[8]));
					}
				}
			}

			return lstRes;
		}

		[STAThread]
		static void Main(string[] args)
		{

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Текстовые файлы с разделителями ; (*.csv)|*.csv";
			dlg.Title = "Файл с данными по студентам";
			dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
			if (dlg.ShowDialog() == DialogResult.OK && File.Exists(dlg.FileName))
			{
				List<Student> lstStud = ReadFromFile(dlg.FileName);
				#region а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
				int stdCount = 0;
				foreach (Student item in lstStud)
				{
					if (item.CourseNum>=5)
					{
						stdCount +=;
					}
				}
				Console.WriteLine($"Учащихся на 5 и 6 курсах: {stdCount}");
				#endregion

				#region б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);

				#endregion	
			}
			Console.WriteLine("Нажмите на любую клавишу");
			Console.ReadKey();
		}
	}
}
