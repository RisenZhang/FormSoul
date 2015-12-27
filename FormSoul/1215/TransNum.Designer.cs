namespace FormSoul
{
    partial class TransNum
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
            this.btn_Trans = new System.Windows.Forms.Button();
            this.lbl_Ans = new System.Windows.Forms.Label();
            this.txt_Money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Trans
            // 
            this.btn_Trans.Location = new System.Drawing.Point(189, 227);
            this.btn_Trans.Name = "btn_Trans";
            this.btn_Trans.Size = new System.Drawing.Size(75, 23);
            this.btn_Trans.TabIndex = 5;
            this.btn_Trans.Text = "轉換";
            this.btn_Trans.UseVisualStyleBackColor = true;
            this.btn_Trans.Click += new System.EventHandler(this.btn_Trans_Click);
            // 
            // lbl_Ans
            // 
            this.lbl_Ans.AutoSize = true;
            this.lbl_Ans.Location = new System.Drawing.Point(118, 50);
            this.lbl_Ans.Name = "lbl_Ans";
            this.lbl_Ans.Size = new System.Drawing.Size(33, 12);
            this.lbl_Ans.TabIndex = 4;
            this.lbl_Ans.Text = "label1";
            // 
            // txt_Money
            // 
            this.txt_Money.Location = new System.Drawing.Point(20, 13);
            this.txt_Money.Name = "txt_Money";
            this.txt_Money.Size = new System.Drawing.Size(234, 22);
            this.txt_Money.TabIndex = 3;
            // 
            // TransNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Trans);
            this.Controls.Add(this.lbl_Ans);
            this.Controls.Add(this.txt_Money);
            this.Name = "TransNum";
            this.Text = "TransNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Trans;
        private System.Windows.Forms.Label lbl_Ans;
        private System.Windows.Forms.TextBox txt_Money;
    }
}