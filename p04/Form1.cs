using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p04
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
            int pozice = 0;
            foreach (char s in text)
            {
                if ((int)s >= 65 && (int)s <= 90)
                {
                    text = text.Remove(pozice, 1);
                    pozice--;
                }
                pozice++;
            }
            MessageBox.Show("" + text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace("*", "");
            MessageBox.Show("" + text);
        }
    }
}
