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
                label1.Text += ("pocet slov v textu je " + slova.Length+ " ");
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
                label1.Text+= ("nejdelsi slovo v textu ma " + maxp + " pismen a je to slovo: " + maxpis);
            }
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Black;
            }
            else if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (radioButton3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 12);
            }
            else if (radioButton4.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.Name, 12);
            }


        }
    }
}
