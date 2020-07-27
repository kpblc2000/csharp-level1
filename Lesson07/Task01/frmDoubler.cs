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
		CDoubler cDbl;

		public frmDoubler()
		{
			InitializeComponent();
			cDbl = new CDoubler();
			FillLabelNum();
		}

		private void FillLabelNum()
		{
			lblNumber.Text = cDbl.Value.ToString();
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			cDbl.Plus();
			FillLabelNum();
		}

		private void btnDouble_Click(object sender, EventArgs e)
		{
			cDbl.Multi();
			FillLabelNum();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
