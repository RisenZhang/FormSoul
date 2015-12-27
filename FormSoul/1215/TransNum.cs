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
    public partial class TransNum : Form
    {
        public TransNum()
        {
            InitializeComponent();
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            string smallNum = txt_Money.Text;
            string bigNum = "";

            for (int i = 0; i < smallNum.Length; i++)
            {
                lbl_Ans.Text += toBig(smallNum.Substring(i, 1)) + toUint(smallNum.Length - i);
            }
        }

        string toBig(string num)
        {
            switch (num)
            {
                case "1":
                    return "壹";
                case "2":
                    return "貳";
                case "3":
                    return "參";
                default:
                    return "";
            }
        }

        string toUint(int lengh)
        {
            if (lengh == 1)
            {
                return "";
            }
            else if (lengh == 2)
            {
                return "拾";
            }
            else if (lengh == 3)
            {
                return "佰";
            }
            else if (lengh == 4)
            {
                return "仟";
            }
            else if (lengh == 5)
            {
                return "萬";
            }
            else if (lengh == 6)
            {
                return "拾";
            }
            return "";
        }
    }
}
