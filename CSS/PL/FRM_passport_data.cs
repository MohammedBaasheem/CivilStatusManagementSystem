using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSS.PL
{
    public partial class FRM_passport_data : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();
        public FRM_passport_data()
        {
            InitializeComponent();
        }
        void Fill_Data_Grid()
        {
            passport_data.DataSource = (from x in Civ.Passports
                                        select new
                                        {
                                            pic = x.Personal_Picture,
                                            fullname = x.The_Third_Name,
                                            job=x.Occupation,
                                            re_date=x.Release_date,
                                            end_date=x.End_Date,
                                           num=x.ID_Passport_Number,


                                        }).ToList();
            passport_data.Columns[0].HeaderText = "الصوره الشخصية";
            passport_data.Columns[1].HeaderText = "الاسم الثلاثي";
            passport_data.Columns[2].HeaderText = "المهنة";
            passport_data.Columns[3].HeaderText = "تاريخ الاصدار";
            passport_data.Columns[4].HeaderText = "تاريخ الانتهاء";
            passport_data.Columns[5].HeaderText = "رقم الجواز";

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_passport_data_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
            Fill_Data_Grid();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PL.FRM_update_passport frm__update_passport = new PL.FRM_update_passport();
            frm__update_passport.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Fill_Data_Grid();
            }
            else
            {
                passport_data.DataSource = (from x in Civ.Passports
                                            where x.ID_Passport_Number.Contains(txtSearch.Text) || x.The_Third_Name.Contains(txtSearch.Text) || x.Occupation.Contains(txtSearch.Text) || x.Release_date.ToString().Contains(txtSearch.Text) || x.End_Date.ToString().Contains(txtSearch.Text)
                                            select new
                                            {
                                                pic = x.Personal_Picture,
                                                fullname = x.The_Third_Name,
                                                job = x.Occupation,
                                                re_date = x.Release_date,
                                                end_date = x.End_Date,
                                                num = x.ID_Passport_Number,
                                            }).ToList();
                passport_data.Columns[0].HeaderText = "الصوره الشخصية";
                passport_data.Columns[1].HeaderText = "الاسم الثلاثي";
                passport_data.Columns[2].HeaderText = "المهنة";
                passport_data.Columns[3].HeaderText = "تاريخ الاصدار";
                passport_data.Columns[4].HeaderText = "تاريخ الانتهاء";
                passport_data.Columns[5].HeaderText = "رقم الجواز";

            }
        }
    }
}
