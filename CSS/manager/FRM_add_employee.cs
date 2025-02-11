using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS.manager
{
    public partial class FRM_add_employee : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();
        public FRM_add_employee()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_add_employee_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtUsername.Select();
            txtUsername.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text!=""&& txtPassword.Text != "")
            {
                Login Create_Account = new Login();
                Create_Account.UserName = txtUsername.Text;
                Create_Account.Password = txtPassword.Text;
                if (rad_Employee.Checked==true)
                {
                    Create_Account.job = "Employee";
                    //BL.Manager.Add_Employee(Create_Account);
                    Civ.Logins.Add(Create_Account);
                    Civ.SaveChanges();
                }
                else if (rad_Manager.Checked == true)
                {
                    Create_Account.job = "Manager";
                    BL.Manager.Add_Employee(Create_Account);
                }
                else
                {
                    MessageBox.Show("لا يمكن اضافه هذا الحساب بدون مسمى وظيفي ");
                }

            }
            else
            {
                MessageBox.Show("لايمكن قيول خانات فارغه اعد المحاوله مع ملى جميع الخانات  ");

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
