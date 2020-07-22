using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        delegate string Prorab();

        Prorab ali;

        public Form1()
        {
            InitializeComponent();

           

        }

        private   string Builder3()
        {
            return("Сделать крышу");
        }

        private string Builder2()
        {
            return ("Возвести стены");
        }

        private string Builder1()
        {
            return ("Залить фундамент");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ali();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ali = Builder1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ali = Builder2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ali = Builder3;
        }
    }
}
