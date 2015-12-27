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
    public partial class TransCodeAdv : Form
    {
        public TransCodeAdv()
        {
            InitializeComponent();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            txt_Ori.Text = "";
            txt_Chg.Text = "";

            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            txt_Ori.Text = System.IO.File.ReadAllText(file.FileName);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.ShowDialog();

            System.IO.File.WriteAllText(file.FileName, txt_Chg.Text);
        }

        private void btn_Trans_Click(object sender, EventArgs e)
        {
            string outstring = "";
            string instring = txt_Ori.Text;

            for (int idx = instring.Length - 1; idx >= 0; idx--)
            {
                outstring += instring.Substring(idx, 1);
            }

            txt_Chg.Text = outstring;
        }

        private void btn_Encode_Click(object sender, EventArgs e)
        {
            string outstring = "";
            string instring = txt_Chg.Text;

            byte[] asciiBytes = Encoding.ASCII.GetBytes(instring);
            for (int idx = 0; idx < asciiBytes.Length; idx++)
            {
                outstring += ((asciiBytes[idx] + 1)).ToString().PadLeft(3, '0');
            }

            txt_Chg.Text = outstring;
        }
    }
}
