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
    public partial class FileStreamAdv : Form
    {
        public FileStreamAdv()
        {
            InitializeComponent();
        }

        string _source = "";
        string _target = "";

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chk_Source.Items.Count; i++)
            {
                if (chk_Source.GetItemChecked(i))
                {
                    string source_path = chk_Source.GetItemText(chk_Source.Items[i]);

                    CopyFile(source_path, _target + "\\" + getFileName(source_path));
                }
            }

            string[] filePaths = Directory.GetFiles(_target);

            foreach (var filex in filePaths)
            {
                chk_Target.Items.Add(filex);
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

        private void btn_Source_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog sourceFolder = new FolderBrowserDialog();
            sourceFolder.ShowDialog();

            _source = sourceFolder.SelectedPath;

            string[] filePaths = Directory.GetFiles(_source);

            foreach (var filex in filePaths)
            {
                chk_Source.Items.Add(filex);
            }
        }

        private void btn_Target_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog targetFolder = new FolderBrowserDialog();
            targetFolder.ShowDialog();

            _target = targetFolder.SelectedPath;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chk_Target.Items.Count; i++)
            {
                if (chk_Target.GetItemChecked(i))
                {
                    string target_path = chk_Target.GetItemText(chk_Target.Items[i]);

                    File.Delete(target_path);
                    chk_Target.Items.RemoveAt(i);
                }
            }
        }
    }
}
