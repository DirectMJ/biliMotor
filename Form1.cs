using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _169_Pattaguan_MJ_act3
{
    public partial class Form1 : Form
    {
        double advInstallment = 274840.00;
        double pcxInstallment = 250400.00;
        double clickInstallment = 153800.00;
        double advCash = 168800.00;
        double pcxCash = 151800.00;
        double clickCash = 82800.00;
        double insurance = 4500.00;
        double registration = 3100.00;
        int months = 36;
        public Form1()
        {
            
            InitializeComponent();

            cb1.Items.Add("ADV");
            cb1.Items.Add("CLICK");
            cb1.Items.Add("PCX");
            cb1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                tb5.Enabled = true;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double motorcyclePrice = 0;
            double downPayment = 0;
            double monthlyInstallment = 0;
            double tax = 0;
            double totalPayment = 0;

            if (rb1.Checked)
            {

                if (cb1.SelectedItem.ToString() == "ADV")
                {
                    motorcyclePrice = advInstallment;
                }
                else if (cb1.SelectedItem.ToString() == "PCX")
                {
                    motorcyclePrice = pcxInstallment;
                }
                else if (cb1.SelectedItem.ToString() == "CLICK")
                {
                    motorcyclePrice = clickInstallment;

                }


                if (!double.TryParse(tb5.Text, out downPayment))
                {
                    MessageBox.Show("Please enter a valid downpayment amount.");
                    return;
                }
                double remainingAmount = motorcyclePrice - downPayment;


                monthlyInstallment = remainingAmount / months;


                totalPayment = remainingAmount + (monthlyInstallment * months);

                tax = motorcyclePrice * 0.11;


                tb1.Text = monthlyInstallment.ToString("0.00");
                tb2.Text = insurance.ToString("0.00");
                tb3.Text = registration.ToString("0.00");
                tb4.Text = tax.ToString("0.00");
            }
            else if (rb2.Checked)
            {

                if (cb1.SelectedItem.ToString() == "ADV")
                {
                    motorcyclePrice = advCash;
                }
                else if (cb1.SelectedItem.ToString() == "PCX")
                {
                    motorcyclePrice = pcxCash;
                }
                else if (cb1.SelectedItem.ToString() == "CLICK")
                {
                    motorcyclePrice = clickCash;
                }


                tax = motorcyclePrice * 0.03;


                tb1.Text = "Fully Paid";
                tb4.Text = tax.ToString("0.00");
                tb2.Text = insurance.ToString("0.00");
                tb3.Text = registration.ToString("0.00");
            }
        }

        

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
