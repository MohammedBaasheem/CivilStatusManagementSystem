namespace CSS.manager
{
    partial class FRM_manage
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
            this.pnl_employees = new System.Windows.Forms.Panel();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.employees_data = new System.Windows.Forms.DataGridView();
            this.pnl_employees.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees_data)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_employees
            // 
            this.pnl_employees.Controls.Add(this.pnl_footer);
            this.pnl_employees.Controls.Add(this.employees_data);
            this.pnl_employees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_employees.Location = new System.Drawing.Point(0, 0);
            this.pnl_employees.Name = "pnl_employees";
            this.pnl_employees.Size = new System.Drawing.Size(1028, 667);
            this.pnl_employees.TabIndex = 0;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_footer.Controls.Add(this.txtSearch);
            this.pnl_footer.Controls.Add(this.label1);
            this.pnl_footer.Controls.Add(this.btn_add);
            this.pnl_footer.Controls.Add(this.btn_delete);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 591);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1028, 76);
            this.pnl_footer.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 16F);
            this.txtSearch.Location = new System.Drawing.Point(36, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(253, 43);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(75, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "بحث :";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btn_add.Location = new System.Drawing.Point(679, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(151, 47);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "إضافة موظف";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btn_delete.Location = new System.Drawing.Point(836, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 47);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "حذف موظف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // employees_data
            // 
            this.employees_data.AllowUserToAddRows = false;
            this.employees_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employees_data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.employees_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees_data.Location = new System.Drawing.Point(36, 37);
            this.employees_data.Name = "employees_data";
            this.employees_data.RowTemplate.Height = 26;
            this.employees_data.Size = new System.Drawing.Size(951, 497);
            this.employees_data.TabIndex = 9;
            // 
            // FRM_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 667);
            this.Controls.Add(this.pnl_employees);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FRM_manage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_manage";
            this.Load += new System.EventHandler(this.FRM_manage_Load);
            this.pnl_employees.ResumeLayout(false);
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employees_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_footer;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.DataGridView employees_data;
        public System.Windows.Forms.Panel pnl_employees;
    }
}