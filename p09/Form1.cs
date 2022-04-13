using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = "";
            
            foreach (string vety in textBox1.Lines)
            {
                Text += " ";
                bool first = false;
                foreach (char p in vety)
                {
                    
                    if ((int)p >= 97 && (int)p <= 122)
                    {
                        if (!first)
                        {
                            if (checkBox1.Checked)
                            {
                                
                                int xd = (int)p - 32;
                                Text += (char)xd;
                            }
                            else Text += p;
                        }
                        else Text += p;
                    }
                    else Text += p;
                    first = true;
                }
                
                if (checkBox2.Checked)
                {
                    Text += ".";
                }
                
            }
            Text = Text.Trim();
            textBox1.Text = Text;
        }
    }
}
