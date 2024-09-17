namespace UserAuthentication
{
    partial class frm_notes
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
            this.btn_mathematics = new System.Windows.Forms.Button();
            this.btn_science = new System.Windows.Forms.Button();
            this.btn_ict = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_health = new System.Windows.Forms.Button();
            this.btn_english = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(361, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTES";
            // 
            // btn_mathematics
            // 
            this.btn_mathematics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_mathematics.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mathematics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mathematics.Location = new System.Drawing.Point(149, 181);
            this.btn_mathematics.Name = "btn_mathematics";
            this.btn_mathematics.Size = new System.Drawing.Size(213, 149);
            this.btn_mathematics.TabIndex = 1;
            this.btn_mathematics.Text = "Mathematics";
            this.btn_mathematics.UseVisualStyleBackColor = false;
            this.btn_mathematics.Click += new System.EventHandler(this.btn_mathematics_Click);
            // 
            // btn_science
            // 
            this.btn_science.BackColor = System.Drawing.Color.Magenta;
            this.btn_science.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_science.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_science.Location = new System.Drawing.Point(368, 181);
            this.btn_science.Name = "btn_science";
            this.btn_science.Size = new System.Drawing.Size(213, 149);
            this.btn_science.TabIndex = 2;
            this.btn_science.Text = "Science";
            this.btn_science.UseVisualStyleBackColor = false;
            this.btn_science.Click += new System.EventHandler(this.btn_science_Click);
            // 
            // btn_ict
            // 
            this.btn_ict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ict.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ict.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ict.Location = new System.Drawing.Point(587, 181);
            this.btn_ict.Name = "btn_ict";
            this.btn_ict.Size = new System.Drawing.Size(213, 149);
            this.btn_ict.TabIndex = 3;
            this.btn_ict.Text = "I.C.T";
            this.btn_ict.UseVisualStyleBackColor = false;
            this.btn_ict.Click += new System.EventHandler(this.btn_ict_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_history.Location = new System.Drawing.Point(149, 336);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(213, 149);
            this.btn_history.TabIndex = 4;
            this.btn_history.Text = "History";
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_health
            // 
            this.btn_health.BackColor = System.Drawing.Color.Red;
            this.btn_health.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_health.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_health.Location = new System.Drawing.Point(368, 336);
            this.btn_health.Name = "btn_health";
            this.btn_health.Size = new System.Drawing.Size(213, 149);
            this.btn_health.TabIndex = 5;
            this.btn_health.Text = "Health";
            this.btn_health.UseVisualStyleBackColor = false;
            this.btn_health.Click += new System.EventHandler(this.btn_health_Click);
            // 
            // btn_english
            // 
            this.btn_english.BackColor = System.Drawing.Color.Silver;
            this.btn_english.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_english.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_english.Location = new System.Drawing.Point(587, 336);
            this.btn_english.Name = "btn_english";
            this.btn_english.Size = new System.Drawing.Size(213, 149);
            this.btn_english.TabIndex = 6;
            this.btn_english.Text = "English";
            this.btn_english.UseVisualStyleBackColor = false;
            this.btn_english.Click += new System.EventHandler(this.btn_english_Click);
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
            // frm_notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(874, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_english);
            this.Controls.Add(this.btn_health);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_ict);
            this.Controls.Add(this.btn_science);
            this.Controls.Add(this.btn_mathematics);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(892, 657);
            this.MinimumSize = new System.Drawing.Size(892, 657);
            this.Name = "frm_notes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mathematics;
        private System.Windows.Forms.Button btn_science;
        private System.Windows.Forms.Button btn_ict;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_health;
        private System.Windows.Forms.Button btn_english;
        private System.Windows.Forms.Panel panel1;
    }
}