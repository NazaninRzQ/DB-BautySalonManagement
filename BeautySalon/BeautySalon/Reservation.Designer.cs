namespace BeautySalon
{
    partial class Reservation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.ComboBox();
            this.server = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(165, 38);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ثبت نوبت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(28, 481);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "بازگشت";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.BackColor = System.Drawing.Color.DarkViolet;
            this.InsertBtn.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.InsertBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InsertBtn.Location = new System.Drawing.Point(83, 394);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(244, 45);
            this.InsertBtn.TabIndex = 39;
            this.InsertBtn.Text = "ثبت نوبت";
            this.InsertBtn.UseVisualStyleBackColor = false;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(83, 121);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(244, 28);
            this.name.TabIndex = 38;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userName.Location = new System.Drawing.Point(219, 100);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userName.Size = new System.Drawing.Size(111, 16);
            this.userName.TabIndex = 37;
            this.userName.Text = "نام و نام خانوادگی :";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Location = new System.Drawing.Point(83, 181);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(244, 28);
            this.phone.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(256, 162);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "شماره تلفن :";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.Location = new System.Drawing.Point(83, 241);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date.Size = new System.Drawing.Size(244, 28);
            this.date.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(255, 222);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "تاریخ نوبت :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(256, 284);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "نوع خدمت :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(221, 338);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "نام خدمت دهنده :";
            // 
            // service
            // 
            this.service.BackColor = System.Drawing.SystemColors.ControlLight;
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(83, 303);
            this.service.Name = "service";
            this.service.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.service.Size = new System.Drawing.Size(244, 24);
            this.service.TabIndex = 50;
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.SystemColors.ControlLight;
            this.server.FormattingEnabled = true;
            this.server.Location = new System.Drawing.Point(83, 357);
            this.server.Name = "server";
            this.server.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.server.Size = new System.Drawing.Size(244, 24);
            this.server.TabIndex = 51;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(418, 531);
            this.Controls.Add(this.server);
            this.Controls.Add(this.service);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.ComboBox server;
    }
}