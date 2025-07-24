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
        }

        private TextBox currentTextBox;

        private void SetCurrentTextBox(TextBox txtBox)
        {
            this.currentTextBox = txtBox;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtNum1.Text);
                int y = int.Parse(txtNum2.Text);
                int result = x + y;
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
                int x = int.Parse(txtNum1.Text);
                int y = int.Parse(txtNum2.Text);
                int result = x - y;
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
                int x = int.Parse(txtNum1.Text);
                int y = int.Parse(txtNum2.Text);
                int result = x / y;
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
                int x = int.Parse(txtNum1.Text);
                int y = int.Parse(txtNum2.Text);
                int result = x * y;
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter a number. " + ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNum1.Text = txtNum1.Text + "0";
        }
    }
}
