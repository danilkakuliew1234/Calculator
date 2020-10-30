using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string numberone;
        private double sum = 0;


        private void summ_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + summ.ButtonText + " ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            sum -= Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + minus.ButtonText + " ";
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            NumberText.Text = Convert.ToString(sum);
            numberone = null;
        }

        private void one_Click(object sender, EventArgs e)
        {
            numberone += one.ButtonText;
            NumberText.Text += one.ButtonText;
        }

        private void two_Click(object sender, EventArgs e)
        {
            numberone += two.ButtonText;
            NumberText.Text += two.ButtonText;
        }

        private void three_Click(object sender, EventArgs e)
        {
            numberone += three.ButtonText;
            NumberText.Text += three.ButtonText;
        }

        private void four_Click(object sender, EventArgs e)
        {
            numberone += four.ButtonText;
            NumberText.Text += four.ButtonText;
        }

        private void five_Click(object sender, EventArgs e)
        {
            numberone += five.ButtonText;
            NumberText.Text += five.ButtonText;
        }

        private void six_Click(object sender, EventArgs e)
        {
            numberone += six.ButtonText;
            NumberText.Text += six.ButtonText;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            numberone += seven.ButtonText;
            NumberText.Text += seven.ButtonText;
        }

        private void eath_Click(object sender, EventArgs e)
        {
            numberone += eath.ButtonText;
            NumberText.Text += eath.ButtonText;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            numberone += nine.ButtonText;
            NumberText.Text += nine.ButtonText;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            numberone += zero.ButtonText;
            NumberText.Text += zero.ButtonText;
        }
    }
}
