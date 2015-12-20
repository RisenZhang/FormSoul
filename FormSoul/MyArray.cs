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
    public partial class MyArray : Form
    {
        public MyArray()
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
        }

        string sum(int idx)
        {
            return (myGrade1[idx] + myGrade2[idx] + myGrade3[idx]).ToString();
        }
        string item_of_str(int item_no, string instr, char sep)
        {
            string[] instring;
            instring = instr.Split(sep);
            return instring[item_no];
        }

    }
}
