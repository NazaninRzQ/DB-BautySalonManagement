namespace BeautySalon
{
    partial class EditReservation
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.ComboBox();
            this.service = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(150, 27);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "تغییر و لغو نوبت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(37, 664);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "بازگشت";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkViolet;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(46, 141);
            this.search.Name = "search";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.Size = new System.Drawing.Size(114, 34);
            this.search.TabIndex = 45;
            this.search.Text = "جستجو";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.des_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(197, 83);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(222, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "کد رهگیری نوبت را وارد کنید :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(148, 206);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "نوبت ثبت شده شما";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(243, 490);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "نام خدمت دهنده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(278, 436);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "نوع خدمت :";
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ControlLight;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.Location = new System.Drawing.Point(105, 393);
            this.date.Multiline = true;
            this.date.Name = "date";
            this.date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.date.Size = new System.Drawing.Size(244, 28);
            this.date.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(277, 374);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "تاریخ نوبت :";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Location = new System.Drawing.Point(105, 333);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.phone.Size = new System.Drawing.Size(244, 28);
            this.phone.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(278, 314);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "شماره تلفن :";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Location = new System.Drawing.Point(105, 273);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(244, 28);
            this.name.TabIndex = 51;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.userName.Location = new System.Drawing.Point(241, 252);
            this.userName.Name = "userName";
            this.userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userName.Size = new System.Drawing.Size(111, 16);
            this.userName.TabIndex = 50;
            this.userName.Text = "نام و نام خانوادگی :";
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkViolet;
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edit.Location = new System.Drawing.Point(105, 556);
            this.edit.Name = "edit";
            this.edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.edit.Size = new System.Drawing.Size(89, 34);
            this.edit.TabIndex = 60;
            this.edit.Text = "ویرایش";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.SeaShell;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.delete.Location = new System.Drawing.Point(204, 556);
            this.delete.Name = "delete";
            this.delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.delete.Size = new System.Drawing.Size(89, 34);
            this.delete.TabIndex = 61;
            this.delete.Text = "حذف";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reserve
            // 
            this.reserve.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reserve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserve.Location = new System.Drawing.Point(49, 107);
            this.reserve.Multiline = true;
            this.reserve.Name = "reserve";
            this.reserve.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reserve.Size = new System.Drawing.Size(366, 28);
            this.reserve.TabIndex = 62;
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.SystemColors.ControlLight;
            this.server.FormattingEnabled = true;
            this.server.Location = new System.Drawing.Point(105, 509);
            this.server.Name = "server";
            this.server.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.server.Size = new System.Drawing.Size(244, 24);
            this.server.TabIndex = 63;
            // 
            // service
            // 
            this.service.BackColor = System.Drawing.SystemColors.ControlLight;
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(105, 455);
            this.service.Name = "service";
            this.service.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.service.Size = new System.Drawing.Size(244, 24);
            this.service.TabIndex = 64;
            // 
            // EditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(466, 717);
            this.Controls.Add(this.service);
            this.Controls.Add(this.server);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "EditReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox reserve;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.ComboBox service;
    }
}