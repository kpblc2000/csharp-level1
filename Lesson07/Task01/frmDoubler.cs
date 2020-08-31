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

		/// <summary>
		/// Выполняет изменение интерфейса окна, при необходимости блокирует кнопки
		/// </summary>
		/// <param name="CurrentValue">Текущее значение сравниваемой переменной</param>
		/// <param name="ExpextedValue">Значение, которое не должно быть превышено</param>
		private void FillLabelNumExpand(int CurrentValue, int ExpextedValue)
		{
			string msg = "";
			bool playContinue = true;
			if (CurrentValue > ExpextedValue)
			{
				msg = "Err!";
				playContinue = false;
			}
			else if (CurrentValue == ExpextedValue)
			{
				msg = "Вы выиграли!";
				playContinue = false;
			}
			else msg = $"Ваше текущее число: {CurrentValue.ToString()}";

			btnDouble.Enabled = playContinue;
			btnPlus.Enabled = playContinue;

			lblNumber.Text = msg;

			if (CDoubler.IsInPlayMode)
			{
				lblPlayNum.Text = CDoubler.GetValueForPlay.ToString();
				lblMinSteps.Text = $"Этого можно достичь за {CDoubler.GetMinimumSteps} действий";
				lblUserSteps.Text = $"Вы выполнили {CDoubler.GetUserSteps} действий";
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			CDoubler.Plus();
			FillLabelNumExpand(CDoubler.Value, CDoubler.IsInPlayMode ? CDoubler.GetValueForPlay : int.MaxValue);
		}

		private void btnDouble_Click(object sender, EventArgs e)
		{
			CDoubler.Multi();
			FillLabelNumExpand(CDoubler.Value, CDoubler.IsInPlayMode ? CDoubler.GetValueForPlay : int.MaxValue);
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

			FillLabelNumExpand( CDoubler.Value, int.MaxValue);

			lblPlayInfo.Visible = true;
			lblPlayNum.Visible = true;

			lblMinSteps.Visible = true;

			lblUserSteps.Visible = true;


		}
	}
}
