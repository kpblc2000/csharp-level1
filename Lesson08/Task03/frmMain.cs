using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
	public partial class frmMain : Form
	{
		ListQuestion dataBase;
		bool dbModified;

		public frmMain()
		{
			dbModified = false;
			InitializeComponent();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void mnuNewFile_Click(object sender, EventArgs e)
		{

			#region Запрос на сохранение текущей БД
			SaveOnDemand();
			#endregion

			if (dataBase == null || !dbModified)
			{

				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Title = "Открыть БД из файла";
				dlg.Filter = "xml|*.xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					dataBase = new ListQuestion(dlg.FileName);
					dataBase.Save();
					ModifyNumCounter();
				}
			}

		}

		private void mnuOpenFile_Click(object sender, EventArgs e)
		{
			SaveOnDemand();
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "XML-файлы (*.xml)|*.xml";
			dlg.Title = "Открыть имеющуюся БД";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				dataBase = new ListQuestion(dlg.FileName);
				this.Text = dataBase.FileName;
				dbModified = false;
			}
		}

		private void ModifyNumCounter()
		{
			numCounter.Minimum = 1;
			numCounter.Maximum = 1 + dataBase.Count;
		}

		private void SaveOnDemand()
		{
			string titleMsgBox = "Создание новой БД";
			if (dataBase != null)
			{
				if (dbModified)
				{
					if (MessageBox.Show("БД изменена. Сохранять изменения", titleMsgBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						if (dataBase.Save())
						{
							dataBase = null;
							dbModified = false;
						}
					}
				}
			}

		}

		private void numCounter_ValueChanged(object sender, EventArgs e)
		{
			if (dataBase.Count > 0 && (int)numCounter.Value <= dataBase.Count)
			{
				textQuest.Text = dataBase[(int)numCounter.Value - 1].QuestionText;
				chkIsTrue.Checked = dataBase[(int)numCounter.Value - 1].CorrectAnswer;
			}
		}

		private void chkIsTrue_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (dataBase == null)
			{
				MessageBox.Show("Сначала создайте БД", "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			dataBase.Add(textQuest.Text, chkIsTrue.Checked);
			ModifyNumCounter();
			numCounter.Value = (int)dataBase.Count;
			textQuest.Text = "";
			chkIsTrue.Checked = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (dataBase != null)
			{
				dataBase.Save();
			}
		}

		private void mnuSaveFile_Click(object sender, EventArgs e)
		{
			if (dataBase != null)
			{
				dataBase.Save();
			}
		}

		//private bool SaveDB()
		//{
		//	bool res;
		//	SaveFileDialog dlg = new SaveFileDialog();
		//	dlg.Title = "Запись БД";
		//	dlg.Filter = "Файлы xml|(*.xml)";
		//	if (dlg.ShowDialog() == DialogResult.OK)
		//	{

		//	}
		//}
	}
}
