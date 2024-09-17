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
    public partial class frm_assignment : Form
    {
        public frm_assignment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ma_Click(object sender, EventArgs e)
        {
            Amaths am=new Amaths();
            am.ShowDialog();
        }

        private void btn_sa_Click(object sender, EventArgs e)
        {
            Ascience asc=new Ascience();
            asc.ShowDialog();
        }

        private void btn_ia_Click(object sender, EventArgs e)
        {
            Aict aict=new Aict();
            aict.ShowDialog();
        }

        private void btn_ha_Click(object sender, EventArgs e)
        {
            Ahistory ahistory=new Ahistory();
            ahistory.ShowDialog();
        }

        private void btn_hea_Click(object sender, EventArgs e)
        {
            Ahealth ahealth=new Ahealth();
            ahealth.ShowDialog();
        }

        private void btn_ea_Click(object sender, EventArgs e)
        {
            Aenglish aenglish=new Aenglish();
            aenglish.ShowDialog();
        }
    }
}
