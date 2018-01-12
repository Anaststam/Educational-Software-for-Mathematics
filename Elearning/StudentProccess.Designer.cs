namespace Elearning
{
    partial class StudentProccess
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentProccess));
            this.info_panel = new System.Windows.Forms.Panel();
            this.welcome_teacher_box = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Students_list = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.one_box = new System.Windows.Forms.TextBox();
            this.back_pnl = new System.Windows.Forms.Panel();
            this.two_box = new System.Windows.Forms.TextBox();
            this.three_box = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.chap1_txtbox = new System.Windows.Forms.TextBox();
            this.dif_weak1 = new System.Windows.Forms.TextBox();
            this.dif_weak2 = new System.Windows.Forms.TextBox();
            this.chap2_txtbox = new System.Windows.Forms.TextBox();
            this.dif_weak3 = new System.Windows.Forms.TextBox();
            this.chap3_txtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
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
            this.welcome_teacher_box.Location = new System.Drawing.Point(364, 12);
            this.welcome_teacher_box.Name = "welcome_teacher_box";
            this.welcome_teacher_box.ReadOnly = true;
            this.welcome_teacher_box.Size = new System.Drawing.Size(219, 28);
            this.welcome_teacher_box.TabIndex = 5;
            this.welcome_teacher_box.Text = "Πρόοδοι Μαθητών";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.SeaShell;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(217, 69);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Grades";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 244);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // Students_list
            // 
            this.Students_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Students_list.FormattingEnabled = true;
            this.Students_list.Location = new System.Drawing.Point(3, 83);
            this.Students_list.Name = "Students_list";
            this.Students_list.Size = new System.Drawing.Size(189, 21);
            this.Students_list.TabIndex = 9;
            this.Students_list.SelectedIndexChanged += new System.EventHandler(this.Students_list_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(13, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 15);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Διαλέξτε έναν μαθητή :";
            // 
            // one_box
            // 
            this.one_box.BackColor = System.Drawing.Color.SeaShell;
            this.one_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.one_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.one_box.Location = new System.Drawing.Point(456, 344);
            this.one_box.Name = "one_box";
            this.one_box.ReadOnly = true;
            this.one_box.Size = new System.Drawing.Size(22, 17);
            this.one_box.TabIndex = 12;
            // 
            // back_pnl
            // 
            this.back_pnl.BackgroundImage = global::Elearning.Properties.Resources.Arrows_Back_icon;
            this.back_pnl.Location = new System.Drawing.Point(12, 12);
            this.back_pnl.Name = "back_pnl";
            this.back_pnl.Size = new System.Drawing.Size(29, 32);
            this.back_pnl.TabIndex = 26;
            this.back_pnl.Click += new System.EventHandler(this.back_click);
            // 
            // two_box
            // 
            this.two_box.BackColor = System.Drawing.Color.SeaShell;
            this.two_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.two_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.two_box.Location = new System.Drawing.Point(484, 344);
            this.two_box.Name = "two_box";
            this.two_box.ReadOnly = true;
            this.two_box.Size = new System.Drawing.Size(20, 17);
            this.two_box.TabIndex = 27;
            // 
            // three_box
            // 
            this.three_box.BackColor = System.Drawing.Color.SeaShell;
            this.three_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.three_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.three_box.Location = new System.Drawing.Point(510, 344);
            this.three_box.Name = "three_box";
            this.three_box.ReadOnly = true;
            this.three_box.Size = new System.Drawing.Size(23, 17);
            this.three_box.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SeaShell;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox3.Location = new System.Drawing.Point(129, 346);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(321, 15);
            this.textBox3.TabIndex = 30;
            this.textBox3.Text = "Αδύναμα κεφάλαια σύμφωνα με το τελικό διαγώνισμα  : ";
            // 
            // chap1_txtbox
            // 
            this.chap1_txtbox.BackColor = System.Drawing.Color.SeaShell;
            this.chap1_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chap1_txtbox.Location = new System.Drawing.Point(129, 367);
            this.chap1_txtbox.Name = "chap1_txtbox";
            this.chap1_txtbox.ReadOnly = true;
            this.chap1_txtbox.Size = new System.Drawing.Size(381, 22);
            this.chap1_txtbox.TabIndex = 31;
            this.chap1_txtbox.Text = "Ο μαθητής παρουσιάζει αδυναμία στο Κεφάλαιο 1 στο επίπεδο :";
            this.chap1_txtbox.Visible = false;
            // 
            // dif_weak1
            // 
            this.dif_weak1.BackColor = System.Drawing.Color.SeaShell;
            this.dif_weak1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dif_weak1.Location = new System.Drawing.Point(517, 367);
            this.dif_weak1.Name = "dif_weak1";
            this.dif_weak1.ReadOnly = true;
            this.dif_weak1.Size = new System.Drawing.Size(132, 20);
            this.dif_weak1.TabIndex = 32;
            this.dif_weak1.Visible = false;
            // 
            // dif_weak2
            // 
            this.dif_weak2.BackColor = System.Drawing.Color.SeaShell;
            this.dif_weak2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dif_weak2.Location = new System.Drawing.Point(517, 393);
            this.dif_weak2.Name = "dif_weak2";
            this.dif_weak2.ReadOnly = true;
            this.dif_weak2.Size = new System.Drawing.Size(132, 20);
            this.dif_weak2.TabIndex = 34;
            this.dif_weak2.Visible = false;
            // 
            // chap2_txtbox
            // 
            this.chap2_txtbox.BackColor = System.Drawing.Color.SeaShell;
            this.chap2_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chap2_txtbox.Location = new System.Drawing.Point(129, 393);
            this.chap2_txtbox.Name = "chap2_txtbox";
            this.chap2_txtbox.ReadOnly = true;
            this.chap2_txtbox.Size = new System.Drawing.Size(381, 22);
            this.chap2_txtbox.TabIndex = 33;
            this.chap2_txtbox.Text = "Ο μαθητής παρουσιάζει αδυναμία στο Κεφάλαιο 2 στο επίπεδο :";
            this.chap2_txtbox.Visible = false;
            // 
            // dif_weak3
            // 
            this.dif_weak3.BackColor = System.Drawing.Color.SeaShell;
            this.dif_weak3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dif_weak3.Location = new System.Drawing.Point(517, 419);
            this.dif_weak3.Name = "dif_weak3";
            this.dif_weak3.ReadOnly = true;
            this.dif_weak3.Size = new System.Drawing.Size(132, 20);
            this.dif_weak3.TabIndex = 36;
            this.dif_weak3.Visible = false;
            // 
            // chap3_txtbox
            // 
            this.chap3_txtbox.BackColor = System.Drawing.Color.SeaShell;
            this.chap3_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chap3_txtbox.Location = new System.Drawing.Point(129, 419);
            this.chap3_txtbox.Name = "chap3_txtbox";
            this.chap3_txtbox.ReadOnly = true;
            this.chap3_txtbox.Size = new System.Drawing.Size(381, 22);
            this.chap3_txtbox.TabIndex = 35;
            this.chap3_txtbox.Text = "Ο μαθητής παρουσιάζει αδυναμία στο Κεφάλαιο 3 στο επίπεδο :";
            this.chap3_txtbox.Visible = false;
            // 
            // StudentProccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(879, 474);
            this.Controls.Add(this.dif_weak3);
            this.Controls.Add(this.chap3_txtbox);
            this.Controls.Add(this.dif_weak2);
            this.Controls.Add(this.chap2_txtbox);
            this.Controls.Add(this.dif_weak1);
            this.Controls.Add(this.chap1_txtbox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.three_box);
            this.Controls.Add(this.two_box);
            this.Controls.Add(this.back_pnl);
            this.Controls.Add(this.one_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Students_list);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.welcome_teacher_box);
            this.Controls.Add(this.info_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentProccess";
            this.Text = "ΘΑΛΗΣ-Σελίδα Προόδου Μαθητών";
            this.Load += new System.EventHandler(this.StudentProccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.TextBox welcome_teacher_box;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox Students_list;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox one_box;
        private System.Windows.Forms.Panel back_pnl;
        private System.Windows.Forms.TextBox two_box;
        private System.Windows.Forms.TextBox three_box;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox chap1_txtbox;
        private System.Windows.Forms.TextBox dif_weak1;
        private System.Windows.Forms.TextBox dif_weak2;
        private System.Windows.Forms.TextBox chap2_txtbox;
        private System.Windows.Forms.TextBox dif_weak3;
        private System.Windows.Forms.TextBox chap3_txtbox;
    }
}

