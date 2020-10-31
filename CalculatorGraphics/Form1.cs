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
        private string LastOperation = null;

        private void summ_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + summ.ButtonText + " ";
            LastOperation = "sum";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            sum -= Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + minus.ButtonText + " ";
            LastOperation = "minus";
        }
        private void divide_Click(object sender, EventArgs e) // Have bug
        {
            sum /= Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + divide.ButtonText + " ";
            LastOperation = "divide";
        }
        private void multiply_Click(object sender, EventArgs e) // Have bug
        {
            sum *= Convert.ToInt32(numberone);
            numberone = null;
            NumberText.Text += " " + multiply.ButtonText + " ";
            LastOperation = "multiply";
        }
        private void Equally_Click(object sender, EventArgs e)
        {
            if (LastOperation.Equals("sum"))
                sum += Convert.ToDouble(numberone);
            if(LastOperation.Equals("minus"))
                sum -= Convert.ToDouble(numberone);
            if (LastOperation.Equals("divide"))
                sum /= Convert.ToDouble(numberone);
            if (LastOperation.Equals("multiply"))
                sum *= Convert.ToDouble(numberone);

            NumberText.Text = Convert.ToString(sum);
            numberone = null;
        }
        private void CheckNumberTextOnNull(string ButtonText)
        {
            if (NumberText.Text.Equals("0"))
            {
                NumberText.Text = null;
                NumberText.Text += ButtonText;
            }
            else
                NumberText.Text += ButtonText;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            NumberText.Text = "0";
            sum = 0;
        }
        private void one_Click(object sender, EventArgs e)
        {
            numberone += one.ButtonText;
            CheckNumberTextOnNull(one.ButtonText);
        }
        private void two_Click(object sender, EventArgs e)
        {
            numberone += two.ButtonText;
            CheckNumberTextOnNull(two.ButtonText);
        }
        private void three_Click(object sender, EventArgs e)
        {
            numberone += three.ButtonText;
            CheckNumberTextOnNull(three.ButtonText);
        }
        private void four_Click(object sender, EventArgs e)
        {
            numberone += four.ButtonText;
            CheckNumberTextOnNull(four.ButtonText);
        }
        private void five_Click(object sender, EventArgs e)
        {
            numberone += five.ButtonText;
            
            CheckNumberTextOnNull(five.ButtonText);
        }
        private void six_Click(object sender, EventArgs e)
        {
            numberone += six.ButtonText;
            CheckNumberTextOnNull(six.ButtonText);
        }
        private void seven_Click(object sender, EventArgs e)
        {
            numberone += seven.ButtonText;
            CheckNumberTextOnNull(seven.ButtonText);
        }
        private void eath_Click(object sender, EventArgs e)
        {
            numberone += eath.ButtonText;
            CheckNumberTextOnNull(eath.ButtonText);
        }
        private void nine_Click(object sender, EventArgs e)
        {
            numberone += nine.ButtonText;
            CheckNumberTextOnNull(nine.ButtonText);
        }
        private void zero_Click(object sender, EventArgs e)
        {
            numberone += zero.ButtonText;
            CheckNumberTextOnNull(zero.ButtonText);
        }
    }
}
