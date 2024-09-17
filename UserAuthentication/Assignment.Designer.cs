namespace UserAuthentication
{
    partial class frm_assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ma = new System.Windows.Forms.Button();
            this.btn_sa = new System.Windows.Forms.Button();
            this.btn_ia = new System.Windows.Forms.Button();
            this.btn_ha = new System.Windows.Forms.Button();
            this.btn_hea = new System.Windows.Forms.Button();
            this.btn_ea = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGNMENTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_ma
            // 
            this.btn_ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ma.Location = new System.Drawing.Point(152, 183);
            this.btn_ma.Name = "btn_ma";
            this.btn_ma.Size = new System.Drawing.Size(213, 149);
            this.btn_ma.TabIndex = 1;
            this.btn_ma.Text = "Mathematics";
            this.btn_ma.UseVisualStyleBackColor = false;
            this.btn_ma.Click += new System.EventHandler(this.btn_ma_Click);
            // 
            // btn_sa
            // 
            this.btn_sa.BackColor = System.Drawing.Color.Magenta;
            this.btn_sa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_sa.Location = new System.Drawing.Point(371, 183);
            this.btn_sa.Name = "btn_sa";
            this.btn_sa.Size = new System.Drawing.Size(213, 149);
            this.btn_sa.TabIndex = 2;
            this.btn_sa.Text = "Science";
            this.btn_sa.UseVisualStyleBackColor = false;
            this.btn_sa.Click += new System.EventHandler(this.btn_sa_Click);
            // 
            // btn_ia
            // 
            this.btn_ia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ia.Location = new System.Drawing.Point(590, 183);
            this.btn_ia.Name = "btn_ia";
            this.btn_ia.Size = new System.Drawing.Size(213, 149);
            this.btn_ia.TabIndex = 3;
            this.btn_ia.Text = "I.C.T";
            this.btn_ia.UseVisualStyleBackColor = false;
            this.btn_ia.Click += new System.EventHandler(this.btn_ia_Click);
            // 
            // btn_ha
            // 
            this.btn_ha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ha.Location = new System.Drawing.Point(152, 338);
            this.btn_ha.Name = "btn_ha";
            this.btn_ha.Size = new System.Drawing.Size(213, 149);
            this.btn_ha.TabIndex = 4;
            this.btn_ha.Text = "History";
            this.btn_ha.UseVisualStyleBackColor = false;
            this.btn_ha.Click += new System.EventHandler(this.btn_ha_Click);
            // 
            // btn_hea
            // 
            this.btn_hea.BackColor = System.Drawing.Color.Red;
            this.btn_hea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hea.Location = new System.Drawing.Point(371, 338);
            this.btn_hea.Name = "btn_hea";
            this.btn_hea.Size = new System.Drawing.Size(213, 149);
            this.btn_hea.TabIndex = 5;
            this.btn_hea.Text = "Health";
            this.btn_hea.UseVisualStyleBackColor = false;
            this.btn_hea.Click += new System.EventHandler(this.btn_hea_Click);
            // 
            // btn_ea
            // 
            this.btn_ea.BackColor = System.Drawing.Color.Silver;
            this.btn_ea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ea.Location = new System.Drawing.Point(590, 338);
            this.btn_ea.Name = "btn_ea";
            this.btn_ea.Size = new System.Drawing.Size(213, 149);
            this.btn_ea.TabIndex = 6;
            this.btn_ea.Text = "English";
            this.btn_ea.UseVisualStyleBackColor = false;
            this.btn_ea.Click += new System.EventHandler(this.btn_ea_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 610);
            this.panel1.TabIndex = 7;
            // 
            // frm_assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(874, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ea);
            this.Controls.Add(this.btn_hea);
            this.Controls.Add(this.btn_ha);
            this.Controls.Add(this.btn_ia);
            this.Controls.Add(this.btn_sa);
            this.Controls.Add(this.btn_ma);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(892, 657);
            this.MinimumSize = new System.Drawing.Size(892, 657);
            this.Name = "frm_assignment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ma;
        private System.Windows.Forms.Button btn_sa;
        private System.Windows.Forms.Button btn_ia;
        private System.Windows.Forms.Button btn_ha;
        private System.Windows.Forms.Button btn_hea;
        private System.Windows.Forms.Button btn_ea;
        private System.Windows.Forms.Panel panel1;
    }
}