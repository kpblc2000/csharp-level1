using System.IO;

namespace Task4
{
	struct Account
	{
		private string _login;
		private string _pass;

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

		public string Login { get { return _login; } }
		public string Password { get { return _pass; } }

		public bool LoginSuccess(string UserLogin, string UserPassword)
		{
			return UserLogin.ToUpper() == _login.ToUpper() && UserPassword == _pass;
		}

	}
}
