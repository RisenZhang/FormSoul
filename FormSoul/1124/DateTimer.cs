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
    public partial class DateTimer : Form
    {
        public DateTimer()
        {
            InitializeComponent();
        }

        private void DateTimer_Load(object sender, EventArgs e)
        {
            PrepareListX();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            lblsplt.Text = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月" +
                           DateTime.Now.Day.ToString() + "日" +
                           DateTime.Now.Hour.ToString() + "時" + DateTime.Now.Minute.ToString() + "分" +
                           DateTime.Now.Second.ToString() + "秒";
        }

        void PrepareListX()
        {
            for (int idx = 1; idx <= 60; idx++)
            {
                comboBox1.Items.Add(idx);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddYears(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
            else if (radioButton2.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddMonths(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
            else if (radioButton3.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddDays(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
            else if (radioButton4.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddHours(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
            else if (radioButton5.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddMinutes(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
            else if (radioButton6.Checked == true)
            {
                lblResult.Text = DateTime.Now.AddSeconds(int.Parse(comboBox1.SelectedItem.ToString())).ToString();
            }
        }
    }
}
