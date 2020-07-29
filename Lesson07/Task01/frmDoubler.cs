using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
	public partial class frmDoubler : Form
	{

		public frmDoubler()
		{
			InitializeComponent();
			lblPlayInfo.Visible = false;
			lblPlayNum.Visible = false;
			lblNumber.Text = $"Ваше текущее число: {CDoubler.Value.ToString()}";
			lblMinSteps.Visible = false;
			lblUserSteps.Visible = false;
		}

		private void FillLabelNumExpand(int CurrentValue, int ExpextedValue)
		{
			string msg = "";
			bool playContinue = true;
			if (CurrentValue > ExpextedValue)
			{ msg = "Err!"; playContinue = false; }
			else if (CurrentValue == ExpextedValue)
			{ msg = "You won!"; playContinue = false; }
			else msg = $"Ваше текущее число: {ExpextedValue.ToString()}";
			btnDouble.Enabled = playContinue;
			btnPlus.Enabled = playContinue;
			lblNumber.Text = msg;
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			FillLabelNumExpand(CDoubler.Value, CDoubler.Value + 1);
			CDoubler.Plus();
		}

		private void btnDouble_Click(object sender, EventArgs e)
		{
			FillLabelNumExpand(CDoubler.Value, CDoubler.Value * 2);
			CDoubler.Multi();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuMultiRange_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Вы нажали на \"x 2\" {CDoubler.MultiRange} раз", "Количество удвоений", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void mnuPlay_Click(object sender, EventArgs e)
		{
			CDoubler.RandomInitialize();
			lblNumber.Text = CDoubler.Value.ToString();
			lblPlayInfo.Visible = true;
			lblPlayNum.Visible = true;
			lblPlayNum.Text = CDoubler.GetValueForPlay.ToString();
			lblMinSteps.Text = $"Этого можно достичь за {CDoubler.GetMinimumSteps} действий";
			lblMinSteps.Visible = true;
			lblUserSteps.Text = $"Вы выполнили {CDoubler.GetUserSteps} действий";
			lblUserSteps.Visible = true;
		}
	}
}
