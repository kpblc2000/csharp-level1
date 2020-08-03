using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			textBox.Text = numericUpDown.Value.ToString();
		}

		private void textBoxBack_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		/*
		 * Ivan Barmin, [03.08.20 16:19]
else в данном случае обрабатывает все остальные случаи, если тебе при пустой строке нужно только сделать правку и ничего более из кода метода, то просто сделай правку и вызови return

Ivan Barmin, [03.08.20 16:20]
так же любое получение числа из строки оборачивайте в TryParse

Ivan Barmin, [03.08.20 16:24]
для сокращения кода под это дело можно выделить отдельный метод, так сказать начало валидации ввода пользователя в графическом приложении

Ivan Barmin, [03.08.20 16:37]
ну и раз он больше нигде не понадобится можно его и в виде локальной функции внутри метода описать
		 */
		private void textBoxBack_TextChanged(object sender, EventArgs e)
		{
			if (textBoxBack.Text == "")
			{
				numericUpDownBack.Value=0;
			}
			else
			{
				int val = int.Parse(textBoxBack.Text);
				int min = (int)numericUpDownBack.Minimum;
				int max = (int)numericUpDownBack.Maximum;
				if (val >= min && val <= max)
					numericUpDownBack.Value = val;
				else
				{
					val = val >= max ? max : min;
					textBoxBack.Text = val.ToString();
				}
			}
		}
	}
}
