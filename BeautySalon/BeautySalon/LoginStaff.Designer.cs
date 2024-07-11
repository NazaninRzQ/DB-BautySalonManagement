namespace BeautySalon
{
    partial class LoginStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginStaff));
            this.register_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seePass = new System.Windows.Forms.CheckBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_label.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.register_label.ForeColor = System.Drawing.Color.DarkViolet;
            this.register_label.Location = new System.Drawing.Point(160, 544);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(62, 22);
            this.register_label.TabIndex = 23;
            this.register_label.Text = "ثبت نام";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(135, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "هنوز ثبت نام نکردی؟";
            // 
            // seePass
            // 
            this.seePass.AutoSize = true;
            this.seePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePass.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.seePass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.seePass.Location = new System.Drawing.Point(185, 400);
            this.seePass.Name = "seePass";
            this.seePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seePass.Size = new System.Drawing.Size(112, 20);
            this.seePass.TabIndex = 21;
            this.seePass.Text = "مشاهده رمز عبور";
            this.seePass.UseVisualStyleBackColor = true;
            this.seePass.CheckedChanged += new System.EventHandler(this.seePass_CheckedChanged);
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWord.Location = new System.Drawing.Point(69, 366);
            this.passWord.Multiline = true;
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passWord.Size = new System.Drawing.Size(244, 28);
            this.passWord.TabIndex = 20;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.DarkViolet;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(69, 444);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(244, 47);
            this.login.TabIndex = 19;
            this.login.Text = "ورود";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(265, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "رمز عبور";
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Location = new System.Drawing.Point(69, 303);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userName.Size = new System.Drawing.Size(244, 28);
            this.userName.TabIndex = 17;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(252, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "نام کاربری";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANBlack", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(138, 222);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "آرایشگران";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.back.ForeColor = System.Drawing.Color.DarkViolet;
            this.back.Location = new System.Drawing.Point(117, 598);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 22);
            this.back.TabIndex = 24;
            this.back.Text = "بازگشت به منو اصلی";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(102, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // LoginStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(383, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seePass);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginStaff";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox seePass;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}