namespace BeautySalon
{
    partial class DefiningServices
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
            this.label2 = new System.Windows.Forms.Label();
            this.serName = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.serDes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(148, 47);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "تعریف خدمات آرایشگاه";
            // 
            // serName
            // 
            this.serName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.serName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serName.Location = new System.Drawing.Point(119, 129);
            this.serName.Multiline = true;
            this.serName.Name = "serName";
            this.serName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serName.Size = new System.Drawing.Size(244, 28);
            this.serName.TabIndex = 32;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userName.Location = new System.Drawing.Point(296, 107);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userName.Size = new System.Drawing.Size(70, 16);
            this.userName.TabIndex = 31;
            this.userName.Text = "نام خدمت :";
            // 
            // serDes
            // 
            this.serDes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.serDes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serDes.Location = new System.Drawing.Point(119, 197);
            this.serDes.Multiline = true;
            this.serDes.Name = "serDes";
            this.serDes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serDes.Size = new System.Drawing.Size(244, 140);
            this.serDes.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(296, 175);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "توضیحات :";
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.InsertBtn.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InsertBtn.Location = new System.Drawing.Point(119, 360);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(244, 45);
            this.InsertBtn.TabIndex = 35;
            this.InsertBtn.Text = "درج  خدمت";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(34, 433);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "بازگشت";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // DefiningServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(463, 490);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.serDes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "DefiningServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DefiningServices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox serDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label label5;
    }
}