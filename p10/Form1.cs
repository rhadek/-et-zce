using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p10
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
            text = text.Trim();
            string[] slova = text.Split(' ');
            foreach (string s in slova)
            {
                if (s != "")
                {

                    foreach (char si in s)
                    {

                        if ((int)si >= 48 && (int)si <= 57)
                        {

                            listBox1.Items.Add(s);
                            break;
                        }
                    }

                }
            }
        }
    }
}
