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
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2;
        int operators = -1;

        private void Add_Number (string number)
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
            txtNumber.Text = txtNumber.Text + number;
        }

        private void Select_Operator (int ope)
        {
            num1 = Convert.ToSingle(txtNumber.Text);
            txtNumber.Text = "0";
            operators = ope;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            num1 = 0f;
            num2 = 0f;
            operators = -1;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Add_Number("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Add_Number("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Add_Number("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Add_Number("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Add_Number("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Add_Number("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Add_Number("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Add_Number("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Add_Number("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Add_Number("9");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.IndexOf(".") == -1)
            {
                txtNumber.Text = txtNumber.Text + ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Select_Operator(0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Select_Operator(1);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            Select_Operator(2);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Select_Operator(3);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string input = txtNumber.Text;
            if (input.Length == 1)
                input = "0";
            if (input.Length > 1)
                input = input.Substring(0, input.Length - 1);

            txtNumber.Text = input;

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != "0")
            {
                float tmp = Convert.ToSingle(txtNumber.Text);
                tmp = tmp / 100;
                txtNumber.Text = string.Format("{0:0.##########}", tmp);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float result = 0f;
            num2 = Convert.ToSingle(txtNumber.Text);

            switch (operators)
            {
                case 0:
                    result = num1 + num2;
                    break;
                case 1:
                    result = num1 - num2;
                    break;
                case 2:
                    result = num1 * num2;
                    break;
                case 3:
                    result = num1 / num2;
                    break;
            }

            txtNumber.Text = string.Format("{0:0.##########}", result);

            num1 = 0f;
            num2 = 0f;
            operators = -1;
        }
    }
}
