using System;
using System.Globalization;
using kpblc2000;

namespace lesson01ex1
{
	class Program
	{
		/// <summary>
		/// 
		/// Алексей Кулик kpblc2000@yandex.ru
		/// 
		/// Задача №1
		/// 
		/// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
		/// а) используя склеивание;
		/// б) используя форматированный вывод;
		/// в) используя вывод со знаком $.
		/// </summary>
		static void Main()
		{
			string firstName = ConsoleExtensions.GetValueFromConsole("Введите свое имя");
			string lastName = ConsoleExtensions.GetValueFromConsole("Введите свою фамилию");
			double age = Convert.ToDouble(ConsoleExtensions.GetValueFromConsole("Введите свой возраст в годах"));
			double tall = Convert.ToDouble(ConsoleExtensions.GetValueFromConsole("Введите свой рост в м").Replace('.', ','));
			double weight = Convert.ToDouble(ConsoleExtensions.GetValueFromConsole("Введите свой вес, кг").Replace('.', ','));

			string res = firstName + " " + lastName + " " + age.ToString() + " лет, рост " + tall.ToString() + " м, вес " + weight;

			Console.WriteLine("Склеивание : " + res);
			Console.WriteLine(String.Format("Форматированный : {0} {1}, {2:N2} лет, рост {3:N2}, вес {4:N2}", firstName, lastName, age, tall, weight));
			CultureInfo.CurrentCulture = new CultureInfo("en-US");
			Console.WriteLine("Денежный формат : {0} {1}, {2:N2} лет, рост {3:N2}, вес {4:C2}", firstName, lastName, age, tall, weight);

			ConsoleExtensions.Pause();
		}
	}
}
