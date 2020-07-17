using System;
using System.Text.RegularExpressions;

namespace Lesson05
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 5, задача 1
	/// Создать программу, которая будет проверять корректность ввода логина.
	/// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
	/// </summary>
	class Program
	{
		static void Main()
		{
			Console.Write("Введите логин для проверки : ");
			string userLogin = Console.ReadLine();

			// string userLogin = "фбвгдеж";

			bool loginCorrect = false;

			#region Без использования регулярных выражений

			char[] charArray = userLogin.ToCharArray();

			bool res = true;
			for (int i = 0; i < charArray.Length; i++)
			{
				if (!char.IsLetterOrDigit(charArray[i]) || ((int)charArray[i] < 65 || (int)charArray[i] > 122))
				{
					res = false;
					break;
				}
			}
			loginCorrect = userLogin.Length >= 2 && userLogin.Length <= 10 && !char.IsNumber(charArray[0]) && res;
			Console.WriteLine("Без регулярных выражений. Логин " + (loginCorrect ? "" : "не") + "допустим");

			#endregion

			#region С использованием регулярных выражений
			loginCorrect = false;
			Regex rx = new Regex(@"\D[a-z,A-Z,1-9]{2,10}");
			loginCorrect = rx.IsMatch(userLogin);
			Console.WriteLine("С регулярными выражениями. Логин " + (loginCorrect ? "" : "не") + "допустим");
			#endregion

			Console.WriteLine("Press any key");
			Console.ReadKey();
		}
	}
}
