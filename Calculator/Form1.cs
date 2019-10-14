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
        double resultValue = 0;
        string Operator = "";
        bool isOperator = false;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 数字按钮点击事件
        /// </summary>
        private void NumberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                label2.Text += button.Text;
            }
            else if (button.Text == "±")
            {
                label2.Text = button.Text + label2.Text; ;
            }
            else
            {
                if (label2.Text == "0" || isOperator)
                {
                    label2.Text = "";
                    isOperator = false;
                }
                else if (Operator == "=")
                {
                    label2.Text = "";
                    isOperator = false;
                    Operator = null;
                }
                label2.Text += button.Text;
            }
        }

        /// <summary>
        /// 四则运算符点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue == 0)
            {
                Operator = button.Text;
                resultValue = double.Parse(label2.Text);
                label1.Text = resultValue + Operator;
                isOperator = true;
            }
            else
            {
                but_equal.PerformClick();
                Operator = button.Text;
                label1.Text = resultValue + Operator;
                isOperator = true;
            }
        }

        /// <summary>
        /// 等号按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_equal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (Operator)
            {
                case "＋":
                    label2.Text = (resultValue + double.Parse(label2.Text)).ToString();
                    break;
                case "－":
                    label2.Text = (resultValue - double.Parse(label2.Text)).ToString();
                    break;
                case "×":
                    label2.Text = (resultValue * double.Parse(label2.Text)).ToString();
                    break;
                case "÷":
                    label2.Text = (resultValue / double.Parse(label2.Text)).ToString();
                    break;
            }
            resultValue = double.Parse(label2.Text);
            label1.Text = null;
            Operator = button.Text;
        }

        //CE
        private void but_ce_Click(object sender, EventArgs e)
        {
            label2.Text = null;
        }

        //C
        private void but_C_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            label2.Text = null;
            resultValue = 0;
        }

        //回退
        private void but_del_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
        }

        //百分号
        private void but_percent_Click(object sender, EventArgs e)
        {
            label2.Text = (double.Parse(label2.Text) / 100).ToString();
        }

        //平方根
        private void but_Sqrt_Click(object sender, EventArgs e)
        {
            label2.Text = Math.Sqrt(double.Parse(label2.Text)).ToString();
        }

        //平方
        private void but_pow_Click(object sender, EventArgs e)
        {
            label2.Text = Math.Pow(double.Parse(label2.Text), 2).ToString();
        }

        //倒数
        private void but_dividend_Click(object sender, EventArgs e)
        {
            label2.Text = (1 / double.Parse(label2.Text)).ToString();
        }
    }
}
