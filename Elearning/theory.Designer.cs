namespace Elearning
{
    partial class theory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theory));
            this.chapt1_but = new System.Windows.Forms.Button();
            this.chapt2_but = new System.Windows.Forms.Button();
            this.chapt4_but = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.back_pnl = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // chapt1_but
            // 
            this.chapt1_but.Location = new System.Drawing.Point(154, 210);
            this.chapt1_but.Name = "chapt1_but";
            this.chapt1_but.Size = new System.Drawing.Size(128, 56);
            this.chapt1_but.TabIndex = 0;
            this.chapt1_but.Text = "ENOTHTA 1";
            this.chapt1_but.UseVisualStyleBackColor = true;
            this.chapt1_but.Click += new System.EventHandler(this.Chapter1_open);
            // 
            // chapt2_but
            // 
            this.chapt2_but.Location = new System.Drawing.Point(367, 210);
            this.chapt2_but.Name = "chapt2_but";
            this.chapt2_but.Size = new System.Drawing.Size(128, 56);
            this.chapt2_but.TabIndex = 1;
            this.chapt2_but.Text = "ENOTHTA 2";
            this.chapt2_but.UseVisualStyleBackColor = true;
            this.chapt2_but.Click += new System.EventHandler(this.Chapter2_open);
            // 
            // chapt4_but
            // 
            this.chapt4_but.Location = new System.Drawing.Point(585, 213);
            this.chapt4_but.Name = "chapt4_but";
            this.chapt4_but.Size = new System.Drawing.Size(128, 53);
            this.chapt4_but.TabIndex = 3;
            this.chapt4_but.Text = "ΕΝΟΤΗΤΑ 3";
            this.chapt4_but.UseVisualStyleBackColor = true;
            this.chapt4_but.Click += new System.EventHandler(this.Chapter3_open);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(286, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(343, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "ΘΕΩΡΙΑ ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // back_pnl
            // 
            this.back_pnl.BackgroundImage = global::Elearning.Properties.Resources.Arrows_Back_icon;
            this.back_pnl.Location = new System.Drawing.Point(12, 12);
            this.back_pnl.Name = "back_pnl";
            this.back_pnl.Size = new System.Drawing.Size(29, 32);
            this.back_pnl.TabIndex = 5;
            this.back_pnl.Click += new System.EventHandler(this.Back_click);
            // 
            // info_panel
            // 
            this.info_panel.BackgroundImage = global::Elearning.Properties.Resources.Sys_Help_icon;
            this.info_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info_panel.Location = new System.Drawing.Point(820, 12);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(47, 47);
            this.info_panel.TabIndex = 6;
            this.info_panel.Click += new System.EventHandler(this.info_panel_Click);
            // 
            // theory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.back_pnl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chapt4_but);
            this.Controls.Add(this.chapt2_but);
            this.Controls.Add(this.chapt1_but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "theory";
            this.Text = "ΘΑΛΗΣ-Θεωρία";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chapt1_but;
        private System.Windows.Forms.Button chapt2_but;
        private System.Windows.Forms.Button chapt4_but;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel back_pnl;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}