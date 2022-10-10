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
    public partial class Form1 : Form
    {
        public double num1 = 0;
        public double num2 = 0;
        public double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            resultLabel.Text = resultLabel.Text + "0";
            calcLabel.Text = calcLabel.Text + "0";
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "1";
            calcLabel.Text = calcLabel.Text + "1";
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "2";
            calcLabel.Text = calcLabel.Text + "2";
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "3";
            calcLabel.Text = calcLabel.Text + "3";
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "4";
            calcLabel.Text = calcLabel.Text + "4";
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "5";
            calcLabel.Text = calcLabel.Text + "5";
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "6";
            calcLabel.Text = calcLabel.Text + "6";
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "7";
            calcLabel.Text = calcLabel.Text + "7";
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "8";
            calcLabel.Text = calcLabel.Text + "8";
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + "9";
            calcLabel.Text = calcLabel.Text + "9";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "0";
            calcLabel.Text = "";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            calcLabel.Text = calcLabel.Text + "+";
            resultLabel.Text = "0";
        }

        private void SubtractBtn_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            calcLabel.Text = calcLabel.Text + "-";
            resultLabel.Text = "0";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            calcLabel.Text = calcLabel.Text + "*";
            resultLabel.Text = "0";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            calcLabel.Text = calcLabel.Text + "/";
            resultLabel.Text = "0";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }

            if (calcLabel.Text.Contains("+"))
            {
                string[] eq = calcLabel.Text.Split('+');
                num1 = double.Parse(eq[0]);
                num2 = double.Parse(eq[1]);
                result = num1 + num2;
                resultLabel.Text = result.ToString();
             }
            
            if (calcLabel.Text.Contains("-"))
            {
                string[] eq = calcLabel.Text.Split('-');
                num1 = double.Parse(eq[0]);
                num2 = double.Parse(eq[1]);
                result = num1 - num2;
                resultLabel.Text = result.ToString();
            }

            if (calcLabel.Text.Contains("*"))
            {
                string[] eq = calcLabel.Text.Split('*');
                num1 = double.Parse(eq[0]);
                num2 = double.Parse(eq[1]);
                result = num1 * num2;
                resultLabel.Text = result.ToString();
            }

            if (calcLabel.Text.Contains("/"))
            {
                string[] eq = calcLabel.Text.Split('/');
                num1 = double.Parse(eq[0]);
                num2 = double.Parse(eq[1]);
                result = num1 / num2;
                resultLabel.Text = result.ToString("N2");
            }

            calcLabel.Text += " = ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (resultLabel.Text == "0") { resultLabel.Text = ""; }
            resultLabel.Text = resultLabel.Text + ".";
            calcLabel.Text = calcLabel.Text + ".";
        }
    }
}
