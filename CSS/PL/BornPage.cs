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
    public partial class BornPage : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();
        public void Fill_DataGrid()
        {
            //born_data.DataSource = Civ.Birth_Certificates.ToList();
            born_data.DataSource = (from card in Civ.Birth_Certificates
                                    select new
                                    {
                                        fullname = card.Born_name,
                                        Picture = card.Father_name,
                                        Rel_date = card.Grand_last_name,
                                        poold = card.Mother_name,
                                        end_date = card.Nationality,
                                        father_religion = card.Religion_Father,
                                        born_date = card.Birth_date,
                                        born_place = card.Birth_place,
                                    }).ToList();

            born_data.Columns[0].HeaderText = "اسم المولود";
            born_data.Columns[1].HeaderText = "اسم الأب" ;
            born_data.Columns[2].HeaderText = "اسم الجد واللقب";
            born_data.Columns[3].HeaderText = "الجنسية";
            born_data.Columns[4].HeaderText =  "ديانة الأب";
            born_data.Columns[5].HeaderText = "تاريخ الميلاد";
            born_data.Columns[6].HeaderText = "مكان الميلاد";

        }
        public BornPage()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BornPage_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
            Fill_DataGrid();
        }

        private void pnl_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Fill_DataGrid();
            }
            else
            {
                born_data.DataSource = Civ.Birth_Certificates.Where(x => x.Born_name.Contains(txtSearch.Text) || x.Father_name.Contains(txtSearch.Text) || x.Address.Contains(txtSearch.Text)).ToList();
                born_data.DataSource = (from card in Civ.Birth_Certificates
                                        where card.Born_name.Contains(txtSearch.Text) || card.Father_name.Contains(txtSearch.Text) || card.Grand_last_name.Contains(txtSearch.Text) || card.Mother_name.Contains(txtSearch.Text) || card.Nationality.Contains(txtSearch.Text) || card.Religion_Father.Contains(txtSearch.Text) || card.Birth_date.ToString().Contains(txtSearch.Text) || card.Birth_place.Contains(txtSearch.Text)
                                        select new
                                        {
                                            fullname = card.Born_name,
                                            Picture = card.Father_name,
                                            Rel_date = card.Grand_last_name,
                                            poold = card.Mother_name,
                                            end_date = card.Nationality,
                                            father_religion = card.Religion_Father,
                                            born_date = card.Birth_date,
                                            born_place = card.Birth_place,
                                        }).ToList();

                born_data.Columns[0].HeaderText = "اسم المولود";
                born_data.Columns[1].HeaderText = "اسم الأب";
                born_data.Columns[2].HeaderText = "اسم الجد واللقب";
                born_data.Columns[3].HeaderText = "الجنسية";
                born_data.Columns[4].HeaderText = "ديانة الأب";
                born_data.Columns[5].HeaderText = "تاريخ الميلاد";
                born_data.Columns[6].HeaderText = "مكان الميلاد";
            }
        }
    }
}
