using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_LoginPassword
{
	class Program
	{
		/// <summary>
		/// Алексей Кулик kpblc2000@yandex.ru
		/// Урок 2, задача 4
		/// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
		/// На выходе истина, если прошел авторизацию, и ложь, если не прошел
		/// Логин: root
		/// Password: GeekBrains).
		/// Используя метод проверки логина и пароля, написать программу:
		/// пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
		/// С помощью цикла do while ограничить ввод пароля тремя попытками.
		/// </summary>
		static void Main()
		{
			int tries = 3;
			Console.WriteLine("Требуется ввод логина и пароля. Соблюдайте регистр!");
			if (LoginSuccess(tries))
			{
				Console.WriteLine("Можно работать...");
			}
			else
			{
				Console.WriteLine("Ошибка ввода логина и пароля в количестве {0} попыток. Работа прекращена", tries);
			}
			Console.WriteLine("Нажмите любую клавишу для выхода");
			Console.ReadKey();
		}

		static bool LoginSuccess(int TryRange)
		{
			string login = "root";
			string pwd = "GeekBrains";
			string userLogin, userPwd;
			bool res = false;
			while (TryRange > 0)
			{
				Console.Write("Логин : ");
				userLogin = Console.ReadLine();
				Console.Write("Пароль : ");
				userPwd = Console.ReadLine();
				if (userLogin == login && userPwd == pwd)
				{
					res = true;
					break;
				}
				else
				{
					TryRange--;
					if (TryRange > 0) Console.WriteLine("Ошибка ввода. У вас осталось {0} попыток.", TryRange);
				}
			}
			return res;
		}
	}
}
