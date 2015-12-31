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
    public partial class FinalMixing : Form
    {
        public FinalMixing()
        {
            InitializeComponent();
        }

        //File
        string[] myID = new string[0];
        string[] myName = new string[0];
        string[] mySex = new string[0];
        string[] myEdu = new string[0];
        string[] myDrink = new string[0];
        string[] myMarry = new string[0];
        string[] myColor = new string[0];
        string[] myPic = new string[0];
        string[] myBio = new string[0];


        //education
        string[] college = { "世新大學","逢甲大學","輔仁大學","淡江大學","東海大學","東吳大學" };

        //color Picker
        string str1;
        string str2;
        string str3;

        private void Rbar_Scroll(object sender, ScrollEventArgs e)
        {
            str1 = int.Parse(Rbar.Value.ToString()).ToString("X2");
            str2 = int.Parse(Gbar.Value.ToString()).ToString("X2");
            str3 = int.Parse(Bbar.Value.ToString()).ToString("X2");
            pnl_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + str1 + str2 + str3);
        }

        private void Gbar_Scroll(object sender, ScrollEventArgs e)
        {
            str1 = int.Parse(Rbar.Value.ToString()).ToString("X2");
            str2 = int.Parse(Gbar.Value.ToString()).ToString("X2");
            str3 = int.Parse(Bbar.Value.ToString()).ToString("X2");
            pnl_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + str1 + str2 + str3);      
        }

        private void Bbar_Scroll(object sender, ScrollEventArgs e)
        {
            str1 = int.Parse(Rbar.Value.ToString()).ToString("X2");
            str2 = int.Parse(Gbar.Value.ToString()).ToString("X2");
            str3 = int.Parse(Bbar.Value.ToString()).ToString("X2");
            pnl_Color.BackColor = System.Drawing.ColorTranslator.FromHtml("#" + str1 + str2 + str3);       
        }

        private void FinalMixing_Load(object sender, EventArgs e)
        {
            PrepareListCollege();
        }

        void PrepareListCollege()
        {
            for (int i = 0; i < college.Length; i++)
            {
                cbb_Edu.Items.Add(college[i]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog myPicDialog = new OpenFileDialog();
            myPicDialog.ShowDialog();
            pictureBox1.ImageLocation = myPicDialog.FileName;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int arraySize = myID.Length + 1;
            Array.Resize(ref myID, arraySize);
            Array.Resize(ref myName, arraySize);
            Array.Resize(ref mySex, arraySize);
            Array.Resize(ref myEdu, arraySize);
            Array.Resize(ref myDrink, arraySize);
            Array.Resize(ref myMarry, arraySize);
            Array.Resize(ref myColor, arraySize);
            Array.Resize(ref myPic, arraySize);
            Array.Resize(ref myBio, arraySize);
            int currentSize = arraySize - 1;

            //ID
            myID[currentSize] = txt_ID.Text;

            //Name
            myName[currentSize] = txt_Name.Text;

            //Sex
            if (rbn_F.Checked == true)
            {
                mySex[currentSize] = rbn_F.Text;
            }
            if (rbn_M.Checked == true)
            {
                mySex[currentSize] = rbn_M.Text;
            }

            //Edu
            myEdu[currentSize] = cbb_Edu.Text;

            //Drink
            for (int i = 0; i < chk_Drink.CheckedItems.Count; i++)
            {
                myDrink[currentSize] += "/" + chk_Drink.CheckedItems[i].ToString();
            }

            //Married
        }
    }
}
