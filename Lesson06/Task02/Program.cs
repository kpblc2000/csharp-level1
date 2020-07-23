using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
	/// <summary>
	/// Алексей Кулик kpblc2000@gmail.com
	/// Урок 6, задача 2
	/// Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
	/// а) Сделать меню с различными функциями и представить пользователю выбор,
	///    для какой функции и на каком отрезке находить минимум. Использовать массив(или список) делегатов, в котором хранятся различные функции.
	/// б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 
	/// </summary>
	
	class Program
	{
		/// <summary>
		/// Делегат для вызова в SaveFuncResults
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		public delegate double Function(double Value);

		/// <summary>
		/// Вычисление значения квадратного уравнения.
		/// </summary>
		/// <param name="Value">Значение переменной, для которой надо вычислить выражение</param>
		/// <returns>Результат вычисления <paramref name="Value"/>*<paramref name="Value"/>-50*<paramref name="Value"/>+10</returns>
		public static double Qudratic(double Value) { return Value * Value - 50 * Value + 10; }

		/// <summary>
		/// Аналог Math.Sin. Просто для примера
		/// </summary>
		/// <param name="Value">Значение угла в радианах, для которого надо вычислить синус</param>
		/// <returns>sin(<paramref name="Value"/>)</returns>
		public static double SinX(double Value) { return Math.Sin(Value); }

		/// <summary>
		/// Аналог Math.Cos. Для примера
		/// </summary>
		/// <param name="Value">Значение угла в радианах, для которого надо вычислить косинус</param>
		/// <returns>cos(<paramref name="Value"/>)</returns>
		public static double CosX(double Value) { return Math.Cos(Value); }

		/// <summary>
		/// Записывает результаты выполнения функции (вызывается через делегата) в файл
		/// </summary>
		/// <param name="Fun">Функция, возвращающая double, и имеющая всего один аргумент double</param>
		/// <param name="fileName">Полное имя файла, в который надо выполнять запись.</param>
		/// <param name="StartValue">Начальное значение, для которого надо вычислять <paramref name="Fun"/></param>
		/// <param name="EndValue">Максимальное значение, для которого вычисляется <paramref name="Fun"/>. Может не быть достигнуто, если разница между <paramref name="StartValue"/> и <paramref name="EndValue"/> не кратно <paramref name="Step"/></param>
		/// <param name="Step">Шаг изменения переменной.</param>
		public static void SaveFuncResults(Function Fun, string fileName, double StartValue, double EndValue, double Step)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
			{
				using (BinaryWriter bw = new BinaryWriter(fs))
				{
					double x = StartValue;
					while (x <= EndValue)
					{
						bw.Write(Fun(x));
						x += Step;// x=x+h;
					}
				}
			}
		}

		/// <summary>
		/// Считывает двоичный файл и возвращает массив значений и минимум результатов вычислений. Если файл <paramref name="FileName"/> не найден, вернет пустой массив и double.MinValue
		/// </summary>
		/// <param name="FileName">Полное имя файла, из которого будет выполняться чтение данных</param>
		/// <param name="MinValue">Возвращаемый по ссылке минимум среди записанных значений</param>
		/// <returns>Массив double, содержащий все прочитанные результаты вычислений</returns>
		public static double[] FindMin(string FileName, out double MinValue)
		{
			List<double> lstRes = new List<double>();
			MinValue = double.MinValue;
			double tempValue;
			if (File.Exists(FileName))
			{
				using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
				{
					using (BinaryReader br = new BinaryReader(fs))
					{
						MinValue = double.MaxValue;
						for (int i = 0; i < fs.Length / sizeof(double); i++)
						{
							tempValue = br.ReadDouble();
							lstRes.Add(tempValue);
							if (MinValue > tempValue) MinValue = tempValue;
						}
					}
				}
			}
			return lstRes.ToArray();
		}

		static void Main()
		{
			string fileName = "data.bin";
			Console.Write(@"Выберите нужную функцию:
1 : квадратное уравнение
2 : sin
3 : cos

Любое другое значение приведет к выходу из программы : ");
			string userSelection = Console.ReadLine();
			string[] allowed = new string[] { "1", "2", "3" };

			if (allowed.Contains(userSelection))
			{
				Console.Write("\nВведите начальное значение : ");
				double.TryParse(Console.ReadLine().Replace('.', ','), out double minValue);
				Console.Write("\nВведите конечное значение : ");
				double.TryParse(Console.ReadLine().Replace('.', ','), out double maxValue);
				Console.Write("\nВведите шаг : ");
				double.TryParse(Console.ReadLine().Replace('.', ','), out double step);

				Function[] arr = new Function[] { Qudratic, SinX, CosX };

				Console.WriteLine("Запись результатов вычислений в файл...");
				SaveFuncResults(arr[int.Parse(userSelection) - 1], fileName, minValue, maxValue, step);
				double[] savedValues = FindMin(fileName, out double minRes);
				Console.WriteLine($"Общее количество записанных результатов равно {savedValues.Length}");
				Console.WriteLine($"Минимум выбранной функции составляет {minRes}");

				Console.WriteLine("Нажмите любую клавишу");
				Console.ReadKey();
			}
		}
	}
}
