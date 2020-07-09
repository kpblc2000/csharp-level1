using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 4, задача 3
	/// а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, 
	/// создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
	/// Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив
	/// с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
	/// метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов. 
	/// б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
	/// в)*** *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			#region Использование конструктора с размером массива, начальным значением, шагом
			VectorArray arr = new VectorArray(20);
			// VectorArray arr = new VectorArray(10, 20);
			// VectorArray arr = new VectorArray(10, -5, 3);
			#endregion

			Console.WriteLine($"Начальный массив : {arr}");
			#region Сумма элементов массива
			Console.WriteLine($"Сумма элементов массив {arr.Sum}");
			#endregion

			#region Использование инвертации знака элементов массива
			int[] arr2 = arr.Inverse(arr);
			Console.WriteLine("Начальный массив после применения Inverse:\n{0}", arr);
			Console.WriteLine("Новый массив после Inverse:");
			foreach (var item in arr2)
			{
				Console.Write($"{item} ");
			}
			#endregion

			#region Применение умножения всех элементов массива на число
			arr.Multi(3);
			Console.WriteLine("\nНачальный массив после применения Multi:\n{0}", arr);
			#endregion

			#region Подсчет количества максимальных значений после принудительного изменения элементов массива
			arr[8] = arr[16];
			arr[5] = arr[19];

			Console.WriteLine($"Измененный массив {arr}");
			Console.WriteLine($"Количество максимальных значений {arr.MaxCount}");
			#endregion

			#region Посчет частоты вхождения каждого элемента в массиве
			Dictionary<int, int> dictSearch = new Dictionary<int, int>();
			for (int i = 0; i < arr.Length; i++)
			{
				if (dictSearch.ContainsKey(arr[i]))
				{ dictSearch[arr[i]] += 1; }
				else
				{ dictSearch.Add(arr[i], 1); }
			}

			Console.WriteLine("Подсчет вхождений каждого элемента");
			foreach (var item in dictSearch)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
			#endregion

			Console.WriteLine("\nНажмите любую клавишу");
			Console.ReadKey();
		}
	}
}
