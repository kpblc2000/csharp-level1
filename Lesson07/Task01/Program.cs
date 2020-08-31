using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 7, задача 1
	/// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
	/// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
	/// Вся логика игры должна быть реализована в классе с удвоителем.
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

			frmDoubler frm = new frmDoubler();
			Application.Run(frm);
		}
	}
}
