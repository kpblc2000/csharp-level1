using System;
using System.Reflection;

namespace Task01
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 8, Задача 1
	/// С помощью рефлексии выведите все свойства структуры DateTime
	/// </summary>

	class Program
	{
		static void Main()
		{
			Type dt = typeof(DateTime);
			foreach (PropertyInfo item in dt.GetProperties())
			{
				Console.WriteLine($"Property : {item.Name}");
			}
			Console.ReadKey();
		}
	}
}
