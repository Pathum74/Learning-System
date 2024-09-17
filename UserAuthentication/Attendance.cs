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
    public partial class frm_attendance : Form
    {
        public frm_attendance()
        {
            InitializeComponent();
        }

        private void frm_attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tblattendance' table. You can move, or remove it, as needed.
            this.tblattendanceTableAdapter.Fill(this.appData.tblattendance);
            Edit(false);

            if (ulog.type == "A")
            {
                btn_new.Visible = true;
                btn_Edit.Visible = true;
                btn_save.Visible = true;
                btn_remove.Visible = true;
                dtp.Visible = true;
                txt_attendance.Visible = true;
                txt_name.Visible = true;
                lbl_username.Visible = true;
                label3.Visible = true;

            }
            else if (ulog.type == "U")
            {
                btn_new.Visible = false;
                btn_Edit.Visible = false;
                btn_save.Visible = false;
                btn_remove.Visible = false;
                dtp.Visible = true;
                txt_attendance.Visible = true;
                txt_name.Visible = true;
                lbl_username.Visible = true;
                label3.Visible = true;
            }
        }

        private void Edit(bool value)
        {
            txt_name.Enabled = value;
            txt_attendance.Enabled = value;
            dtp.Enabled = value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tblattendance.AddtblattendanceRow(appData.tblattendance.NewtblattendanceRow());
                tblattendanceBindingSource.MoveLast();
                txt_name.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                appData.tblattendance.RejectChanges();
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_name.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false );
                tblattendanceBindingSource.EndEdit();
                tblattendanceTableAdapter.Update(appData.tblattendance);
                dataGridView1.Refresh();
                txt_name.Focus();
                MessageBox.Show("Your data has been successfully saved.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tblattendance.RejectChanges();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you want to remove this record?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                tblattendanceBindingSource.RemoveCurrent();
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
