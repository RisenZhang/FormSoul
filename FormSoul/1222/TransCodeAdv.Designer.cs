namespace FormSoul
{
    partial class TransCodeAdv
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
            this.txt_Ori = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Encode = new System.Windows.Forms.Button();
            this.btn_Trans = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Chg
            // 
            this.txt_Chg.Location = new System.Drawing.Point(87, 167);
            this.txt_Chg.Multiline = true;
            this.txt_Chg.Name = "txt_Chg";
            this.txt_Chg.Size = new System.Drawing.Size(340, 132);
            this.txt_Chg.TabIndex = 11;
            // 
            // txt_Ori
            // 
            this.txt_Ori.Location = new System.Drawing.Point(87, 12);
            this.txt_Ori.Multiline = true;
            this.txt_Ori.Name = "txt_Ori";
            this.txt_Ori.Size = new System.Drawing.Size(340, 137);
            this.txt_Ori.TabIndex = 10;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(6, 99);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "存檔";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Encode
            // 
            this.btn_Encode.Location = new System.Drawing.Point(6, 70);
            this.btn_Encode.Name = "btn_Encode";
            this.btn_Encode.Size = new System.Drawing.Size(75, 23);
            this.btn_Encode.TabIndex = 8;
            this.btn_Encode.Text = "加密";
            this.btn_Encode.UseVisualStyleBackColor = true;
            this.btn_Encode.Click += new System.EventHandler(this.btn_Encode_Click);
            // 
            // btn_Trans
            // 
            this.btn_Trans.Location = new System.Drawing.Point(6, 41);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(75, 23);
            this.btn_Trans.TabIndex = 7;
            this.btn_Trans.Text = "轉置";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(6, 12);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.Text = "讀入";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // TransCodeAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 308);
            this.Controls.Add(this.txt_Chg);
            this.Controls.Add(this.txt_Ori);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Encode);
            this.Controls.Add(this.btn_Trans);
            this.Controls.Add(this.btn_Open);
            this.Name = "TransCodeAdv";
            this.Text = "TransCodeAdv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Chg;
        private System.Windows.Forms.TextBox txt_Ori;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Encode;
        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.Button btn_Open;

    }
}