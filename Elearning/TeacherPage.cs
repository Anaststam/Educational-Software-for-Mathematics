using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elearning
{
    public partial class TeacherPage : Form
    {
        public TeacherPage()
        {
            InitializeComponent();
        }
        public static void OpenForm()
        {
            Application.Run(new LogInForm());
        }
        private void Log_out_but_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=   MessageBox.Show("Eίστε σίγουρός ό,τι θέλετε να αποχωρήσετε;", "Προειδοποίηση", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
                this.Close();
                t.Start();
            }
        }
        public static void OpenProccess()
        {
            Application.Run(new StudentProccess());
        }

        private void proodos_but_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenProccess));
            this.Close();
            t.Start();
        }
        public static void OpenTheory()
        {
            Application.Run(new theory());
        }
        private void theory_but_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTheory));
            this.Close();
            t.Start();
        }

        private void TeacherPage_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = LogInForm.name_s +" "+ LogInForm.surname_s;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        public static void OpenRevTestProodos()
        {
            Application.Run(new RevTestProssecc());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenRevTestProodos));
            this.Close();
            t.Start();
        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσήρθατε στο εκπαιδευτικό λογισμικό ΘΑΛΗΣ.Μπορείτε να δείτε την πρόοδο των μαθητών σας πατώντας το κουμπί 'ΠΡΟΟΔΟΣ'.Επίσης μπορείτε να προσθέσετε ερωτήσεις για τα διαγωνίσματα πατώντας το κουμπί 'ΠΡΟΣΘΗΚΗ ΕΡΩΤΗΣΕΩΝ' .", "Βοηθεια");
        }

        public static void OpenProsthikiErwthsewn()
        {
            Application.Run(new ProsthikiErwthsewn());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenProsthikiErwthsewn));
            this.Close();
            t.Start();
        }

       
    }
    }

