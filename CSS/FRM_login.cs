using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSS
{
    public partial class FRM_login : Form
    {
        public FRM_login()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.Select();
            txtUsername.SelectAll();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                var data = BL.Login_Controller.Search_For_Manager_or_Employee(txtUsername.Text, txtPassword.Text);
                if (data == null)
                {
                    MessageBox.Show("هذا الحساب غير موجود");
                }
                else if (data != null)
                {
                    if (data.job == "Manager")
                    {
                        Main min = new Main();
                        min.btn_employees.Visible = true;
                        min.ShowDialog();

                    }
                    else
                    {
                        Main min = new Main();
                        min.btn_employees.Visible = false;
                        min.ShowDialog();
                    }

                }
            }
            
            
        }
    }
}
