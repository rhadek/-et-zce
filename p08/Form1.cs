using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string[] slova = text.Split(' ');
            if (checkBox1.Checked)
            {
                MessageBox.Show("pocet slov v textu je " + slova.Length);
            }
            int pocetpismen = 0;
            string maxpis = "";
            int maxp = 0;
            foreach (string slova1 in slova)
            {
                pocetpismen = 0;
                foreach (char pismena in slova1)
                {
                    pocetpismen++;
                }
                if (pocetpismen > maxp)
                {
                    maxp = pocetpismen;
                    maxpis = slova1;
                }
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("nejdelsi slovo v textu ma " + maxp + " pismen a je to slovo: " + maxpis);
            }
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Black;
            }
            else if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            Font font = new Font("Microsoft Sans Serif", 12);
            Font font1 = new Font("Microsoft Sans Serif", 20);
            if (radioButton3.Checked)
            {
                textBox1.Font = font;
            }
            else if (radioButton4.Checked)
            {
                textBox1.Font = font1;
            }


        }
    }
}
