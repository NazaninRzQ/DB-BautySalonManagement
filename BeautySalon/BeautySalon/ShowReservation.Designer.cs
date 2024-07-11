namespace BeautySalon
{
    partial class ShowReservation
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
            this.reserving = new System.Windows.Forms.Label();
            this.entercode = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.custName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Service = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reserving
            // 
            this.reserving.AutoSize = true;
            this.reserving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserving.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.reserving.Location = new System.Drawing.Point(161, 29);
            this.reserving.Name = "reserving";
            this.reserving.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reserving.Size = new System.Drawing.Size(241, 25);
            this.reserving.TabIndex = 23;
            this.reserving.Text = "مشاهده نوبت های ثبت شده";
            // 
            // entercode
            // 
            this.entercode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.entercode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entercode.Location = new System.Drawing.Point(151, 118);
            this.entercode.Multiline = true;
            this.entercode.Name = "entercode";
            this.entercode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.entercode.Size = new System.Drawing.Size(366, 34);
            this.entercode.TabIndex = 65;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkViolet;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search.Location = new System.Drawing.Point(31, 118);
            this.search.Name = "search";
            this.search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.search.Size = new System.Drawing.Size(114, 34);
            this.search.TabIndex = 64;
            this.search.Text = "جستجو";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(306, 92);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(207, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "کد پرسنلی خود را وارد کنید :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.custName,
            this.PhoneNum,
            this.Date,
            this.Service,
            this.StaffName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 180);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 202);
            this.listView1.TabIndex = 66;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // custName
            // 
            this.custName.Text = "CustName";
            this.custName.Width = 111;
            // 
            // PhoneNum
            // 
            this.PhoneNum.Text = "PhoneNum";
            this.PhoneNum.Width = 96;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 78;
            // 
            // Service
            // 
            this.Service.Text = "Service";
            this.Service.Width = 104;
            // 
            // StaffName
            // 
            this.StaffName.Text = "StaffName";
            this.StaffName.Width = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(31, 406);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "بازگشت";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ShowReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.entercode);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reserving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ShowReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reserving;
        private System.Windows.Forms.TextBox entercode;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader custName;
        private System.Windows.Forms.ColumnHeader PhoneNum;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Service;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.Label label5;
    }
}