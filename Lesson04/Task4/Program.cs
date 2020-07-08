using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			Account acc = new Account("..\\..\\LoginPwd.txt");
			if (string.IsNullOrEmpty(acc.Login) || string.IsNullOrEmpty(acc.Password))
			{
				Console.WriteLine("Не удалось полностью прочитать данные для авторизации. Проверьте наличие файла и корректность его данных");
			}
			else
			{
				int tries = 3;
				bool success = false;
				string userLogin, userPass;
				Console.WriteLine("Требуется ввод логина и пароля. Пароль чувствителен к регистру!");
				do
				{
					Console.WriteLine($"У Вас осталось {tries} попыток");
					Console.Write("Введите логин : ");
					userLogin = Console.ReadLine();
					Console.Write("Введите пароль : ");
					userPass = Console.ReadLine();
					success = acc.LoginSuccess(userLogin, userPass);
					tries -= 1;
				} while (tries > 0 && !success);

				if (!success)
					Console.WriteLine("Авторизация не пройдена");
				else
				{
					Console.WriteLine("Можем работать");
					Console.WriteLine("<...>");
				}
			}
			Console.ReadKey();
		}
	}
}
