using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p01
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
            int pocetsou = 0;
            int pocetsamo = 0;
            int pocbi = 0;
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            foreach (char s in text)
            {
                if (samohlasky.Contains(s))
                {
                    pocetsamo++;
                }
                else if (souhlasky.Contains(s))
                {
                    pocetsou++;
                }
                else
                {
                    pocbi++;
                }
            }
            MessageBox.Show("pocet samohlásek ve větě je " + pocetsamo + ", pocet souhlásek je " + pocetsou + "a pocet nepísmenných znaků je " + pocbi);
        }
    }
}
