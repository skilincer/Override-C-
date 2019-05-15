using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           Complex c1 = new Complex((double)numericUpDown1.Value,(double)numericUpDown2.Value);
            Complex c2 = new Complex((double)numericUpDown3.Value,(double)numericUpDown4.Value);
            Complex toplam = c1 + c2;
            textBox1.Text = toplam.ToString();

        }
    }
}
