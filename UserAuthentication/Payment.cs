using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAuthentication.AppDataTableAdapters;
using static System.Net.WebRequestMethods;

namespace UserAuthentication
{
    public partial class frm_payment : Form
    {
        public frm_payment()
        {
            InitializeComponent();
        }

        private void frm_payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentData.tblPayment' table. You can move, or remove it, as needed.
            this.tblPaymentTableAdapter.Fill(this.paymentData.tblPayment);
            Edit(false);

        }

        private void Edit(bool value)
        {
            txt_name.Enabled = value;
            txt_price.Enabled = value;
            txt_code.Enabled = value;
            dateTimePicker1.Enabled = value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                paymentData.tblPayment.AddtblPaymentRow(paymentData.tblPayment.NewtblPaymentRow());
                tblPaymentBindingSource.MoveLast();
                txt_name.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentData.tblPayment.RejectChanges();
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
                Edit(false);
                tblPaymentBindingSource.EndEdit();
                tblPaymentTableAdapter.Update(paymentData.tblPayment);
                dgv_payment.Refresh();
                txt_name.Focus();
                MessageBox.Show("Your payment details has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paymentData.tblPayment.RejectChanges();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to remove this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tblPaymentBindingSource.RemoveCurrent();
            }
        }
    }
}
