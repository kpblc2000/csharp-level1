using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
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
			frm.lblNumber.Text = "0";
			Application.Run(frm);
		}
	}

	public class CDoubler
	{
		private int _curValue;
		private int _plusRange;
		private int _multiRange;

		public CDoubler()
		{
			_curValue = 0;
			_plusRange = 0;
			_multiRange = 0;
		}

		public int Plus()
		{
			_curValue += 1;
			_plusRange += 1;
			return _curValue;
		}

		public int Multi()
		{
			_curValue = _curValue * 2;
			_multiRange += 1;
			return _curValue;
		}

		public int Value { get { return _curValue; } }

	}
}
