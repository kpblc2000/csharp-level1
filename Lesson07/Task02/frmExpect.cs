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
	public partial class frmExpect : Form
	{
		RandomValue Expected;

		public frmExpect()
		{
			InitializeComponent();
		}

		private void btnSetRandom_Click(object sender, EventArgs e)
		{
			Expected = new RandomValue();
			lblHistory.Visible = true;
			txtHistory.Visible = true;
			lblPlay.Visible = true;
			txtPlay.Visible = true;
			btnAccept.Visible = true;
			txtPlay.Focus();
			txtPlay.Text = "";
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			int enteredValue = int.Parse(txtPlay.Text);
			if (enteredValue == Expected.GetValue)
			{
				txtHistory.Text += Environment.NewLine + "Вы угадали, игра закончена";
				btnAccept.Enabled = false;
				txtPlay.Enabled = false;
			}
			else
			{
				txtHistory.Text += Environment.NewLine + $"{enteredValue} " + (enteredValue > Expected.GetValue ? ">" : "<") + " заданного";
				txtPlay.Focus();
				txtPlay.Text = "";
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtPlay_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(Char.IsDigit(e.KeyChar));
		}
	}
}
