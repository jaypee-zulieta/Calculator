using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            this.SetCurrentTextBox(txtNum1);
            this.calculatorLogic = new CalculatorLogicImpl();
        }

        public Calculator(ICalculatorLogic calculatorLogic)
        {
            InitializeComponent();
            this.SetCurrentTextBox(txtNum1);
            this.calculatorLogic = calculatorLogic;
        }

        private ICalculatorLogic calculatorLogic;

        private TextBox currentTextBox;

        private void SetCurrentTextBox(TextBox txtBox)
        {
            this.currentTextBox = txtBox;
        }

        private TextBox GetCurrentTextBox()
        {
            return this.currentTextBox;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtNum1.Text);
                double y = double.Parse(txtNum2.Text);
                double result = calculatorLogic.Add(x, y);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a number. " + ex.Message);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtNum1.Text);
                double y = double.Parse(txtNum2.Text);
                double result = calculatorLogic.Sub(x, y);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a number. " + ex.Message);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtNum1.Text);
                double y = double.Parse(txtNum2.Text);
                double result = calculatorLogic.Div(x, y);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a number. " + ex.Message);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtNum1.Text);
                double y = double.Parse(txtNum2.Text);
                double result = calculatorLogic.Mul(x, y);
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a number. " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "1";
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += "0";
        }

        private void periodBTN_Click(object sender, EventArgs e)
        {
            TextBox txt = this.GetCurrentTextBox();
            txt.Text += ".";
        }

        private void txtNum1_Click(object sender, EventArgs e)
        {
            this.SetCurrentTextBox(txtNum1);
        }

        private void txtNum2_Click(object sender, EventArgs e)
        {
            this.SetCurrentTextBox(txtNum2);
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            this.SetCurrentTextBox(txtNum1);
        }

        private void backspaceBTN_Click(object sender, EventArgs e)
        {
            TextBox currentTextBox = this.GetCurrentTextBox();
            string currentTextBoxText = currentTextBox.Text;
            string newText = "";

            for (int i = 0; i < currentTextBoxText.Length -1 ; i++)
                newText += currentTextBoxText[i];
            
            currentTextBox.Text = newText;
        }

       

    }
}
