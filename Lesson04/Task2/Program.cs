using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 4, задача 2
	/// Реализуйте задачу 1 в виде статического класса StaticClass;
	/// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
	/// б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
	/// в)** Добавьте обработку ситуации отсутствия файла на диске.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{

			int arrayRange = 20;
			int minValue = (int)-1e2;
			int maxValue = (int)1e2;

			int[] arr = new int[arrayRange];
			Random rnd = new Random();

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(minValue, maxValue);
			}

			Console.WriteLine($"Массив, инициированный случайными значениями от {minValue} до {maxValue}:\n");;
			foreach (int item in arr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
			#region Решение задачи 1 через статический класс
			Console.WriteLine("Решение статическим классом\nКоличество пар соседей, где хотя бы один из них нацело делится на 3:");
			Console.WriteLine(StaticClass.ReturnTriplePairs(arr));
			#endregion

			#region Чтение массива целых чисел из текстового файла
			Console.WriteLine("\nЧтение массива int из текстового файла");
			int[] fileArr = StaticClass.ReadIntArrayFromFile("..\\..\\dataFile.txt");
			Console.WriteLine("Массив, прочитанный из текстового файла:\n");
			foreach (int item in fileArr)
			{
				Console.Write(item + " ");
			}
			#endregion
			Console.WriteLine("\nНажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
