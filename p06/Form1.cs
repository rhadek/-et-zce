using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;//   ahoj   zdar 
            string text1 = "";
            text = text.Trim();//ahoj   zdar
            string[] slova = text.Split(' ');//ahoj
            foreach (string s in slova)
            {
                if (s != "")
                {
                    text1 += s + " ";
                }
            }
            text1 = text1.Trim();
            textBox1.Text = text1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox2.Text;//   ahoj   zdar 
            string bezmezer = text.Trim();

            if (bezmezer.Contains("  "))
            {
                bezmezer = bezmezer.Replace("  ", " ");
            }
            textBox2.Text = bezmezer;
        }
    }
}
