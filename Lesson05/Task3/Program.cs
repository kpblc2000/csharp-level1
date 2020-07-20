using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 5, задача 3
	/// Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
	/// Например:
	/// badc являются перестановкой abcd
	/// Задание выполняется только на основании задачи в методичке.
	/// </summary>
	class Program
	{
		static void Main()
		{
			string mainString = "abcadeafghi";
			string s2 = "bacfediaahgsqrt";
			string s3 = "bbbbbbbbb";
			string s4 = "acbdefgaahi";
			Console.WriteLine($"mainString = {mainString}");
			Console.WriteLine(StrinsAreReplacedToString(mainString, s2));
			Console.WriteLine(StrinsAreReplacedToString(mainString, s3));
			Console.WriteLine(StrinsAreReplacedToString(mainString, s4));
			
			Console.WriteLine("Нажмите любую клавишу");
			Console.ReadKey();
		}

		/// <summary>
		/// Проверяет, является одна строка простой перестановкой символов другой. Регистр учитывается
		/// </summary>
		/// <param name="ControlString">Контрольная строка</param>
		/// <param name="CheckString">Провеяемая строка</param>
		/// <returns>True, если все символы контрольной строки входят в проверяемую, и наоборот.</returns>
		public static bool StringsAreReplaced(string ControlString, string CheckString)
		{
			bool res = true;

			if (ControlString.Length == CheckString.Length)
			{
				for (int i = 0; i < CheckString.Length; i++)
				{
					if (!ControlString.Contains(CheckString[i]))
					{
						res = false;
						break;
					}
					else
					{
						ControlString = ControlString.Remove(ControlString.IndexOf((char)CheckString[i]), 1);
					}
				}
			}
			else res = false;
			return res;
		}

		/// <summary>
		/// Вывод результатов проверки "перестановки" символов строк
		/// </summary>
		/// <param name="ControlString">Контрольная строка</param>
		/// <param name="CheckString">Провеяемая строка</param>
		/// <returns>Сообщение, готовое к применению в Console.WriteLine()</returns>
		public static string StrinsAreReplacedToString(string ControlString, string CheckString)
		{
			return "Для строки \"" + ControlString + "\" строка \"" + CheckString + "\"" + (StringsAreReplaced(ControlString, CheckString) ? "" : " не") + " является перестановкой";
		}
	}
}
