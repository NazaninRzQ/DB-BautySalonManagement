namespace BeautySalon
{
    partial class Services
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
            this.label8 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(132, 44);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "معرفی خدمات آرایشگاه";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(166, 101);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(264, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "خدمت مورد نظر خود را انتخاب کنید:";
            // 
            // service
            // 
            this.service.FormattingEnabled = true;
            this.service.Location = new System.Drawing.Point(57, 132);
            this.service.Name = "service";
            this.service.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.service.Size = new System.Drawing.Size(369, 24);
            this.service.TabIndex = 39;
            this.service.SelectedIndexChanged += new System.EventHandler(this.service_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(24, 442);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "بازگشت";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("IRANSansMobile(FaNum) Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(57, 215);
            this.label9.MaximumSize = new System.Drawing.Size(360, 300);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(28, 22);
            this.label9.TabIndex = 41;
            this.label9.Text = "...";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // des
            // 
            this.des.BackColor = System.Drawing.Color.DarkViolet;
            this.des.Cursor = System.Windows.Forms.Cursors.Hand;
            this.des.Font = new System.Drawing.Font("IRANSansMobile(FaNum)", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.des.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.des.Location = new System.Drawing.Point(57, 166);
            this.des.Name = "des";
            this.des.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.des.Size = new System.Drawing.Size(114, 34);
            this.des.TabIndex = 42;
            this.des.Text = "توضیحات";
            this.des.UseVisualStyleBackColor = false;
            this.des.Click += new System.EventHandler(this.des_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(469, 490);
            this.Controls.Add(this.des);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.service);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox service;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button des;
    }
}