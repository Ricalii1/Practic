using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int res;

                if (radioButton1.Checked == true)
                {
                    res = a % b;
                    textBox3.Text = Convert.ToString(res);
                }
                else if (radioButton2.Checked == true)
                {
                    double res1;
                    res1 = Math.Pow(a, b);
                    textBox3.Text = Convert.ToString(res1);
                }
                else if (radioButton3.Checked == true)
                {
                    string av = Convert.ToString(a);
                    string bv = Convert.ToString(b);
                    textBox3.Text = string.Concat(av, bv);
                }
                else if (radioButton4.Checked == true)
                {
                    if (b != 0)
                    {
                        double aa = Convert.ToDouble(a);
                        double bb = Convert.ToDouble(b);
                        double res2 = aa / bb;
                        textBox3.Text = res2 + "";
                    }
                    else
                        textBox3.Text = "Ошибка деления";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
