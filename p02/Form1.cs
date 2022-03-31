using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posun = Convert.ToInt32(textBox2.Text);
            string text = textBox1.Text;
            string sifra = "";
            foreach (char s in text)
            {
                if (s == ' ')
                {
                    sifra += " ";
                }
                else
                {
                    int si = (int)s;
                    if (si >= 65 && si <= 90)
                    {
                        if ((si + posun) >= 89)
                        {
                            si = 64 + ((si + posun) - 90);
                        }
                        else
                        {
                            si = si + posun;
                        }
                    }
                    else if (si >= 97 && si <= 122)
                    {
                        if ((si + posun) >= 121)
                        {
                            si = 95 + ((si + posun) - 121);
                        }
                        else
                        {
                            si = si + posun;
                        }
                    }
                    sifra += (char)si;
                }
                
            }
            MessageBox.Show(sifra);
        }
    }
}
