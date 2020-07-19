using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task4
{
	/// <summary>
	/// Алексей Кулик kpblc2000@yandex.ru
	/// Урок 5, задача 4
	/// На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. (файлом)
	/// В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
	/// <Фамилия> <Имя> <оценки>

	/// </summary>
	class Program
	{
		static void Main()
		{
		
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Текстовые файлы (*.txt)|*.txt";
			dlg.Title = "Файл с данными по результатам экзаменов";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				string fileName = dlg.FileName;

			}
		}
	}

	public struct Student
	{
		string FirstName;
		string LastName;
		int 
	}
}
