﻿using System;
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
    public partial class PracListbox : Form
    {
        public PracListbox()
        {
            InitializeComponent();
        }
        //Read line by line
        string[] inLines;
        string[] myNum = new string[10];
        string[] mySex = new string[10];
        int[] myHeight = new int[10];
        int[] myWeight = new int[10];

        private void btn_open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            inLines = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            int idx = 0;
            foreach (string line in inLines)
            {
                if (line.Trim() != "")
                {
                    myNum[idx] = item_of_str(0, line, ',');
                    mySex[idx] = item_of_str(1, line, ',');
                    myHeight[idx] = int.Parse(item_of_str(2, line, ','));
                    myWeight[idx] = int.Parse(item_of_str(3, line, ','));
                    idx++;
                }
            }

            string sex = "";
            int fnum = 0;
            int mnum = 0;

            for (int i = 0; i < myNum.Length; i++)
            {
                if (mySex[i] == " F")
                {
                    sex = "女";
                    fnum++;
                }
                else
                {
                    sex = "男";
                    mnum++;
                }
                listBox1.Items.Add(myNum[i] + " " + sex + " " + myHeight[i] + "cm" + myWeight[i] + "Kg");
            }

            female.Text = fnum.ToString();
            male.Text = mnum.ToString();
        }
        string item_of_str(int item_no, string instr, char sep)
        {
            string[] instring;
            instring = instr.Split(sep);
            return instring[item_no];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            detail.Text = "代碼:" + myNum[idx] + "\n"
                          + "性別:" + mySex[idx] + "\n"
                          + "體重:" + myWeight[idx] + "Kg" + "\n"
                          + "身高" + myHeight[idx] + "Cm" + "\n"
                          + "BMI:" + bmi(idx);
        }

        double bmi(int idx)
        {
            double w = myWeight[idx];
            double h = Double.Parse(myHeight[idx].ToString()) / 100;

            return w / (h * h);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string txt = "";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                txt += listBox1.Items[i].ToString() + "\n";
            }

            System.IO.File.WriteAllText(saveFileDialog1.FileName, txt);
        }
    }
}
