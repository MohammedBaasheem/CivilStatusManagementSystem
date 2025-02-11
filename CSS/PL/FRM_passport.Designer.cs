namespace CSS.PL
{
    partial class FRM_passport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_passport));
            this.pnl_passport = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.Button();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.show_data = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.txtBirthNum2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.line = new System.Windows.Forms.Label();
            this.customer_info = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBirthNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.releaseDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnl_passport.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.customer_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_passport
            // 
            this.pnl_passport.Controls.Add(this.txt_search);
            this.pnl_passport.Controls.Add(this.dt_end);
            this.pnl_passport.Controls.Add(this.label12);
            this.pnl_passport.Controls.Add(this.pnl_footer);
            this.pnl_passport.Controls.Add(this.txtBirthNum2);
            this.pnl_passport.Controls.Add(this.label11);
            this.pnl_passport.Controls.Add(this.txtPassportNum);
            this.pnl_passport.Controls.Add(this.line);
            this.pnl_passport.Controls.Add(this.customer_info);
            this.pnl_passport.Controls.Add(this.txtBirthNum);
            this.pnl_passport.Controls.Add(this.label1);
            this.pnl_passport.Controls.Add(this.label10);
            this.pnl_passport.Controls.Add(this.releaseDate);
            this.pnl_passport.Controls.Add(this.label9);
            this.pnl_passport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_passport.Location = new System.Drawing.Point(0, 0);
            this.pnl_passport.Name = "pnl_passport";
            this.pnl_passport.Size = new System.Drawing.Size(1028, 667);
            this.pnl_passport.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.Location = new System.Drawing.Point(111, 28);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(210, 48);
            this.txt_search.TabIndex = 18;
            this.txt_search.Text = "إبحث عن شهادة";
            this.txt_search.UseVisualStyleBackColor = false;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // dt_end
            // 
            this.dt_end.Location = new System.Drawing.Point(473, 553);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(332, 37);
            this.dt_end.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(819, 563);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 29);
            this.label12.TabIndex = 16;
            this.label12.Text = "تاريخ الانتهاء";
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_footer.Controls.Add(this.show_data);
            this.pnl_footer.Controls.Add(this.btn_save);
            this.pnl_footer.Controls.Add(this.btn_print);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 599);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1028, 68);
            this.pnl_footer.TabIndex = 15;
            this.pnl_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_footer_Paint);
            // 
            // show_data
            // 
            this.show_data.BackColor = System.Drawing.Color.White;
            this.show_data.Location = new System.Drawing.Point(678, 15);
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
            this.btn_save.Location = new System.Drawing.Point(828, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(148, 42);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btn_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btn_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btn_print.Font = new System.Drawing.Font("Times New Roman", 1F);
            this.btn_print.Location = new System.Drawing.Point(51, 48);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(10, 10);
            this.btn_print.TabIndex = 0;
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // txtBirthNum2
            // 
            this.txtBirthNum2.Location = new System.Drawing.Point(108, 510);
            this.txtBirthNum2.Name = "txtBirthNum2";
            this.txtBirthNum2.Size = new System.Drawing.Size(185, 37);
            this.txtBirthNum2.TabIndex = 14;
            this.txtBirthNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "رقم شهادة الميلاد :";
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Location = new System.Drawing.Point(108, 468);
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(698, 37);
            this.txtPassportNum.TabIndex = 12;
            this.txtPassportNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(-4, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1037, 17);
            this.line.TabIndex = 11;
            this.line.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // customer_info
            // 
            this.customer_info.Controls.Add(this.comboBox1);
            this.customer_info.Controls.Add(this.btnAddPic);
            this.customer_info.Controls.Add(this.pictureBox1);
            this.customer_info.Controls.Add(this.textBox1);
            this.customer_info.Controls.Add(this.txtProfession);
            this.customer_info.Controls.Add(this.birthDate);
            this.customer_info.Controls.Add(this.txtPersonName);
            this.customer_info.Controls.Add(this.label7);
            this.customer_info.Controls.Add(this.label8);
            this.customer_info.Controls.Add(this.label4);
            this.customer_info.Controls.Add(this.label5);
            this.customer_info.Controls.Add(this.label6);
            this.customer_info.Controls.Add(this.label3);
            this.customer_info.Location = new System.Drawing.Point(42, 102);
            this.customer_info.Name = "customer_info";
            this.customer_info.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customer_info.Size = new System.Drawing.Size(934, 350);
            this.customer_info.TabIndex = 11;
            this.customer_info.TabStop = false;
            this.customer_info.Text = "بيانات الشخص";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.comboBox1.Location = new System.Drawing.Point(435, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 37);
            this.comboBox1.TabIndex = 7;
            // 
            // btnAddPic
            // 
            this.btnAddPic.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddPic.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnAddPic.ForeColor = System.Drawing.Color.White;
            this.btnAddPic.Location = new System.Drawing.Point(66, 302);
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
            this.pictureBox1.Location = new System.Drawing.Point(66, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(434, 120);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(329, 37);
            this.txtProfession.TabIndex = 4;
            this.txtProfession.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(434, 229);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(332, 37);
            this.birthDate.TabIndex = 3;
            // 
            // txtPersonName
            // 
            this.txtPersonName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPersonName.Location = new System.Drawing.Point(66, 34);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(697, 37);
            this.txtPersonName.TabIndex = 2;
            this.txtPersonName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(777, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "محل الميلاد :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "الجنس :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "تاريخ الميلاد :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "المهنة :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "الصورة الشخصية :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "الأسم الثلاثي :";
            // 
            // txtBirthNum
            // 
            this.txtBirthNum.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtBirthNum.Location = new System.Drawing.Point(327, 27);
            this.txtBirthNum.Multiline = true;
            this.txtBirthNum.Name = "txtBirthNum";
            this.txtBirthNum.Size = new System.Drawing.Size(478, 50);
            this.txtBirthNum.TabIndex = 10;
            this.txtBirthNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label1.Location = new System.Drawing.Point(806, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "ادخل رقم شهادة الميلاد :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(819, 471);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "رقم جواز السفر :";
            // 
            // releaseDate
            // 
            this.releaseDate.Location = new System.Drawing.Point(473, 509);
            this.releaseDate.Name = "releaseDate";
            this.releaseDate.Size = new System.Drawing.Size(332, 37);
            this.releaseDate.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(819, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "تاريخ الاصدار :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FRM_passport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 667);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_passport);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_passport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_passport";
            this.pnl_passport.ResumeLayout(false);
            this.pnl_passport.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.customer_info.ResumeLayout(false);
            this.customer_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnl_passport;
        public System.Windows.Forms.TextBox txtBirthNum;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox customer_info;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.DateTimePicker birthDate;
        public System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label line;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker releaseDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirthNum2;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button show_data;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button txt_search;
    }
}