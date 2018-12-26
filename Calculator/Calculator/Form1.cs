using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : System.Windows.Forms.Form
    {
        int deystvie = 0;
        string nashe_chislo;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }  
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double k;
                k = Convert.ToDouble(textBox1.Text);///Преобразует в эквивалентное число с плавающей запятой
                textBox1.Text = Convert.ToString(Math.Sqrt(k));
            }
            else
            {
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            deystvie = 1;
            nashe_chislo = textBox1.Text;
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            deystvie = 2;
            nashe_chislo = textBox1.Text;
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            deystvie = 3;
            nashe_chislo = textBox1.Text;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            deystvie = 4;
            nashe_chislo = textBox1.Text;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (deystvie == 1)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(nashe_chislo) + Convert.ToDouble(textBox1.Text));
                }
                else if (deystvie == 2)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(nashe_chislo) - Convert.ToDouble(textBox1.Text));
                }
                else if (deystvie == 3)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(nashe_chislo) * Convert.ToDouble(textBox1.Text));
                }
                else if (deystvie == 4)
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(nashe_chislo) / Convert.ToDouble(textBox1.Text));
                }
                else if (deystvie == 5)
                {
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(nashe_chislo), Convert.ToDouble(textBox1.Text)));
                }
            }
            catch
            {
                textBox1.Text = "Ошибка";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            {
                deystvie = 5;
                nashe_chislo = textBox1.Text;
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double k;
                k = Convert.ToDouble(textBox1.Text);///Преобразует в эквивалентное число с плавающей запятой
                textBox1.Text = Convert.ToString(Math.Sin(k));
            }
            else
            {
                return;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double k;
                k = Convert.ToDouble(textBox1.Text);///Преобразует в эквивалентное число с плавающей запятой
                textBox1.Text = Convert.ToString(Math.Cos(k));
            }
            else
            {
                return;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double k;
                k = Convert.ToDouble(textBox1.Text);///Преобразует в эквивалентное число с плавающей запятой
                textBox1.Text = Convert.ToString(Math.Tan(k));
            }
            else
            {
                return;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double k;
                k = Convert.ToDouble(textBox1.Text);///Преобразует в эквивалентное число с плавающей запятой
                textBox1.Text = Convert.ToString(1/Math.Tan(k));
            }
            else
            {
                return;
            }
        }
    }
}
