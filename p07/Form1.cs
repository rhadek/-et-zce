using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string text = textBox1.Text;
            string mor = "";
            foreach (char s in text)
            {
                if (s == ' ')
                {
                    mor += "/ ";
                }
                else
                {
                    mor += morse[((int)s - 97)] + " ";
                }
                
            }
            textBox2.Text = mor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mor = textBox2.Text;
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string[] slova = mor.Split(' ');
            string text1 = "";
            int pocet = 0;
            foreach (string znak in slova)
            {
                int pozice = Array.IndexOf(morse, znak);
                if (znak == "/")
                {
                    text1 += " ";
                }
                else
                {
                    text1 += alphabet[pozice];
                }
                pocet++;
                if (pocet == slova.Length - 1)
                {
                    break;
                }
            }
            textBox1.Text = text1;
        }
    }
}
