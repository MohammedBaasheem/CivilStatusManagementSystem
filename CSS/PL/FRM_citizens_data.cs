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
    public partial class FRM_citizens_data : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();

        public FRM_citizens_data()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FRM_citizens_data_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();
            txtSearch.SelectAll();
            Fill_DataGrid();
        }
        void Fill_DataGrid()
        {
            ID_card_data.DataSource =( from card in Civ.Identification_Cards
                                      select new
                                      {
                                          fullname = card.Quadruple_Name,
                                          Picture = card.Personal_Picture,
                                          poold = card.Blood_Type,
                                          Rel_date = card.Release_Date,
                                          end_date = card.End_Date

                                      }).ToList();

            ID_card_data.Columns[0].HeaderText = "الاسم الرباعي";
            ID_card_data.Columns[1].HeaderText = "الصورة الشخصية";
            ID_card_data.Columns[2].HeaderText = "فصيلة الدم ";
            ID_card_data.Columns[3].HeaderText = "تاريخ الاصدار";
            ID_card_data.Columns[4].HeaderText = "تاريخ الانتهاء";
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
           PL.FRM_update_IdCard frm_update_IdCard = new PL.FRM_update_IdCard();
            frm_update_IdCard.ShowDialog();
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                Fill_DataGrid();
            }
            else
            {
                ID_card_data.DataSource = (from card in Civ.Identification_Cards
                                           where card.ID_Number == txtSearch.Text || card.Quadruple_Name.Contains(txtSearch.Text) || card.End_Date.ToString() == txtSearch.Text || card.Blood_Type == txtSearch.Text
                                           select new
                                           {
                                               fullname = card.Quadruple_Name,
                                               Picture = card.Personal_Picture,
                                               poold = card.Blood_Type,
                                               Rel_date = card.Release_Date,
                                               end_date = card.End_Date
                                           }).ToList();

                ID_card_data.Columns[0].HeaderText = "الاسم الرباعي";
                ID_card_data.Columns[1].HeaderText = "الصورة الشخصية";
                ID_card_data.Columns[2].HeaderText = "فصيلة الدم ";
                ID_card_data.Columns[3].HeaderText = "تاريخ الاصدار";
                ID_card_data.Columns[4].HeaderText = "تاريخ الانتهاء";


            }
        }

        private void pnl_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void born_title_Click(object sender, EventArgs e)
        {

        }
    }
}
