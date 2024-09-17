using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAuthentication.PaymentDataTableAdapters;
using UserAuthentication.StudentDataTableAdapters;

namespace UserAuthentication
{
    public partial class frm_students : Form
    {
        public frm_students()
        {
            InitializeComponent();
        }

        private void frm_students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentData.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentData.Student);
            Edit(false);
        }

        private void Edit(bool value) 
        {
            txt_name.Enabled = value;
            txt_grade.Enabled = value;
            dtp_dob.Enabled = value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try 
            {
                Edit(true);
                studentData.Student.AddStudentRow(studentData.Student.NewStudentRow());
                studentBindingSource.MoveLast();
                txt_name.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentData.Student.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_name.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                studentBindingSource.EndEdit();
                studentTableAdapter.Update(studentData.Student);
                dataGridView1.Refresh();
                txt_name.Focus();
                MessageBox.Show("Students details has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentData.Student.RejectChanges();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to remove this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                studentBindingSource.RemoveCurrent();
            }
        }
    }
}
