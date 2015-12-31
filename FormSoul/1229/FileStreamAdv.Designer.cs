namespace FormSoul
{
    partial class FileStreamAdv
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
            this.btn_Source = new System.Windows.Forms.Button();
            this.btn_Target = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.chk_Source = new System.Windows.Forms.CheckedListBox();
            this.chk_Target = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_Source
            // 
            this.btn_Source.Location = new System.Drawing.Point(12, 12);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(98, 23);
            this.btn_Source.TabIndex = 5;
            this.btn_Source.Text = "選擇來源目錄";
            this.btn_Source.UseVisualStyleBackColor = true;
            this.btn_Source.Click += new System.EventHandler(this.btn_Source_Click);
            // 
            // btn_Target
            // 
            this.btn_Target.Location = new System.Drawing.Point(12, 221);
            this.btn_Target.Name = "btn_Target";
            this.btn_Target.Size = new System.Drawing.Size(75, 23);
            this.btn_Target.TabIndex = 4;
            this.btn_Target.Text = "目標目錄";
            this.btn_Target.UseVisualStyleBackColor = true;
            this.btn_Target.Click += new System.EventHandler(this.btn_Target_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(384, 185);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(112, 23);
            this.btn_Copy.TabIndex = 8;
            this.btn_Copy.Text = "複製到目標目錄";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(384, 404);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(112, 23);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "刪除目標目錄檔案";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // chk_Source
            // 
            this.chk_Source.FormattingEnabled = true;
            this.chk_Source.Location = new System.Drawing.Point(12, 41);
            this.chk_Source.Name = "chk_Source";
            this.chk_Source.Size = new System.Drawing.Size(484, 140);
            this.chk_Source.TabIndex = 10;
            // 
            // chk_Target
            // 
            this.chk_Target.FormattingEnabled = true;
            this.chk_Target.Location = new System.Drawing.Point(12, 250);
            this.chk_Target.Name = "chk_Target";
            this.chk_Target.Size = new System.Drawing.Size(484, 140);
            this.chk_Target.TabIndex = 11;
            // 
            // FileStreamAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 440);
            this.Controls.Add(this.chk_Target);
            this.Controls.Add(this.chk_Source);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Source);
            this.Controls.Add(this.btn_Target);
            this.Name = "FileStreamAdv";
            this.Text = "FileStream";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.Button btn_Target;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.CheckedListBox chk_Source;
        private System.Windows.Forms.CheckedListBox chk_Target;
    }
}