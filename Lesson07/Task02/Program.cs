using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{

	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 7, задача 2
	/// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100,
	/// а человек пытается его угадать за минимальное число попыток.
	/// Компьютер говорит, больше или меньше загаданное число введенного.  
	/// a) Для ввода данных от человека используется элемент TextBox
	/// </summary>

	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmExpect());
		}
	}
}
