namespace UserAuthentication
{
    partial class Frm_Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Attendance = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_Studnet = new System.Windows.Forms.Button();
            this.btn_adduseradmin = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Attendance
            // 
            this.btn_Attendance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Attendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Attendance.Location = new System.Drawing.Point(135, 225);
            this.btn_Attendance.Name = "btn_Attendance";
            this.btn_Attendance.Size = new System.Drawing.Size(193, 106);
            this.btn_Attendance.TabIndex = 0;
            this.btn_Attendance.Text = "Attendance";
            this.btn_Attendance.UseVisualStyleBackColor = false;
            this.btn_Attendance.Click += new System.EventHandler(this.btn_Attendance_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_report.Location = new System.Drawing.Point(595, 225);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(193, 106);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "Assignment";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_Studnet
            // 
            this.btn_Studnet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Studnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Studnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Studnet.Location = new System.Drawing.Point(366, 225);
            this.btn_Studnet.Name = "btn_Studnet";
            this.btn_Studnet.Size = new System.Drawing.Size(193, 106);
            this.btn_Studnet.TabIndex = 2;
            this.btn_Studnet.Text = "Notes";
            this.btn_Studnet.UseVisualStyleBackColor = false;
            this.btn_Studnet.Click += new System.EventHandler(this.btn_Studnet_Click);
            // 
            // btn_adduseradmin
            // 
            this.btn_adduseradmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduseradmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_adduseradmin.Location = new System.Drawing.Point(366, 363);
            this.btn_adduseradmin.Name = "btn_adduseradmin";
            this.btn_adduseradmin.Size = new System.Drawing.Size(193, 106);
            this.btn_adduseradmin.TabIndex = 5;
            this.btn_adduseradmin.Text = "Add User/Admin";
            this.btn_adduseradmin.UseVisualStyleBackColor = true;
            this.btn_adduseradmin.Click += new System.EventHandler(this.btn_adduseradmin_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_setting.Location = new System.Drawing.Point(595, 363);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(193, 106);
            this.btn_setting.TabIndex = 4;
            this.btn_setting.Text = "Payment";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_payment.Location = new System.Drawing.Point(135, 363);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(193, 106);
            this.btn_payment.TabIndex = 3;
            this.btn_payment.Text = "Students";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Red;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_logout.Location = new System.Drawing.Point(743, 22);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(104, 39);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_loguser.Location = new System.Drawing.Point(231, 22);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(168, 39);
            this.lbl_loguser.TabIndex = 7;
            this.lbl_loguser.Text = "Welcome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 610);
            this.panel1.TabIndex = 8;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(874, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_loguser);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_adduseradmin);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_Studnet);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_Attendance);
            this.MaximumSize = new System.Drawing.Size(892, 657);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(892, 657);
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Attendance;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_Studnet;
        private System.Windows.Forms.Button btn_adduseradmin;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.Panel panel1;
    }
}