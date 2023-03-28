using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valuta_Skrypnyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "<=";
            textBox3.Enabled = true;
            textBox4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "=>";
            textBox3.Enabled = false;
            textBox4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs1, kurs2, suma, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked == true) {
                textBox4.Enabled = true;
                string S = textBox3.Text;
                suma = double.Parse(S);
                sum_out = suma * kurs1;
                textBox4.Text = sum_out.ToString();
                sum_out = sum_out * 0.005; //додаткове завдання (вираховумо суму комісії банку, що становить 0.05%)
                textBox5.Text = sum_out.ToString();
            }
            else
            {
                textBox3.Enabled = true;
                string S = textBox4.Text;
                suma = double.Parse(S);
                sum_out = suma / kurs2;
                textBox3.Text = sum_out.ToString();
                suma = suma * 0.005; //продовження минулого додаткового завдання
                textBox5.Text = suma.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) //додаткове завдання (робимо додаткову кнопку очистки тексту в текстбоксах)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e) //додаткове завдання (робимо вспливаючі підсказки, за допомогою тултіпів)
        {
            toolTip1.Show("Введіть курс купівлі", this.textBox1);
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e) //хір ві гоу егейн, знову додаткове завдання з попередньою умовою
        {
            toolTip2.Show("Введіть курс купівлі", this.textBox2);
        }

        private void label2_Click(object sender, EventArgs e) //додаткове завдання (можливість зміни типу операції внаслідок натискання стрілки)
        {
            if (radioButton1.Checked == false)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        
    }
}
