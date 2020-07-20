using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Task4
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 5, задача 4
	/// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. (файлом)
	/// В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
	/// <Фамилия> <Имя> <оценки>
	/// Написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
	/// Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
	/// 
	/// 
	/// В решении используется подход, в котором первой строкой не указывается количество учеников - считываются все строки.
	/// Пример файла данных включен в проект.
	/// Предполагается, что в файле нет пустых строк и каждая строка соответствует правилу
	/// <Фамилия> <Имя> [<Оценка1> [<Оценка2> [<Оценка3>]]]
	/// Оценки могут быть пропущены. Учитывается не более 3 оценок. В таком случае они приравниваются к 0, но все равно учитываются при расчете средней оценки.
	/// 
	/// P.S. Я не уверен в эффективности программы
	/// </summary>
	class Program
	{
		[STAThread]
		static void Main()
		{

			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Текстовые файлы (*.txt)|*.txt";
			dlg.Title = "Файл с данными по результатам экзаменов";
			dlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string fileName = dlg.FileName;
				if (File.Exists(fileName))
				{
					List<Student> lstStud = new List<Student>();


					using (StreamReader sr = new StreamReader(fileName))
					{

						while (!sr.EndOfStream)
						{
							lstStud.Add(new Student(sr.ReadLine().Split(new char[] { ' ' })));
						}
					}

					// List -> Array
					Student[] arStd = lstStud.ToArray();

					// Поиск минимально возможного балла
					double minVal = 6d;
					foreach (Student item in arStd)
					{
						if (item.AverageValue < minVal)
						{
							minVal = item.AverageValue;
						}
					}

					Console.WriteLine($"Имя файла с данными: {fileName}");
					Console.WriteLine("\nИсходный массив данных: ");
					foreach (Student item in arStd)
					{
						Console.WriteLine($"{item}");
					}

					Array.Sort(arStd, CompareSudentAverageValues);
					Console.WriteLine("\nОтсортированный по средним оценкам массив данных : ");

					foreach (Student item in arStd)
					{
						Console.WriteLine($"{item}");
					}

					// Поскольку хранить результаты выбора саых плохих оценок не надо, сразу выводим на экран
					int counter = 3;
					Console.WriteLine($"\nСамые плохие оценки:\n {arStd[0]}");
					for (int i = 1; i < arStd.Length; i++)
					{
						if (counter > 1 || arStd[i].AverageValue == minVal)
						{
							Console.WriteLine(arStd[i]);
							if (arStd[i].AverageValue > minVal)
							{
								counter--;
								minVal = arStd[i].AverageValue;
							}
						}
						else break;
					}

				}
				else
					Console.WriteLine("Файл не обнаружен");
			}
			else
				Console.WriteLine("Вы не выбрали файл");

			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}

		private static int CompareSudentAverageValues(Student Item1, Student Item2)
		{
			return Item1.AverageValue > Item2.AverageValue ? 1 : -1;
		}
	}
}
