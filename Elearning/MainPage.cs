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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        public static void OpenForm()
        {
            Application.Run(new theory());
        }

        private void Theory_but_Click(object sender, EventArgs e)
        {
            
           

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();
            


        }
        public static void OpenLoginForm()
        {
            Application.Run(new LogInForm());
        }

        private void Log_out_but_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Eίσαι σίγουρός ότι θέλετε να αποχωρήσετε;", "Προειδοποίηση", MessageBoxButtons.YesNo);


            if (dialogResult == DialogResult.Yes)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
                this.Close();
                t.Start();
            }
        }

        public static void OpenTestMenu()
        {
            Application.Run(new TestMenu());
        }

        private void Test_but_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTestMenu));
            this.Close();
            t.Start();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            textBox2.Text = LogInForm.name_s + " " + LogInForm.surname_s;
        }

        private void info_panel_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Βρίσκεσαι στην κύρια σελίδα του εκπαιδευτικού λογισμικού 'ΘΑΛΗΣ'.\n Μπορείς να περιηγηθείς στην διαθέσιμη θεωρία πατώντας το κουμπί 'ΘΕΩΡΙΑ'.\n Σε περίπτωση που έχεις ήδη διαβάσει την θεωρία και θες να δοκιμάσεις τις γνώσεις σου μπορείς να κάνεις ένα από τα διαθέσιμα τεστ πατώντας το κουμπί 'ΤΕΣΤ ΑΞΙΟΛΟΓΗΣΗΣ'.\n Καλή Περιήγηση! ", "Βοηθεια");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


