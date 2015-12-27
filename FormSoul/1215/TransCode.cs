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
    public partial class TransCode : Form
    {
        public TransCode()
        {
            InitializeComponent();
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            string outstring = "";
            string instring = txt_Ori.Text;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(instring);

            for (int idx = 0; idx < asciiBytes.Length; idx++)
            {
                outstring += ((char)(asciiBytes[idx] - 4)).ToString();
            }

            txt_Chg.Text = outstring;
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            string outstring = "";
            string instring = txt_Ori.Text;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(instring);

            for (int idx = 0; idx < asciiBytes.Length; idx++)
            {
                outstring += ((char)(asciiBytes[idx] + 4)).ToString();
            }

            txt_Chg.Text = outstring;
        }

        private string[] _text = { };

        private void OpenFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_Ori.Text = "";
            txt_Chg.Text = "";

            OpenFileDialog file = new OpenFileDialog();

            file.ShowDialog();

            _text = System.IO.File.ReadAllLines(file.FileName);

            foreach (string line in _text)
            {
                txt_Ori.Text += line + "\n";
            }
        }

        private void SaveFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();

            file.ShowDialog();

            System.IO.File.WriteAllText(file.FileName, txt_Chg.Text);
        }
    }
}
