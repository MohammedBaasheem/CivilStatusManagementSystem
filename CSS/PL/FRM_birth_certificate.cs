using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace CSS.PL
{
    public partial class FRM_birth_certificate : Form
    {
        Civil_statusEntities1 Civ = new Civil_statusEntities1();
        public FRM_birth_certificate()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = pnl_make_order.Width + 20;
            int h = pnl_make_order.Height + 30;

            e.PageSettings.PaperSize = new PaperSize("My Paper", w, h);

            Bitmap bmp = new Bitmap(w, h);
            Rectangle rec = new Rectangle(0, 0, w, h);
            pnl_make_order.DrawToBitmap(bmp, rec);

            e.Graphics.DrawImage(bmp, rec);
        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            this.Hide();
        }

        private void show_data_Click(object sender, EventArgs e)
        {
            PL.BornPage BornPage = new PL.BornPage();
            BornPage.ShowDialog();
        }

        private void txtBornName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                familyName.Focus();
            }
        }

        private void familyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherName.Focus();
            }
        }

        private void txtFatherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                comboBoxSex.Focus();
            }
        }

        private void comboBoxSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherName2.Focus();
            }
        }

        private void txtFatherName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherReligion.Focus();
            }
        }

        private void txtFatherReligion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherNationality.Focus();
            }
        }

        private void txtFatherNationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtFatherJob.Focus();
            }
        }

        private void txtFatherJob_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtFatherLivingPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMotherName.Focus();
            }
        }

        private void txtMotherName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMotherReligion.Focus();
            }
        }

        private void txtMotherReligion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMotherNationality.Focus();
            }
        }

        private void txtMotherNationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMotherJob.Focus();
            }
        }

        private void txtMotherJob_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtMotherLivingPlace_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCity.Focus();
            }
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtCountry.Focus();
            }
        }

        private void pnl_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Birth_Certificate birth_Certificate = new Birth_Certificate();
            if (txtBornName.Text!="" && txtFatherName.Text!="" &&
                familyName.Text != "" && txtFatherName2.Text != "" &&
                txtFatherNationality.Text != "" && txtFatherReligion.Text != "" &&
                txtFatherJob.Text != "" && txtMotherJob.Text!="" &&
                txtMotherName.Text != "" && txtMotherNationality.Text != "" &&
                txtMotherReligion.Text != "" && txt_nationalty.Text!="" &&
                txtCity.Text != "" && txtCountry.Text != "")
            {
                txtFatherName2.Text = txtFatherName.Text + " " + familyName.Text;
                birth_Certificate.Born_name = txtBornName.Text;
                birth_Certificate.Father_name = txtFatherName.Text;
                birth_Certificate.Grand_last_name = familyName.Text;
                birth_Certificate.Nationality = txt_nationalty.Text;
                birth_Certificate.Nationality_Father = txtFatherNationality.Text;
                birth_Certificate.Religion_Father = txtFatherReligion.Text;
                birth_Certificate.Occupation_Father = txtFatherJob.Text;
                birth_Certificate.Address = txtCity.Text + " " + txtCountry.Text;
                birth_Certificate.Birth_place= txtCity.Text + " " + txtCountry.Text;
                birth_Certificate.Mother_name = txtMotherName.Text;
                birth_Certificate.Nationality_Mother = txtMotherNationality.Text;
                birth_Certificate.Occupation_Mother = txtMotherJob.Text;
                birth_Certificate.Religion_Mother = txtMotherReligion.Text;
                birth_Certificate.Gendar_Born = comboBoxSex.Text;
                birth_Certificate.Birth_date = dateTimePicker1.Value;
                birth_Certificate.Release_date = dateTimePicker2.Value;
                txtBirthNum.Text= BL.Birth_certificate_Controller.Encrypt_Birth_Certificate_num(birth_Certificate.Born_name + birth_Certificate.Father_name + birth_Certificate.Grand_last_name + birth_Certificate.Mother_name);
                birth_Certificate.ID_Number_Born = txtBirthNum.Text;



                BL.Birth_certificate_Controller.Add_Birth_Certificate(birth_Certificate);
                MessageBox.Show("تم الحفظ بنجاح");
                txtBornName.Text = "";
                txtFatherName.Text = "";
                familyName.Text = "";
                txtFatherName2.Text = "";
                txtFatherNationality.Text = "";
                txtFatherReligion.Text = "";
                txtFatherJob.Text = "";
                txtMotherJob.Text = "";
                txtMotherName.Text = "";
                txtMotherNationality.Text = "";
                txtMotherReligion.Text = "";
                txt_nationalty.Text = "" ;
                txtCity.Text = "";
                txtCountry.Text = "";
            }
            else
            {
                MessageBox.Show("اكمل ادخال البيانات");
            }
        }

        private void pnl_make_order_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMotherJob_TextChanged(object sender, EventArgs e)
        {
           
                
        }

        private void line_Click(object sender, EventArgs e)
        {

        }
    }
}
