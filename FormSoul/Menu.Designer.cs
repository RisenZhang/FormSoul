namespace FormSoul
{
    partial class Menu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Prac04 = new System.Windows.Forms.Button();
            this.btn_Test04 = new System.Windows.Forms.Button();
            this.btn_Prac05 = new System.Windows.Forms.Button();
            this.btn_Prac06 = new System.Windows.Forms.Button();
            this.btn_Prac07 = new System.Windows.Forms.Button();
            this.btn_Test05 = new System.Windows.Forms.Button();
            this.btn_Prac08 = new System.Windows.Forms.Button();
            this.btn_Prac09 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Prac04
            // 
            this.btn_Prac04.Location = new System.Drawing.Point(12, 12);
            this.btn_Prac04.Name = "btn_Prac04";
            this.btn_Prac04.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac04.TabIndex = 0;
            this.btn_Prac04.Text = "11/17 練習04";
            this.btn_Prac04.UseVisualStyleBackColor = true;
            this.btn_Prac04.Click += new System.EventHandler(this.btn_Prac04_Click);
            // 
            // btn_Test04
            // 
            this.btn_Test04.Location = new System.Drawing.Point(114, 12);
            this.btn_Test04.Name = "btn_Test04";
            this.btn_Test04.Size = new System.Drawing.Size(96, 33);
            this.btn_Test04.TabIndex = 1;
            this.btn_Test04.Text = "11/24 測驗04";
            this.btn_Test04.UseVisualStyleBackColor = true;
            this.btn_Test04.Click += new System.EventHandler(this.btn_Test04_Click);
            // 
            // btn_Prac05
            // 
            this.btn_Prac05.Location = new System.Drawing.Point(114, 51);
            this.btn_Prac05.Name = "btn_Prac05";
            this.btn_Prac05.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac05.TabIndex = 2;
            this.btn_Prac05.Text = "11/24 練習05";
            this.btn_Prac05.UseVisualStyleBackColor = true;
            this.btn_Prac05.Click += new System.EventHandler(this.btn_Prac05_Click);
            // 
            // btn_Prac06
            // 
            this.btn_Prac06.Location = new System.Drawing.Point(216, 12);
            this.btn_Prac06.Name = "btn_Prac06";
            this.btn_Prac06.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac06.TabIndex = 3;
            this.btn_Prac06.Text = "12/01 練習06";
            this.btn_Prac06.UseVisualStyleBackColor = true;
            this.btn_Prac06.Click += new System.EventHandler(this.btn_Prac06_Click);
            // 
            // btn_Prac07
            // 
            this.btn_Prac07.Location = new System.Drawing.Point(216, 51);
            this.btn_Prac07.Name = "btn_Prac07";
            this.btn_Prac07.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac07.TabIndex = 4;
            this.btn_Prac07.Text = "12/01 練習07";
            this.btn_Prac07.UseVisualStyleBackColor = true;
            this.btn_Prac07.Click += new System.EventHandler(this.btn_Prac07_Click);
            // 
            // btn_Test05
            // 
            this.btn_Test05.Location = new System.Drawing.Point(318, 12);
            this.btn_Test05.Name = "btn_Test05";
            this.btn_Test05.Size = new System.Drawing.Size(96, 33);
            this.btn_Test05.TabIndex = 5;
            this.btn_Test05.Text = "12/08 測驗05";
            this.btn_Test05.UseVisualStyleBackColor = true;
            this.btn_Test05.Click += new System.EventHandler(this.btn_Test05_Click);
            // 
            // btn_Prac08
            // 
            this.btn_Prac08.Location = new System.Drawing.Point(318, 51);
            this.btn_Prac08.Name = "btn_Prac08";
            this.btn_Prac08.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac08.TabIndex = 6;
            this.btn_Prac08.Text = "12/08 練習08";
            this.btn_Prac08.UseVisualStyleBackColor = true;
            this.btn_Prac08.Click += new System.EventHandler(this.btn_Prac08_Click);
            // 
            // btn_Prac09
            // 
            this.btn_Prac09.Location = new System.Drawing.Point(420, 12);
            this.btn_Prac09.Name = "btn_Prac09";
            this.btn_Prac09.Size = new System.Drawing.Size(96, 33);
            this.btn_Prac09.TabIndex = 7;
            this.btn_Prac09.Text = "12/15 練習09";
            this.btn_Prac09.UseVisualStyleBackColor = true;
            this.btn_Prac09.Click += new System.EventHandler(this.btn_Prac09_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 376);
            this.Controls.Add(this.btn_Prac09);
            this.Controls.Add(this.btn_Prac08);
            this.Controls.Add(this.btn_Test05);
            this.Controls.Add(this.btn_Prac07);
            this.Controls.Add(this.btn_Prac06);
            this.Controls.Add(this.btn_Prac05);
            this.Controls.Add(this.btn_Test04);
            this.Controls.Add(this.btn_Prac04);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Prac04;
        private System.Windows.Forms.Button btn_Test04;
        private System.Windows.Forms.Button btn_Prac05;
        private System.Windows.Forms.Button btn_Prac06;
        private System.Windows.Forms.Button btn_Prac07;
        private System.Windows.Forms.Button btn_Test05;
        private System.Windows.Forms.Button btn_Prac08;
        private System.Windows.Forms.Button btn_Prac09;
    }
}

