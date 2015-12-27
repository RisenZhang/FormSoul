namespace FormSoul
{
    partial class TransCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Chg = new System.Windows.Forms.TextBox();
            this.btn_Decode = new System.Windows.Forms.Button();
            this.txt_Ori = new System.Windows.Forms.TextBox();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Chg
            // 
            this.txt_Chg.Location = new System.Drawing.Point(306, 37);
            this.txt_Chg.Multiline = true;
            this.txt_Chg.Name = "txt_Chg";
            this.txt_Chg.Size = new System.Drawing.Size(159, 250);
            this.txt_Chg.TabIndex = 12;
            // 
            // btn_Decode
            // 
            this.btn_Decode.Location = new System.Drawing.Point(197, 179);
            this.btn_Decode.Name = "btn_Decode";
            this.btn_Decode.Size = new System.Drawing.Size(75, 45);
            this.btn_Decode.TabIndex = 11;
            this.btn_Decode.Text = "解密";
            this.btn_Decode.UseVisualStyleBackColor = true;
            this.btn_Decode.Click += new System.EventHandler(this.btn_Decode_Click);
            // 
            // txt_Ori
            // 
            this.txt_Ori.Location = new System.Drawing.Point(12, 37);
            this.txt_Ori.Multiline = true;
            this.txt_Ori.Name = "txt_Ori";
            this.txt_Ori.Size = new System.Drawing.Size(159, 250);
            this.txt_Ori.TabIndex = 10;
            // 
            // btn_Encode
            // 
            this.btn_Encode.Location = new System.Drawing.Point(197, 100);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(75, 45);
            this.btn_Encode.TabIndex = 9;
            this.btn_Encode.Text = "加密";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_ToolStripMenuItem
            // 
            this.File_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile_ToolStripMenuItem,
            this.SaveFile_ToolStripMenuItem});
            this.File_ToolStripMenuItem.Name = "File_ToolStripMenuItem";
            this.File_ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.File_ToolStripMenuItem.Text = "檔案";
            // 
            // OpenFile_ToolStripMenuItem
            // 
            this.OpenFile_ToolStripMenuItem.Name = "OpenFile_ToolStripMenuItem";
            this.OpenFile_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFile_ToolStripMenuItem.Text = "開啟舊檔";
            this.OpenFile_ToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_ToolStripMenuItem_Click);
            // 
            // SaveFile_ToolStripMenuItem
            // 
            this.SaveFile_ToolStripMenuItem.Name = "SaveFile_ToolStripMenuItem";
            this.SaveFile_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveFile_ToolStripMenuItem.Text = "另存新檔";
            this.SaveFile_ToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_ToolStripMenuItem_Click);
            // 
            // TransCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 298);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt_Chg);
            this.Controls.Add(this.btn_Decode);
            this.Controls.Add(this.txt_Ori);
            this.Controls.Add(this.btn_Encode);
            this.Name = "TransCode";
            this.Text = "TransCode";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Chg;
        private System.Windows.Forms.Button btn_Decode;
        private System.Windows.Forms.TextBox txt_Ori;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFile_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFile_ToolStripMenuItem;
    }
}