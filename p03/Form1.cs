using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int K = -1;
            string text = textBox1.Text;
            foreach (char s in text)
            {
                if ((int)s >= 48 && (int)s <= 57)
                {
                    K = (int)s - 48; break;
                }
            }
            if (K <= text.Length)
            {
                if (K == -1)
                {
                    text = textBox1.Text;
                }
                else
                {
                    text = text.Remove(text.Length - K);
                }
                
            }
            else
            {
                text = "";
            }
            
            MessageBox.Show("" + text);
        }
    }
}
