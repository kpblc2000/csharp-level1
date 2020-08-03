using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
	public partial class frmMain : Form
	{
		// ListQuestion dataBase;
		TrueFalse database;
		string MainTitle = "Верю-не верю : ";

		public frmMain()
		{
			InitializeComponent();
			this.Text = MainTitle;
		}

		private void mnuNewFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalse(sfd.FileName);
				database.Add("123", true);
				database.Save();
				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
				nudNumber.Value = 1;
				this.Text = MainTitle + database.FileName;
			}

		}

		private void numCounter_ValueChanged(object sender, EventArgs e)
		{
			textQuest.Text = database[(int)nudNumber.Value - 1].text;
			chkIsTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			database.Add((database.Count + 1).ToString(), true);
			nudNumber.Maximum = database.Count;
			nudNumber.Value = database.Count;
			textQuest.Text = "";
			chkIsTrue.Checked = false;
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (nudNumber.Maximum == 1 || database == null) return;
			database.Remove((int)nudNumber.Value);
			nudNumber.Maximum--;
			if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
		}

		private void mnuSaveFile_Click(object sender, EventArgs e)
		{
			if (database != null) database.Save();
			else MessageBox.Show("База данных не создана");

		}

		private void mnuOpenFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			#region Защита от несуществующего файла
			if (ofd.ShowDialog() == DialogResult.OK && File.Exists(ofd.FileName))
			{
				try
				{
					database = new TrueFalse(ofd.FileName);
					database.Load();
					nudNumber.Minimum = 1;
					nudNumber.Maximum = Math.Max(database.Count, 1);
					nudNumber.Value = 1;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Ошибка открытия БД:\n{ex.Message}", "Открытие БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.Text = MainTitle + database.FileName;
			}
			#endregion
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			database[(int)nudNumber.Value - 1].text = textQuest.Text;
			database[(int)nudNumber.Value - 1].trueFalse = chkIsTrue.Checked;
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show($"Игра \"Верю-не верю\"\nавтор: Алексей Кулик\ne-mail kpblc2000@yandex.ru\n\nВерсия:{Assembly.GetExecutingAssembly().GetName().Version.ToString()}", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void mnuSaveAs_Click(object sender, EventArgs e)
		{
			if (database != null)
			{
				SaveFileDialog dlg = new SaveFileDialog();
				dlg.Title = "Сохранение БД в другой файл";
				dlg.Filter = "Файлы XML|*.xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					database.SaveAs(dlg.FileName);
				}
			}
		}
	}
}
