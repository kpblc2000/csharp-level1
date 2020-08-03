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

		private void textBoxBack_TextChanged(object sender, EventArgs e)
		{
			if (textBoxBack.Text == "")
			{
				numericUpDownBack.Value = 0;
				return;
			}
			int val;
			int.TryParse(textBoxBack.Text, out val);
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
