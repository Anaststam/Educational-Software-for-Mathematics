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
    public partial class Chapter2 : Form
    {
        public Chapter2()
        {
            InitializeComponent();
        }

        public static void OpenForm()
        {
            Application.Run(new theory());
        }


        private void Back_click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == "Διάλεξε Ενότητα")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.intro_ch2;


            }

            else if (comboBox.SelectedItem == "2.1. Η έννοια του κλάσματος")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2_1;

            }
            else if (comboBox.SelectedItem == "2.2. Ισοδύναμα κλάσματα")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2_2;

            }
            else if (comboBox.SelectedItem == "2.3. Σύγκριση κλασμάτων")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2_3;

            }
            else if (comboBox.SelectedItem == "2.4. Πρόσθεση και Αφαίρεση κλασμάτων")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2_4;

            }
            else if (comboBox.SelectedItem == "2.5. Πολλαπλασιασμός κλασμάτων")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2_5;

            }
          
        
        }

        [STAThread]
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(new Ch2Video());
            //Ch2Video T = new Ch2Video();
            //T.Show();
        }


        public static void Open()
        {
            Application.Run(new Ch2Video());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Open));
            this.Close();
            t.ApartmentState = System.Threading.ApartmentState.STA;
            t.Start();

            
            
        }

        private void Chapter2_Load(object sender, EventArgs e)
        {
            comboBox.SelectedItem = "Διάλεξε Ενότητα";
        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σου παρουσιάζεται η διαθέσιμη θεωρία για το κεφάλαιο 2.Μπορείς να διαλέξεις το υλικό που θέλεις να διαβάσεις επιλέγοντας απο την λίστα την ενότητα που θες.Επίσης μπορείς να παρακολουθήσεις την θεωρία με την μορφή βίντεο πατώντας το κουμπί 'ΠΑΡΑΚΟΛΟΥΘΗΣΗ ΒΙΝΤΕΟ'.", "Βοηθεια");
        }
    }
}
