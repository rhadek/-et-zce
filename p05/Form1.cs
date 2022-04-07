using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p05
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
            int pocets = 1;
            if (text == "")
            {
                pocets = 0;
            }
            else
            foreach (char s in text)
            {
                if ((int)s == 32)
                {
                    pocets++;
                }
            }
            MessageBox.Show("pocet slov v textu je " + pocets);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            int pocets = 0;
            int prevBut = 0;
            bool byl = false;
            foreach (char s in text)
            {
                if (!byl) pocets = 1;byl = true;
                if ((int)s == 32)
                {
                    if (prevBut != 32) pocets++;

                }
                prevBut = (int)s;
            }
            MessageBox.Show("pocet slov v textu je " + pocets);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = textBox3.Text;//   ahoj   zdar 
            text = text.Trim();//ahoj   zdar
            int pocets = 0;
            string[] slova = text.Split(' ');//ahoj  
            foreach (string s in slova)
            {
                if (s != "")
                {
                    pocets++;
                }
            }
            MessageBox.Show("pocet slov v textu je " + pocets);
        }
    }
}
