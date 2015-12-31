using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSoul
{
    public partial class FileStream : Form
    {
        public FileStream()
        {
            InitializeComponent();
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();

            System.IO.FileStream fin = new System.IO.FileStream(of.FileName, FileMode.Open);
            BinaryReader reader = new BinaryReader(fin);

            long mylen = reader.BaseStream.Length;

            //使用小寫要結束程式才會寫入
            //byte[] buffer = new byte[mylen];

            //使用大寫是一個集合 程式可以直接把buffer資料寫到檔案中
            Byte[] buffer = new Byte[mylen];

            buffer = reader.ReadBytes((int)mylen);

            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();

            System.IO.FileStream fout = new System.IO.FileStream(sf.FileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fout);

            writer.Write(buffer);
        }

        private void btn_Floder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("選擇來源目錄");
            FolderBrowserDialog sourceFolder = new FolderBrowserDialog();
            sourceFolder.ShowDialog();

            MessageBox.Show("選擇目標目錄");
            FolderBrowserDialog targetFolder = new FolderBrowserDialog();
            targetFolder.ShowDialog();

            string[] filePaths = Directory.GetFiles(sourceFolder.SelectedPath);

            foreach (var filex in filePaths)
            {
                txt_Source.Text += filex + "\r\n";
                CopyFile(filex, targetFolder.SelectedPath + "\\" + getFileName(filex));
                txt_Target.Text += targetFolder.SelectedPath + "\\" + getFileName(filex) + "\r\n";
            }
        }

        void CopyFile(string source, string target)
        {
            System.IO.FileStream fin = new System.IO.FileStream(source, FileMode.Open);
            BinaryReader reader = new BinaryReader(fin);

            long mylen = reader.BaseStream.Length;

            //使用小寫要結束程式才會寫入
            Byte[] buffer = new Byte[mylen];

            buffer = reader.ReadBytes((int)mylen);

            System.IO.FileStream fout = new System.IO.FileStream(target, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fout);

            writer.Write(buffer);

            writer.Flush();
            writer.Close();
            reader.Close();

            fin.Close();
            fout.Close();
        }

        string getFileName(string path)
        {
            string[] fileName = path.Split('\\');
            return fileName[fileName.Length - 1];
        }
    }
}
