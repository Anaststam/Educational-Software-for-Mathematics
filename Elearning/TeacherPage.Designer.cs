namespace Elearning
{
    partial class TeacherPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherPage));
            this.proodos_but = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.welcome_teacher_box = new System.Windows.Forms.TextBox();
            this.Log_out_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proodos_but
            // 
            this.proodos_but.Location = new System.Drawing.Point(357, 269);
            this.proodos_but.Name = "proodos_but";
            this.proodos_but.Size = new System.Drawing.Size(149, 53);
            this.proodos_but.TabIndex = 1;
            this.proodos_but.Text = "ΠΡΟΟΔΟΣ ΜΑΘΗΤΩΝ";
            this.proodos_but.UseVisualStyleBackColor = true;
            this.proodos_but.Click += new System.EventHandler(this.proodos_but_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Elearning.Properties.Resources.thales_logo2;
            this.panel2.Location = new System.Drawing.Point(357, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 155);
            this.panel2.TabIndex = 4;
            // 
            // info_panel
            // 
            this.info_panel.BackgroundImage = global::Elearning.Properties.Resources.Sys_Help_icon;
            this.info_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info_panel.Location = new System.Drawing.Point(820, 415);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(47, 47);
            this.info_panel.TabIndex = 2;
            this.info_panel.Click += new System.EventHandler(this.info_panel_Click);
            // 
            // welcome_teacher_box
            // 
            this.welcome_teacher_box.BackColor = System.Drawing.Color.SeaShell;
            this.welcome_teacher_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcome_teacher_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.welcome_teacher_box.Location = new System.Drawing.Point(198, 12);
            this.welcome_teacher_box.Name = "welcome_teacher_box";
            this.welcome_teacher_box.Size = new System.Drawing.Size(190, 28);
            this.welcome_teacher_box.TabIndex = 5;
            this.welcome_teacher_box.Text = "Γεια σας Κύριε";
            // 
            // Log_out_but
            // 
            this.Log_out_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_out_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Log_out_but.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Log_out_but.Location = new System.Drawing.Point(776, 19);
            this.Log_out_but.Name = "Log_out_but";
            this.Log_out_but.Size = new System.Drawing.Size(91, 23);
            this.Log_out_but.TabIndex = 7;
            this.Log_out_but.Text = "Αποσύνδεση";
            this.Log_out_but.UseVisualStyleBackColor = true;
            this.Log_out_but.Click += new System.EventHandler(this.Log_out_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(394, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 28);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΕΩΝ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Log_out_but);
            this.Controls.Add(this.welcome_teacher_box);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.proodos_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeacherPage";
            this.Text = "ΘΑΛΗΣ-Σελίδα Kαθηγητή";
            this.Load += new System.EventHandler(this.TeacherPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button proodos_but;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox welcome_teacher_box;
        private LogInForm loginform;
        private System.Windows.Forms.Button Log_out_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

