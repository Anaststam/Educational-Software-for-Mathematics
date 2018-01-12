namespace Elearning
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.telnumber = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.passwordver = new System.Windows.Forms.TextBox();
            this.submitBut = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.back_pnl = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name.Location = new System.Drawing.Point(583, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(131, 26);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(36, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(0, 37);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Username";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SeaShell;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(412, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(90, 19);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Όνομα:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(412, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(90, 19);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Επίθετο:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.surname.Location = new System.Drawing.Point(583, 94);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(131, 26);
            this.surname.TabIndex = 10;
            this.surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surname_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SeaShell;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(412, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(90, 19);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Τηλέφωνο:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telnumber
            // 
            this.telnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.telnumber.Location = new System.Drawing.Point(583, 135);
            this.telnumber.Name = "telnumber";
            this.telnumber.Size = new System.Drawing.Size(131, 26);
            this.telnumber.TabIndex = 12;
            this.telnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telnumber_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SeaShell;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox5.Location = new System.Drawing.Point(412, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(90, 19);
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "Username:";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username.Location = new System.Drawing.Point(583, 173);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(131, 26);
            this.username.TabIndex = 14;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.SeaShell;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox6.Location = new System.Drawing.Point(412, 217);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(90, 19);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Κωδικός:";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password.Location = new System.Drawing.Point(583, 210);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(131, 26);
            this.password.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.SeaShell;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.Location = new System.Drawing.Point(342, 256);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(160, 19);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Επιβεβαίωση Κωδικού:";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordver
            // 
            this.passwordver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordver.Location = new System.Drawing.Point(583, 249);
            this.passwordver.Name = "passwordver";
            this.passwordver.PasswordChar = '*';
            this.passwordver.Size = new System.Drawing.Size(131, 26);
            this.passwordver.TabIndex = 18;
            // 
            // submitBut
            // 
            this.submitBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submitBut.Location = new System.Drawing.Point(683, 383);
            this.submitBut.Name = "submitBut";
            this.submitBut.Size = new System.Drawing.Size(112, 35);
            this.submitBut.TabIndex = 19;
            this.submitBut.Text = "Υποβολή";
            this.submitBut.UseVisualStyleBackColor = true;
            this.submitBut.Click += new System.EventHandler(this.submitBut_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.SeaShell;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.Location = new System.Drawing.Point(250, 12);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(343, 22);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "Συμπλήρωσε τα στοιχεία σου";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Elearning.Properties.Resources.thales_logo;
            this.panel1.Location = new System.Drawing.Point(42, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 276);
            this.panel1.TabIndex = 21;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 452);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(879, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.SeaShell;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox9.Location = new System.Drawing.Point(392, 292);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 19);
            this.textBox9.TabIndex = 23;
            this.textBox9.Text = "Είδος Χρήστη:";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Μαθητής",
            "Καθηγητής"});
            this.type.Location = new System.Drawing.Point(583, 290);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(131, 28);
            this.type.TabIndex = 24;
            // 
            // back_pnl
            // 
            this.back_pnl.BackgroundImage = global::Elearning.Properties.Resources.Arrows_Back_icon;
            this.back_pnl.Location = new System.Drawing.Point(12, 12);
            this.back_pnl.Name = "back_pnl";
            this.back_pnl.Size = new System.Drawing.Size(29, 32);
            this.back_pnl.TabIndex = 25;
            this.back_pnl.Click += new System.EventHandler(this.back_click);
            // 
            // info_panel
            // 
            this.info_panel.BackgroundImage = global::Elearning.Properties.Resources.Sys_Help_icon;
            this.info_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info_panel.Location = new System.Drawing.Point(820, 12);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(47, 47);
            this.info_panel.TabIndex = 26;
            this.info_panel.Click += new System.EventHandler(this.info_panel_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.back_pnl);
            this.Controls.Add(this.type);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.submitBut);
            this.Controls.Add(this.passwordver);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.telnumber);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.Text = "ΘΑΛΗΣ-Εγγραφή";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox telnumber;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox passwordver;
        private System.Windows.Forms.Button submitBut;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Panel back_pnl;
        private System.Windows.Forms.Panel info_panel;
    }
}