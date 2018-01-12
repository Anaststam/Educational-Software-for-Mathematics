namespace Elearning
{
    partial class Chapter1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chapter1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.back_pnl = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(12, 105);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(855, 357);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Διάλεξε Ενότητα",
            "1.1. Φυσικοί αριθμοί - Διάταξη Φυσικών - Στρογγυλοποίηση",
            "1.2. Πρόσθεση, αφαίρεση και πολλαπλασιασμός φυσικών αριθμών",
            "1.3. Δυνάμεις φυσικών αριθμών",
            "1.4. Ευκλείδεια διαίρεση - Διαιρετότητα"});
            this.comboBox.Location = new System.Drawing.Point(547, 78);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(320, 21);
            this.comboBox.TabIndex = 12;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // back_pnl
            // 
            this.back_pnl.BackgroundImage = global::Elearning.Properties.Resources.Arrows_Back_icon;
            this.back_pnl.Location = new System.Drawing.Point(12, 12);
            this.back_pnl.Name = "back_pnl";
            this.back_pnl.Size = new System.Drawing.Size(29, 32);
            this.back_pnl.TabIndex = 7;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(270, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 31);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Ενότητα 1 -";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaShell;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox2.ForeColor = System.Drawing.Color.Tomato;
            this.textBox2.Location = new System.Drawing.Point(425, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 31);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Φυσικοί Αριθμοί";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Παρακολούθηση Βίντεο";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chapter1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.back_pnl);
            this.Controls.Add(this.info_panel);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Chapter1";
            this.Text = "ΘΑΛΗΣ-Θεωρία";
            this.Load += new System.EventHandler(this.Chapter1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel back_pnl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}