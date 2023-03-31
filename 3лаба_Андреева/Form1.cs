using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace _3лаба_Андреева
{
    public partial class Form1 : Form
    {
        int heightTextBox2;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
            heightTextBox2 = textBox2.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith("!"))
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                string str2 = Program.Factorial(BigInteger.Parse(textBox1.Text.TrimEnd('!'))).ToString(new NumberFormatInfo());
                if (str2.Length > 100)
                {
                    textBox2.ScrollBars = ScrollBars.Vertical;
                    textBox2.Size = new Size(textBox2.Width, heightTextBox2 * 2);
                }
                textBox2.Text = str2;
                sw.Stop();
                label3.Text = sw.ElapsedMilliseconds + " мс";
            }
            else
            {
                MessageBox.Show("Формат неверный!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            const string chars = "1234567890!";
            for(int i = 0, j = 0; i < textBox1.Text.Trim().Length - j; i++)
            {
                if (!chars.Contains(textBox1.Text[i]))
                {
                    textBox1.Text = textBox1.Text.Remove(i, 1);
                    i--;
                    j++;
                }
            }
        }
    }
}
