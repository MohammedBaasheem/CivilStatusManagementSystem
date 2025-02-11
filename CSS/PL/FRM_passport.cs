using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace CSS.PL
{
    public partial class FRM_passport : Form
    {
        public FRM_passport()
        {
            InitializeComponent();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            // create a new opject from file dialog
            OpenFileDialog FD = new OpenFileDialog();
            // the extension of photos
            FD.Filter = "images|*.jpg;*.png;*.gif;*.bmp";
            FD.Title = "اضافة صورة شخصية";
            // the place to choose a photo
            FD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (FD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(FD.FileName);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = pnl_passport.Width + 20;
            int h = pnl_passport.Height + 30;

            e.PageSettings.PaperSize = new PaperSize("My Paper", w, h);

            Bitmap bmp = new Bitmap(w, h);
            Rectangle rec = new Rectangle(0, 0, w, h);
            pnl_passport.DrawToBitmap(bmp, rec);

            e.Graphics.DrawImage(bmp, rec);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            this.Hide();
        }

        private void show_data_Click(object sender, EventArgs e)
        {
            FRM_passport_data pass_data = new FRM_passport_data();
            pass_data.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            PL.FRM_update_passport update_passport = new PL.FRM_update_passport();
            update_passport.ShowDialog();
        }

        private void pnl_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            Passport new_passport_card = new Passport();

            var Birth_Certificate = BL.Birth_certificate_Controller.Search_For_Birth_Certificate(txtBirthNum.Text);
            if (Birth_Certificate == null)
            {
                MessageBox.Show("لايوجد بطاقه ميلاد");
            }
            else
            {
                txtPersonName.Text = Birth_Certificate.Born_name + " " + Birth_Certificate.Father_name;
                textBox1.Text = Birth_Certificate.Birth_place;
                txtBirthNum2.Text = txtBirthNum.Text;
                birthDate.Value = Birth_Certificate.Birth_date;
                comboBox1.Text = Birth_Certificate.Gendar_Born;
                releaseDate.Value = DateTime.Now;
                dt_end.Value = releaseDate.Value.AddYears(5);
                
                MessageBox.Show("قم بادخال المهنه ثم اضف صوره الشخصيه واضغط على حفظ لتتم اضافتها");


            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtPersonName.Text != "" && textBox1.Text != "" && txtBirthNum2.Text != "" && birthDate.Value != null && comboBox1.Text != "" && releaseDate.Value != null&& dt_end.Value!=null && pictureBox1.Image != null && txtProfession.Text != "")
            {
                var Birth_Certificate = BL.Birth_certificate_Controller.Search_For_Birth_Certificate(txtBirthNum.Text);
                if (Birth_Certificate == null)
                {
                    MessageBox.Show("لايوجد بطاقه ميلاد");
                }
                Passport new_passport_card = new Passport();
                new_passport_card.The_Third_Name = txtPersonName.Text;
                new_passport_card.Occupation = txtProfession.Text;
                new_passport_card.Nickname = Birth_Certificate.Grand_last_name;
                new_passport_card.Release_date = releaseDate.Value;
                new_passport_card.End_Date = dt_end.Value;
                new_passport_card.ID_Born = Birth_Certificate.ID_Born;
               


                MemoryStream mest = new MemoryStream();
                pictureBox1.Image.Save(mest, pictureBox1.Image.RawFormat);
                byte[] image_to_byte = mest.ToArray();

                new_passport_card.Personal_Picture = image_to_byte;

                
                MessageBox.Show("تم حفظ جواز السفر ");
                txtPassportNum.Text = BL.Passport_Controller.Encrypt_Passport_Card_num(txtPersonName.Text + txtProfession.Text);
                new_passport_card.ID_Passport_Number = txtPassportNum.Text;
                BL.Passport_Controller.Add_Passport_Card(new_passport_card);

                txtPersonName.Text = "";
                txtBirthNum.Text = "";
                textBox1.Text = "";
                txtBirthNum2.Text = "";
                txtPassportNum.Text = "";
                txtProfession.Text = "";
                pictureBox1.Image = null;

            }
            else
            {
                MessageBox.Show("لايمكنك حفظ قيم فارغة");
            }
        }
    }
}
