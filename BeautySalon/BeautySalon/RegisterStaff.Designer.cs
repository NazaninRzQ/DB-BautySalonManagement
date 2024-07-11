namespace BeautySalon
{
    partial class RegisterStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStaff));
            this.seePass = new System.Windows.Forms.CheckBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.confirmPassL = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.s_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seePass
            // 
            this.seePass.AutoSize = true;
            this.seePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePass.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.seePass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.seePass.Location = new System.Drawing.Point(177, 513);
            this.seePass.Name = "seePass";
            this.seePass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.seePass.Size = new System.Drawing.Size(112, 20);
            this.seePass.TabIndex = 38;
            this.seePass.Text = "مشاهده رمز عبور";
            this.seePass.UseVisualStyleBackColor = true;
            this.seePass.CheckedChanged += new System.EventHandler(this.seePass_CheckedChanged);
            // 
            // confirmPass
            // 
            this.confirmPass.BackColor = System.Drawing.SystemColors.ControlLight;
            this.confirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPass.Location = new System.Drawing.Point(60, 479);
            this.confirmPass.Multiline = true;
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.PasswordChar = '*';
            this.confirmPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmPass.Size = new System.Drawing.Size(244, 28);
            this.confirmPass.TabIndex = 37;
            // 
            // confirmPassL
            // 
            this.confirmPassL.AutoSize = true;
            this.confirmPassL.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.confirmPassL.Location = new System.Drawing.Point(226, 460);
            this.confirmPassL.Name = "confirmPassL";
            this.confirmPassL.Size = new System.Drawing.Size(75, 16);
            this.confirmPassL.TabIndex = 36;
            this.confirmPassL.Text = "تکرار رمز عبور";
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginlabel.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.loginlabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.loginlabel.Location = new System.Drawing.Point(164, 644);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(39, 22);
            this.loginlabel.TabIndex = 35;
            this.loginlabel.Text = "ورود";
            this.loginlabel.Click += new System.EventHandler(this.loginlabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(130, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "قبلا ثبت نام کردی؟";
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWord.Location = new System.Drawing.Point(60, 415);
            this.passWord.Multiline = true;
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passWord.Size = new System.Drawing.Size(244, 28);
            this.passWord.TabIndex = 33;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.DarkViolet;
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.register.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(60, 553);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(244, 47);
            this.register.TabIndex = 32;
            this.register.Text = "ثبت نام";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(256, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "رمز عبور";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(60, 296);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(244, 28);
            this.name.TabIndex = 30;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userName.Location = new System.Drawing.Point(201, 277);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(103, 16);
            this.userName.TabIndex = 29;
            this.userName.Text = "نام و نام خانوادگی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANBlack", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(140, 177);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 28;
            this.label1.Text = "آرایشگران";
            
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(151, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "چه خدمتی را ارائه می‌دهید؟";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.back.ForeColor = System.Drawing.Color.DarkViolet;
            this.back.Location = new System.Drawing.Point(108, 702);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 22);
            this.back.TabIndex = 46;
            this.back.Text = "بازگشت به منو اصلی";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // s_username
            // 
            this.s_username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.s_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.s_username.Location = new System.Drawing.Point(60, 243);
            this.s_username.Multiline = true;
            this.s_username.Name = "s_username";
            this.s_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.s_username.Size = new System.Drawing.Size(244, 28);
            this.s_username.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(243, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "نام کاربری";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(116, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(365, 756);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.s_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seePass);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.confirmPassL);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterStaff";
            this.Load += new System.EventHandler(this.RegisterStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox seePass;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.Label confirmPassL;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.TextBox s_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}