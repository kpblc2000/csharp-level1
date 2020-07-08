using System;
using System.IO;

namespace Task2
{
	static class StaticClass
	{

		/// <summary>
		/// Статический метод, который принимает на вход массив и решает задачу 1;
		/// </summary>
		/// <param name="array">Массив целочисленных значений</param>
		/// <returns>Количество соседей, где хотя бы один из них нацело делится на 3</returns>
		public static int ReturnTriplePairs(int[] array)
		{
			int count = 0;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i - 1] % 3 == 0 || array[i] % 3 == 0)
				{
#if DEBUG
					Console.WriteLine($"{array[i - 1]} {array[i]} -> {count}");
#endif
					count++;

				}
			}
			return count;
		}

		/// <summary>
		/// Статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел.
		/// Некорректные значения игнорируются
		/// В случае отсутствия файла возвращает null
		/// </summary>
		/// <param name="FileName">Имя текстового файла, откуда выполняется чтение массива</param>
		/// <returns>Массив целочисленных значений.</returns>
		public static int[] ReadIntArrayFromFile(string FileName)
		{
			if (File.Exists(FileName))
			{

				StreamReader sr = new StreamReader(FileName);

				int[] fileArr = new int[0];
				int x;
				while (!sr.EndOfStream)
				{
					if (int.TryParse(sr.ReadLine(), out x))
					{
						Array.Resize(ref fileArr, fileArr.Length + 1);
						fileArr[fileArr.Length - 1] = x;
					}
				}

				sr.Close();
				return fileArr;
			}
			else
			{
				return null;
			}
		}
	}
}
