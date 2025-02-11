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
    public partial class FRM_manage : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();
        public FRM_manage()
        {
            InitializeComponent();
            Fill_Data_grid();
        }
        public void Fill_Data_grid()
        {
            employees_data.DataSource = Civ.Logins.ToList();
            employees_data.Columns[0].Visible = false;
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_manage_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
            Fill_Data_grid();
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            manager.FRM_add_employee add_employee = new manager.FRM_add_employee();
            add_employee.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int ID_Employee =int.Parse(employees_data.CurrentRow.Cells["ID_User"].Value.ToString());
            BL.Manager.Delete_Employee(ID_Employee);
            MessageBox.Show("تم حدف الموظف بنجاح");
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text=="")
            {
                Fill_Data_grid();
            }
            else
            {
                var Some_Data = Civ.Logins.Where(x => x.UserName.Contains(txtSearch.Text) || x.Password.Contains(txtSearch.Text) || x.job.Contains(txtSearch.Text)).ToList();
                employees_data.DataSource = Some_Data;
                employees_data.Columns[0].Visible = false;
            }
        }
    }
}
