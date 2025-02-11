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
    public partial class Main : Form
    {
        PL.FRM_Identity_card ID_card = new PL.FRM_Identity_card();
        PL.FRM_birth_certificate birth_cer = new PL.FRM_birth_certificate();
        PL.FRM_passport passport = new PL.FRM_passport();
        manager.FRM_manage manager = new manager.FRM_manage();
        PL.Home home = new PL.Home();
        public Main()
        {
            InitializeComponent();
            scroller.Height = home_btn.Height;
            scroller.Top = home_btn.Top;
            home_btn.BackColor = Color.FromArgb(183, 0, 112, 255);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(home.pnl_home);
            title_page.Text = "الرئيسية";           
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(home.pnl_home);
            title_page.Text = "الرئيسية";

            scroller.Height = home_btn.Height;
            scroller.Top = home_btn.Top;

            home_btn.BackColor = Color.FromArgb(183, 0, 112, 255);
            btn_employees.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_make_order.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_orders.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_passport.BackColor = Color.FromArgb(178, 0, 145, 255);

        }

        private void btn_make_order_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(birth_cer.pnl_make_order);
            title_page.Text = "شهادة ميلاد";

            scroller.Height = btn_make_order.Height;
            scroller.Top = btn_make_order.Top;


            birth_cer.txtBornName.Focus();

            btn_make_order.BackColor = Color.FromArgb(183, 0, 112, 255);
            btn_employees.BackColor = Color.FromArgb(178, 0, 145, 255);
            home_btn.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_orders.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_passport.BackColor = Color.FromArgb(178, 0, 145, 255);
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(ID_card.pnl_identity_card);

            scroller.Height = btn_orders.Height;
            scroller.Top = btn_orders.Top;

            btn_orders.BackColor = Color.FromArgb(183, 0, 112, 255);
            btn_employees.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_make_order.BackColor = Color.FromArgb(178, 0, 145, 255);
            home_btn.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_passport.BackColor = Color.FromArgb(178, 0, 145, 255);


            title_page.Text = "بطاقة شخصية";
        }

        private void btn_passport_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(passport.pnl_passport);
            title_page.Text = "جواز سفر";

            scroller.Height = btn_passport.Height;
            scroller.Top = btn_passport.Top;

            btn_passport.BackColor = Color.FromArgb(183, 0, 112, 255);
            btn_orders.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_make_order.BackColor = Color.FromArgb(178, 0, 145, 255);
            home_btn.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_employees.BackColor = Color.FromArgb(178, 0, 145, 255);
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            pnl_cont.Controls.Clear();
            pnl_cont.Controls.Add(manager.pnl_employees);
            title_page.Text = "إدارة موظفين";

            scroller.Height = btn_employees.Height;
            scroller.Top = btn_employees.Top;

            btn_employees.BackColor = Color.FromArgb(183, 0, 112, 255);
            btn_passport.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_orders.BackColor = Color.FromArgb(178, 0, 145, 255);
            btn_make_order.BackColor = Color.FromArgb(178, 0, 145, 255);
            home_btn.BackColor = Color.FromArgb(178, 0, 145, 255);
        }
    }
}
