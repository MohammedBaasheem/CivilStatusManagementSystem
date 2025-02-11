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
    public partial class FRM_Identity_card : Form
    {
        public FRM_Identity_card()
        {
            InitializeComponent();
        }

        private void FRM_Identity_card_Load(object sender, EventArgs e)
        {
            txtBirthNum.Focus();
            txtBirthNum.Select();
            txtBirthNum.SelectAll();
        }

        private void show_data_Click(object sender, EventArgs e)
        {
            PL.FRM_citizens_data citizens_data = new PL.FRM_citizens_data();
            citizens_data.ShowDialog();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int w = pnl_identity_card.Width + 20;
            int h = pnl_identity_card.Height + 30;

            e.PageSettings.PaperSize = new PaperSize("My Paper", w, h);

            Bitmap bmp = new Bitmap(w, h);
            Rectangle rec = new Rectangle(0, 0, w, h);
            pnl_identity_card.DrawToBitmap(bmp, rec);

            e.Graphics.DrawImage(bmp, rec);
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            PL.FRM_update_IdCard update_card = new PL.FRM_update_IdCard();
            update_card.ShowDialog();
        }

        private void txtBirthNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_footer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            Identification_Card new_identification_Card = new Identification_Card();
            var Birth_Certificate = BL.Birth_certificate_Controller.Search_For_Birth_Certificate(txtBirthNum.Text);
            if (Birth_Certificate == null)
            {
                MessageBox.Show("لايوجد بطاقه ميلاد");
            }
            else
            {
                //نشيك على تايخ الميلاد اذا كان الفرق بينه وبين تاريخ اليوم بيساوي 15 سنه او اكثر نعمل له بطاقه شخصيه واذا اصغر نعتذر له 
                DateTime allowed_age = Birth_Certificate.Birth_date;
                int age = DateTime.Now.Year - allowed_age.Year;
                allowed_age.AddYears(15);
                if (age >= 15)
                {
                    //نسندالقيم الموجوده في شهادة لميلاد الى بيانات البطاقه الشخصيه
                    txtPersonName.Text = Birth_Certificate.Born_name + " " + Birth_Certificate.Father_name + " " + Birth_Certificate.Grand_last_name;
                    txtBirthPlace.Text = Birth_Certificate.Birth_place;
                    txtBirthNum.Text = Birth_Certificate.ID_Number_Born;
                    birthDate.Value= Birth_Certificate.Birth_date;
                    releaseDate.Value = DateTime.Now;
                    dt_end.Value = DateTime.Now.AddYears(5);
                    //txtID.Text = BL.Identification_Card_Controller.Encrypt_Identification_Card_num(txtPersonName.Text + txtBlood.Text);
                    txtBirthNum2.Text = txtBirthNum.Text;
                }
                else
                {
                    MessageBox.Show("هذاالعمر غير مسموح له بانشاء بطاقة شخصيه");

                }

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtPersonName.Text!=""&& txtBirthPlace.Text!=""&& txtBirthNum.Text!=""&& txtBlood.Text!="")
            {
                var Birth_Certificate = BL.Birth_certificate_Controller.Search_For_Birth_Certificate(txtBirthNum.Text);
                Identification_Card new_identification_Card = new Identification_Card();
                new_identification_Card.Quadruple_Name = txtPersonName.Text;
                new_identification_Card.Blood_Type = txtBlood.Text;
                new_identification_Card.Release_Date = releaseDate.Value;
                new_identification_Card.ID_Born = Birth_Certificate.ID_Born;
                new_identification_Card.End_Date = dt_end.Value;
                //new_identification_Card.ID_Number = txtID.Text;


                MemoryStream mest = new MemoryStream();
                pictureBox1.Image.Save(mest, pictureBox1.Image.RawFormat);
                byte[] image_to_byte = mest.ToArray();


                new_identification_Card.Personal_Picture = image_to_byte;

                txtID.Text = BL.Identification_Card_Controller.Encrypt_Identification_Card_num(txtPersonName.Text + txtBlood.Text);
                new_identification_Card.ID_Number = txtID.Text;

                BL.Identification_Card_Controller.Add_Identification_Card(new_identification_Card);
                MessageBox.Show("تم الحفظ بنجاح");
                txtPersonName.Text = "";
                txtBirthPlace.Text = "";
                txtBirthNum.Text = "";
                txtBlood.Text = "";
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("لايمكن حفظ قيم فارغة");
            }

        }

        private void pnl_identity_card_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
