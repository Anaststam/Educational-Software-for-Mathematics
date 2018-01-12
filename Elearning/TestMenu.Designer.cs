namespace Elearning
{
    partial class TestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.test1 = new System.Windows.Forms.Button();
            this.test2 = new System.Windows.Forms.Button();
            this.test3 = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.back_pnl = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Elearning.Properties.Resources.thales_logo2;
            this.panel2.Location = new System.Drawing.Point(361, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 155);
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
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(180, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(556, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Διάλεξε το Τest που θέλεις να πραγματοποιήσεις ";
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(28, 121);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(157, 47);
            this.test1.TabIndex = 8;
            this.test1.Text = "Κεφάλαιο1";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.test1_Click);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(28, 203);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(157, 47);
            this.test2.TabIndex = 9;
            this.test2.Text = "Κεφάλαιο 2";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(28, 286);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(157, 47);
            this.test3.TabIndex = 10;
            this.test3.Text = "Κεφάλαιο 3";
            this.test3.UseVisualStyleBackColor = true;
            this.test3.Click += new System.EventHandler(this.test3_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(28, 371);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(157, 47);
            this.final.TabIndex = 11;
            this.final.Text = "Επαναληπτικό";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // back_pnl
            // 
            this.back_pnl.BackgroundImage = global::Elearning.Properties.Resources.Arrows_Back_icon;
            this.back_pnl.Location = new System.Drawing.Point(12, 12);
            this.back_pnl.Name = "back_pnl";
            this.back_pnl.Size = new System.Drawing.Size(29, 32);
            this.back_pnl.TabIndex = 12;
            this.back_pnl.Click += new System.EventHandler(this.back_pnl_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(28, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Τεστ ανα Κεφάλαιο:";
            // 
            // progressbut
            // 
            this.progressbut.Location = new System.Drawing.Point(680, 203);
            this.progressbut.Name = "progressbut";
            this.progressbut.Size = new System.Drawing.Size(157, 47);
            this.progressbut.TabIndex = 14;
            this.progressbut.Text = "Πρόοδος";
            this.progressbut.UseVisualStyleBackColor = true;
            this.progressbut.Click += new System.EventHandler(this.progressbut_Click);
            // 
            // TestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.progressbut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_pnl);
            this.Controls.Add(this.final);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.info_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestMenu";
            this.Text = "ΘΑΛΗΣ-Μενού Αξιολόγησης";
//            this.Load += new System.EventHandler(this.TestMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button test1;
        private System.Windows.Forms.Button test2;
        private System.Windows.Forms.Button test3;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.Panel back_pnl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button progressbut;
    }
}

