using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урое 8, задача 2
	/// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
	/// Реализовано через события. 
	/// </summary>
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}
	}
}
