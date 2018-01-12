namespace Elearning
{
    partial class Kef2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kef2));
            this.Question = new System.Windows.Forms.TextBox();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.Color.SeaShell;
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question.Location = new System.Drawing.Point(25, 14);
            this.Question.Margin = new System.Windows.Forms.Padding(5);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(792, 205);
            this.Question.TabIndex = 0;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(130, 236);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(131, 24);
            this.Answer1.TabIndex = 1;
            this.Answer1.TabStop = true;
            this.Answer1.Text = "radioButton1";
            this.Answer1.UseVisualStyleBackColor = true;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(130, 279);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(131, 24);
            this.Answer2.TabIndex = 2;
            this.Answer2.TabStop = true;
            this.Answer2.Text = "radioButton2";
            this.Answer2.UseVisualStyleBackColor = true;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Answer3.Location = new System.Drawing.Point(130, 318);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(137, 25);
            this.Answer3.TabIndex = 3;
            this.Answer3.TabStop = true;
            this.Answer3.Text = "radioButton3";
            this.Answer3.UseVisualStyleBackColor = true;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(130, 358);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(131, 24);
            this.Answer4.TabIndex = 4;
            this.Answer4.TabStop = true;
            this.Answer4.Text = "radioButton4";
            this.Answer4.UseVisualStyleBackColor = true;
            // 
            // Next
            // 
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Next.Location = new System.Drawing.Point(590, 429);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(128, 33);
            this.Next.TabIndex = 5;
            this.Next.Text = "Επόμενο";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(739, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Υποβολή";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 473);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // Kef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(884, 495);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Question);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Kef2";
            this.Text = "ΘΑΛΗΣ-Μενού Αξιολόγησης";
            this.Load += new System.EventHandler(this.QuestionAnswer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}