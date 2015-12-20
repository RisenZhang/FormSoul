using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSoul
{
    public partial class CalculatorAdv : Form
    {
        public CalculatorAdv()
        {
            InitializeComponent();
        }
        //判斷前面是否輸入數值 預設無
        private bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "1";
                flag = false;
            }
            else
            {
                result.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "2";
                flag = false;
            }
            else
            {
                result.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "3";
                flag = false;
            }
            else
            {
                result.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "4";
                flag = false;
            }
            else
            {
                result.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "5";
                flag = false;
            }
            else
            {
                result.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "6";
                flag = false;
            }
            else
            {
                result.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "7";
                flag = false;
            }
            else
            {
                result.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "8";
                flag = false;
            }
            else
            {
                result.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "9";
                flag = false;
            }
            else
            {
                result.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                result.Text = "";
                result.Text += "0";
                flag = false;
            }
            else
            {
                result.Text += "0";
            }
        }

        void prepcalc()
        {
            switch (op.Text)
            {
                case "+":
                    result.Text = (int.Parse(temp.Text) + int.Parse(result.Text)).ToString();
                    temp.Text = result.Text;
                    break;
                case "-":
                    result.Text = (int.Parse(temp.Text) - int.Parse(result.Text)).ToString();
                    temp.Text = result.Text;
                    break;
                case "*":
                    result.Text = (int.Parse(temp.Text) * int.Parse(result.Text)).ToString();
                    temp.Text = result.Text;
                    break;
                case "/":
                    result.Text = (int.Parse(temp.Text) / int.Parse(result.Text)).ToString();
                    temp.Text = result.Text;
                    break;
                default:
                    temp.Text = result.Text;
                    result.Text = "";
                    break;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            prepcalc();
            op.Text = "+";
            flag = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            prepcalc();
            op.Text = "-";
            flag = true;
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            prepcalc();
            op.Text = "*";
            flag = true;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            prepcalc();
            op.Text = "/";
            flag = true;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            prepcalc();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            op.Text = "";
            temp.Text = "";
        }

        private void pow_Click(object sender, EventArgs e)
        {
            result.Text = Math.Pow(double.Parse(result.Text), 2).ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result.Text = Math.Sqrt(double.Parse(result.Text)).ToString();
        }
    }
}
