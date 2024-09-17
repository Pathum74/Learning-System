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
    public partial class frm_notes : Form
    {
        public frm_notes()
        {
            InitializeComponent();
        }

        private void btn_mathematics_Click(object sender, EventArgs e)
        {
            Notemath fnm = new Notemath();
            fnm.ShowDialog();
        }

        private void btn_science_Click(object sender, EventArgs e)
        {
            Notescience fns = new Notescience();
            fns.ShowDialog();
        }

        private void btn_ict_Click(object sender, EventArgs e)
        {
            Noteict fni = new Noteict();
            fni.ShowDialog();   
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Notehistory fnh = new Notehistory();
            fnh.ShowDialog();
        }

        private void btn_health_Click(object sender, EventArgs e)
        {
            Notehealth fnhe = new Notehealth();
            fnhe.ShowDialog();
        }

        private void btn_english_Click(object sender, EventArgs e)
        {
            Noteenglish fne = new Noteenglish();
            fne.ShowDialog();
        }
    }
}
