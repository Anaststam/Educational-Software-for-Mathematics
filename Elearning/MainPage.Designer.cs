namespace Elearning
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.Theory_but = new System.Windows.Forms.Button();
            this.Test_but = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.Log_out_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Theory_but
            // 
            this.Theory_but.BackColor = System.Drawing.Color.Transparent;
            this.Theory_but.Location = new System.Drawing.Point(357, 269);
            this.Theory_but.Name = "Theory_but";
            this.Theory_but.Size = new System.Drawing.Size(149, 54);
            this.Theory_but.TabIndex = 0;
            this.Theory_but.Text = "ΘΕΩΡΙΑ";
            this.Theory_but.UseVisualStyleBackColor = false;
            this.Theory_but.Click += new System.EventHandler(this.Theory_but_Click);
            // 
            // Test_but
            // 
            this.Test_but.Location = new System.Drawing.Point(357, 353);
            this.Test_but.Name = "Test_but";
            this.Test_but.Size = new System.Drawing.Size(149, 53);
            this.Test_but.TabIndex = 1;
            this.Test_but.Text = "ΤΕΣΤ ΑΞΙΟΛΟΓΗΣΗΣ";
            this.Test_but.UseVisualStyleBackColor = true;
            this.Test_but.Click += new System.EventHandler(this.Test_but_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Elearning.Properties.Resources.thales_logo2;
            this.panel2.Location = new System.Drawing.Point(357, 75);
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
            // Log_out_but
            // 
            this.Log_out_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log_out_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Log_out_but.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Log_out_but.Location = new System.Drawing.Point(771, 13);
            this.Log_out_but.Name = "Log_out_but";
            this.Log_out_but.Size = new System.Drawing.Size(96, 23);
            this.Log_out_but.TabIndex = 5;
            this.Log_out_but.Text = "Αποσύνδεση";
            this.Log_out_but.UseVisualStyleBackColor = true;
            this.Log_out_but.Click += new System.EventHandler(this.Log_out_but_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(247, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Γεια σου ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.Location = new System.Drawing.Point(353, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(401, 24);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Log_out_but);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.Test_but);
            this.Controls.Add(this.Theory_but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.Text = "ΘΑΛΗΣ-Αρχική Σελίδα ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Theory_but;
        private System.Windows.Forms.Button Test_but;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Log_out_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

