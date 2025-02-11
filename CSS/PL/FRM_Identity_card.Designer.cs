namespace CSS.PL
{
    partial class FRM_Identity_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Identity_card));
            this.pnl_identity_card = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.Button();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.customer_info = new System.Windows.Forms.GroupBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBlood = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthNum2 = new System.Windows.Forms.TextBox();
            this.txtBirthNum = new System.Windows.Forms.TextBox();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.show_data = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnl_identity_card.SuspendLayout();
            this.customer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_identity_card
            // 
            this.pnl_identity_card.Controls.Add(this.txt_search);
            this.pnl_identity_card.Controls.Add(this.dt_end);
            this.pnl_identity_card.Controls.Add(this.label10);
            this.pnl_identity_card.Controls.Add(this.line);
            this.pnl_identity_card.Controls.Add(this.customer_info);
            this.pnl_identity_card.Controls.Add(this.txtBirthNum2);
            this.pnl_identity_card.Controls.Add(this.txtBirthNum);
            this.pnl_identity_card.Controls.Add(this.releaseDate);
            this.pnl_identity_card.Controls.Add(this.label1);
            this.pnl_identity_card.Controls.Add(this.txtID);
            this.pnl_identity_card.Controls.Add(this.pnl_footer);
            this.pnl_identity_card.Controls.Add(this.label9);
            this.pnl_identity_card.Controls.Add(this.label8);
            this.pnl_identity_card.Controls.Add(this.label7);
            this.pnl_identity_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_identity_card.Location = new System.Drawing.Point(0, 0);
            this.pnl_identity_card.Name = "pnl_identity_card";
            this.pnl_identity_card.Size = new System.Drawing.Size(1054, 667);
            this.pnl_identity_card.TabIndex = 0;
            this.pnl_identity_card.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_identity_card_Paint);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(106, 26);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(210, 48);
            this.txt_search.TabIndex = 13;
            this.txt_search.Text = "إبحث عن شهادة";
            this.txt_search.UseVisualStyleBackColor = false;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(523, 553);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(289, 37);
            this.dt_end.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(826, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "تاريخ الانتهاء:";
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(-9, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1037, 27);
            this.line.TabIndex = 10;
            this.line.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // customer_info
            // 
            this.customer_info.Controls.Add(this.btnAddPic);
            this.customer_info.Controls.Add(this.pictureBox1);
            this.customer_info.Controls.Add(this.txtBlood);
            this.customer_info.Controls.Add(this.txtBirthPlace);
            this.customer_info.Controls.Add(this.birthDate);
            this.customer_info.Controls.Add(this.txtPersonName);
            this.customer_info.Controls.Add(this.label4);
            this.customer_info.Controls.Add(this.label5);
            this.customer_info.Controls.Add(this.label6);
            this.customer_info.Controls.Add(this.label2);
            this.customer_info.Controls.Add(this.label3);
            this.customer_info.Location = new System.Drawing.Point(49, 110);
            this.customer_info.Name = "customer_info";
            this.customer_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customer_info.Size = new System.Drawing.Size(934, 334);
            this.customer_info.TabIndex = 9;
            this.customer_info.TabStop = false;
            this.customer_info.Text = "بيانات الشخص";
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPic.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Location = new System.Drawing.Point(64, 281);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(210, 42);
            this.btnAddPic.TabIndex = 6;
            this.btnAddPic.Text = "إضافة صورة";
            this.btnAddPic.UseVisualStyleBackColor = false;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(64, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtBlood
            // 
            this.txtBlood.Location = new System.Drawing.Point(434, 218);
            this.txtBlood.Name = "txtBlood";
            this.txtBlood.Size = new System.Drawing.Size(329, 37);
            this.txtBlood.TabIndex = 4;
            this.txtBlood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.Location = new System.Drawing.Point(432, 97);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(329, 37);
            this.txtBirthPlace.TabIndex = 4;
            this.txtBirthPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(429, 156);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(332, 37);
            this.birthDate.TabIndex = 3;
            // 
            // txtPersonName
            // 
            this.txtPersonName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPersonName.Location = new System.Drawing.Point(64, 38);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(697, 37);
            this.txtPersonName.TabIndex = 2;
            this.txtPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "تاريخ الميلاد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "فصيلة الدم :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "الصورة الشخصية :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "مكان الميلاد :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "الأسم الرباعي :";
            // 
            // txtBirthNum2
            // 
            this.txtBirthNum2.Location = new System.Drawing.Point(115, 507);
            this.txtBirthNum2.Name = "txtBirthNum2";
            this.txtBirthNum2.Size = new System.Drawing.Size(201, 37);
            this.txtBirthNum2.TabIndex = 4;
            this.txtBirthNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBirthNum
            // 
            this.txtBirthNum.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtBirthNum.Location = new System.Drawing.Point(322, 26);
            this.txtBirthNum.Name = "txtBirthNum";
            this.txtBirthNum.Size = new System.Drawing.Size(488, 46);
            this.txtBirthNum.TabIndex = 8;
            this.txtBirthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBirthNum.TextChanged += new System.EventHandler(this.txtBirthNum_TextChanged);
            // 
            // releaseDate
            // 
            this.releaseDate.Location = new System.Drawing.Point(523, 508);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(289, 37);
            this.releaseDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label1.Location = new System.Drawing.Point(811, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "ادخل رقم شهادة الميلاد :";
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtID.Location = new System.Drawing.Point(115, 457);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(697, 37);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_footer.Controls.Add(this.show_data);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 598);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1054, 69);
            this.pnl_footer.TabIndex = 6;
            this.pnl_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_footer_Paint);
            // 
            // show_data
            // 
            this.show_data.BackColor = System.Drawing.Color.White;
            this.show_data.Location = new System.Drawing.Point(478, 16);
            this.show_data.Name = "show_data";
            this.show_data.Size = new System.Drawing.Size(144, 41);
            this.show_data.TabIndex = 2;
            this.show_data.Text = "عرض البيانات";
            this.show_data.UseVisualStyleBackColor = false;
            this.show_data.Click += new System.EventHandler(this.show_data_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(826, 13);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(155, 42);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(650, 13);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(155, 42);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "طباعة البطاقة";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "رقم شهادة الميلاد :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(826, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "تاريخ الأصدار :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(826, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "الرقم الوطني :";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FRM_Identity_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 667);
            this.Controls.Add(this.pnl_identity_card);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_Identity_card";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Identity_card";
            this.Load += new System.EventHandler(this.FRM_Identity_card_Load);
            this.pnl_identity_card.ResumeLayout(false);
            this.pnl_identity_card.PerformLayout();
            this.customer_info.ResumeLayout(false);
            this.customer_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_identity_card;
        public System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button show_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox customer_info;
        public System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label line;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBlood;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBirthNum2;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBirthNum;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txt_search;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}