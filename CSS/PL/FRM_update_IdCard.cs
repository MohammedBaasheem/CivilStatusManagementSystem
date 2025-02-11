using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace CSS.PL
{
    public partial class FRM_update_IdCard : Form
    {
        Civil_statusEntities1 civ = new Civil_statusEntities1();
       Identification_Card old_card = null; 
        public FRM_update_IdCard()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPic_Click_1(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_Click(object sender, EventArgs e)
        {
           var oldcard= BL.Identification_Card_Controller.Search_For_Identification_Card(txt_search.Text);
            if (oldcard==null)
            {
                MessageBox.Show("لايوجد بطاقة بهذ الرقم يرجى المحاوله مره اخرى");
            }
            else if (oldcard.End_Date>DateTime.Now)
            {
                MessageBox.Show("البطاقة ليست منتهية الصلاحية");

            }
            else
            {
                old_card = oldcard;
                releaseDate.Value = oldcard.Release_Date;
                DateTime curnt = DateTime.Now;
                curnt.AddYears(5);
                endDate.Value = curnt;
                MessageBox.Show("تم تمديد فترة الصلاحية اضف الصوره الشخصيه الجديدة");

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Identification_Card new_card = new Identification_Card();
                new_card = old_card;
                releaseDate.Value = new_card.Release_Date;
                DateTime curnt = DateTime.Now;
                curnt.AddYears(5);
                endDate.Value = curnt;
                new_card.End_Date = endDate.Value;
                new_card.Release_Date = releaseDate.Value;


                MemoryStream mest = new MemoryStream();
                pictureBox1.Image.Save(mest, pictureBox1.Image.RawFormat);
                byte[] image_to_byte = mest.ToArray();
                new_card.Personal_Picture = image_to_byte;
                civ.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
            else
            {
                MessageBox.Show("لايوجد صوره قم باضافه صوره ");
            }
            
        }
    }
}
