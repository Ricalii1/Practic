using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreditInfo(int payment)
        {
            int credit = Convert.ToInt32(textBox1.Text);
            int debt = 0;
            int overpayment = 0;

            if (payment > credit)
            {
                overpayment = payment - credit;
                MessageBox.Show("Кредит погашен. Сумма переплаты составила " + overpayment + " рублей");
            }
            else if (payment == credit)
            {
                MessageBox.Show("Кредит погашен.");
            }
            else
            {
                debt = credit - payment;
                MessageBox.Show("Задолженность составляет " + debt + " рублей");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CreditInfo(Convert.ToInt32(textBox2.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
