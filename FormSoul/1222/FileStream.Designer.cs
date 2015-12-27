namespace FormSoul
{
    partial class FileStream
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
            this.txt_Target = new System.Windows.Forms.TextBox();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.btn_Floder = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Target
            // 
            this.txt_Target.Location = new System.Drawing.Point(12, 196);
            this.txt_Target.Multiline = true;
            this.txt_Target.Name = "txt_Target";
            this.txt_Target.Size = new System.Drawing.Size(484, 138);
            this.txt_Target.TabIndex = 7;
            // 
            // txt_Source
            // 
            this.txt_Source.Location = new System.Drawing.Point(12, 41);
            this.txt_Source.Multiline = true;
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(484, 138);
            this.txt_Source.TabIndex = 6;
            // 
            // btn_Floder
            // 
            this.btn_Floder.Location = new System.Drawing.Point(12, 12);
            this.btn_Floder.Name = "btn_Floder";
            this.btn_Floder.Size = new System.Drawing.Size(75, 23);
            this.btn_Floder.TabIndex = 5;
            this.btn_Floder.Text = "資料夾複製";
            this.btn_Floder.UseVisualStyleBackColor = true;
            this.btn_Floder.Click += new System.EventHandler(this.btn_Floder_Click);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(421, 12);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 23);
            this.btn_Copy.TabIndex = 4;
            this.btn_Copy.Text = "單檔複製";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // FileStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 343);
            this.Controls.Add(this.txt_Target);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.btn_Floder);
            this.Controls.Add(this.btn_Copy);
            this.Name = "FileStream";
            this.Text = "FileStream";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Target;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.Button btn_Floder;
        private System.Windows.Forms.Button btn_Copy;
    }
}