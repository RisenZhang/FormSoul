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
    public partial class MyArrayAdv : Form
    {
        public MyArrayAdv()
        {
            InitializeComponent();
        }

        //Read line by line
        string[] inLines;
        string[] myName = new string[100];
        int[] myGrade1 = new int[100];
        int[] myGrade2 = new int[100];
        int[] myGrade3 = new int[100];

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            inLines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            int idx = 0;
            foreach (string line in inLines)
            {
                if (line.Trim() != "")
                {
                    myName[idx] = item_of_str(0, line, ',');
                    myGrade1[idx] = int.Parse(item_of_str(1, line, ','));
                    myGrade2[idx] = int.Parse(item_of_str(2, line, ','));
                    myGrade3[idx] = int.Parse(item_of_str(3, line, ','));
                    idx++;
                }
            }

            for (idx = 0; idx < myName.Length; idx++)
            {
                textBox1.Text += "學號:" + myName[idx] + "/ 總分:" + sum(idx) + "\r\n";
            }

            for (int i = 0; i < myName.Length; i++)
            {
                listView1.Items.Add("學號:" + myName[i] + "/ 總分:" + sum(i) + "\r");//新增項目
            }

            for (int i = 0; i < myName.Length; i++)
            {
                listBox1.Items.Add("學號:" + myName[i] + "/ 總分:" + sum(i) + "\r");//新增項目
            }
        }

        string sum(int idx)
        {
            return (myGrade1[idx] + myGrade2[idx] + myGrade3[idx]).ToString();
        }

        string avg(int idx)
        {
            return (int.Parse(sum(idx)) / 3).ToString();
        }

        string item_of_str(int item_no, string instr, char sep)
        {
            string[] instring;
            instring = instr.Split(sep);
            return instring[item_no];
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int idx = listView1.SelectedIndices[0];
                lblnmu.Text = myName[idx];
                lblgrade1.Text = myGrade1[idx].ToString();
                lblgrade2.Text = myGrade2[idx].ToString();
                lblgrade3.Text = myGrade3[idx].ToString();
                lblavg.Text = avg(idx);
                FontColor(idx);

            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            lblnmu.Text = myName[idx];
            lblgrade1.Text = myGrade1[idx].ToString();
            lblgrade2.Text = myGrade2[idx].ToString();
            lblgrade3.Text = myGrade3[idx].ToString();
            lblavg.Text = avg(idx);
            FontColor(idx);
        }

        void FontColor(int idx)
        {
            lblgrade1.ForeColor = Color.Black;
            lblgrade2.ForeColor = Color.Black;
            lblgrade3.ForeColor = Color.Black;

            if (myGrade1[idx] < 60)
            {
                lblgrade1.ForeColor = Color.Red;
            }

            if (myGrade2[idx] < 60)
            {
                lblgrade2.ForeColor = Color.Red;
            }

            if (myGrade3[idx] < 60)
            {
                lblgrade3.ForeColor = Color.Red;
            }
        }
    }
}
