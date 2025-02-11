namespace CSS.PL
{
    partial class FRM_citizens_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_citizens_data));
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.born_title = new System.Windows.Forms.Label();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID_card_data = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_card_data)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.born_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 52);
            this.panel2.TabIndex = 4;
            // 
            // exit_btn
            // 
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(28, 12);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(47, 28);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit_btn.TabIndex = 1;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // born_title
            // 
            this.born_title.AutoSize = true;
            this.born_title.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.born_title.Location = new System.Drawing.Point(815, 9);
            this.born_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.born_title.Name = "born_title";
            this.born_title.Size = new System.Drawing.Size(311, 34);
            this.born_title.TabIndex = 0;
            this.born_title.Text = "السجل المدني للبطائق الشخصية";
            this.born_title.Click += new System.EventHandler(this.born_title_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_footer.Controls.Add(this.txtSearch);
            this.pnl_footer.Controls.Add(this.label1);
            this.pnl_footer.Controls.Add(this.btn_update);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 665);
            this.pnl_footer.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1175, 85);
            this.pnl_footer.TabIndex = 5;
            this.pnl_footer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_footer_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtSearch.Location = new System.Drawing.Point(29, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(288, 43);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث :";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btn_update.Location = new System.Drawing.Point(891, 19);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(244, 53);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "تجديد بيانات المواطن";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(31, 588);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 31);
            this.panel1.TabIndex = 7;
            // 
            // ID_card_data
            // 
            this.ID_card_data.AllowUserToAddRows = false;
            this.ID_card_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ID_card_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ID_card_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ID_card_data.Location = new System.Drawing.Point(29, 71);
            this.ID_card_data.Margin = new System.Windows.Forms.Padding(4);
            this.ID_card_data.Name = "ID_card_data";
            this.ID_card_data.RowTemplate.Height = 26;
            this.ID_card_data.Size = new System.Drawing.Size(1115, 510);
            this.ID_card_data.TabIndex = 6;
            // 
            // FRM_citizens_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 750);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ID_card_data);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_citizens_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_citizens_data";
            this.Load += new System.EventHandler(this.FRM_citizens_data_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ID_card_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox exit_btn;
        public System.Windows.Forms.Label born_title;
        private System.Windows.Forms.Panel pnl_footer;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView ID_card_data;
    }
}