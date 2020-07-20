using System.IO;

namespace Task4
{
	struct Account
	{
		private string _login;
		private string _pass;

		/// <summary>
		/// Создание структуры учетной записи на основании текстового файла
		/// </summary>
		/// <param name="FileName">Имя файла, откуда считываются логин (первая строка) и пароль (вторая строка)</param>
		public Account(string FileName)
		{
			_login = string.Empty;
			_pass = string.Empty;
			if (File.Exists(FileName))
			{
				StreamReader sr = new StreamReader(FileName);
				string line;
				while (!sr.EndOfStream)
				{
					line = sr.ReadLine();
					if (line != "")
					{
						if (string.IsNullOrEmpty(_login))
						{
							_login = line;
						}
						else if (string.IsNullOrEmpty(_pass))
						{
							_pass = line;
						}
						else break;
					}
				}
				sr.Close();
			}
		}

		/// <summary>
		/// Получение прочитанного логина
		/// </summary>
		public string Login { get { return _login; } }

		/// <summary>
		/// Получение прочитанного пароля.
		/// </summary>
		public string Password { get { return _pass; } }

		/// <summary>
		/// Проверка успешности авторизации
		/// </summary>
		/// <param name="UserLogin">Вводимый пользователем логин. Не зависит от регистра</param>
		/// <param name="UserPassword">Вводимый пользователем пароль. Регистрозависимо</param>
		/// <returns></returns>
		public bool LoginSuccess(string UserLogin, string UserPassword)
		{
			return UserLogin.ToUpper() == _login.ToUpper() && UserPassword == _pass;
		}

	}
}
