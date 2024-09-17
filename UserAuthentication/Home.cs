using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuthentication
{
    public partial class Frm_Home : Form
    {
        public Frm_Home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }

        private void btn_adduseradmin_Click(object sender, EventArgs e)
        {
            frm_Add_User_Admin fau=new frm_Add_User_Admin();
            fau.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Frm_login fl=new Frm_login();
            fl.Show();
            this.Hide();
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            if (ulog.type == "A")
            {
                btn_adduseradmin.Visible = true;
                btn_Attendance.Visible = true;
                btn_payment.Visible = true;
                btn_report.Visible = true;
                btn_setting.Visible = true;
                btn_Studnet.Visible = true;
            }
            else if (ulog.type == "U")
            {
                btn_adduseradmin.Visible = false;
                btn_Attendance.Visible = true;
                btn_payment.Visible = false;
                btn_report.Visible = true;
                btn_setting.Visible = false;
                btn_Studnet.Visible = true;
            }
        }

        private void btn_Attendance_Click(object sender, EventArgs e)
        {
            frm_attendance fau = new frm_attendance();
            fau.ShowDialog();
        }

        private void btn_Studnet_Click(object sender, EventArgs e)
        {
            frm_notes fn=new frm_notes();
            fn.ShowDialog();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            frm_assignment fa=new frm_assignment();
            fa.ShowDialog();
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            frm_students fs=new frm_students();
            fs.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            frm_payment fp=new frm_payment();
            fp.ShowDialog();
        }
    }
}
