using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 4, задача 1
		/// Дан  целочисленный  массив  из 20 элементов.
		/// Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
		/// Заполнить случайными числами. 
		/// Написать программу, позволяющую найти и вывести количество пар элементов массива,
		/// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{

			IntArray arr = new IntArray(20, (int)-1e4, (int)1e4);
			Console.WriteLine($"Инициированный массив {arr}");

			int coupleRange = 0;
			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i - 1] % 3 == 0 || arr[i] % 3 == 0)
				{
					coupleRange++;
#if DEBUG
					Console.WriteLine($"{arr[i - 1]} {arr[i]} -> {coupleRange}");
#endif
				}
			}

			Console.WriteLine($"Количество пар : {coupleRange}");

			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();

		}
	}
}
