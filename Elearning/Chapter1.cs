using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Elearning
{
    public partial class Chapter1 : Form
    {
        public Chapter1()
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
                richTextBox1.SelectedRtf = Properties.Resources.intro_ch1;

            }

           else if (comboBox.SelectedItem == "1.1. Φυσικοί αριθμοί - Διάταξη Φυσικών - Στρογγυλοποίηση") {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter1;

            }
            else if (comboBox.SelectedItem == "1.2. Πρόσθεση, αφαίρεση και πολλαπλασιασμός φυσικών αριθμών")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter2;

            }
            else if (comboBox.SelectedItem == "1.3. Δυνάμεις φυσικών αριθμών")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter3;

            }
            else if (comboBox.SelectedItem == "1.4. Ευκλείδεια διαίρεση - Διαιρετότητα")
            {

                richTextBox1.Text = "";
                richTextBox1.SelectedRtf = Properties.Resources.chapter4;

            }
          

        }

        public static void Open()
        {
            Application.Run(new Ch1Video());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Open));
            this.Close();
            t.ApartmentState = System.Threading.ApartmentState.STA;
            t.Start();

          
            ;
        }

        private void Chapter1_Load(object sender, EventArgs e)
        {
            comboBox.SelectedItem = "Διάλεξε Ενότητα";
        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Σου παρουσιάζεται η διαθέσιμη θεωρία για το κεφάλαιο 1.Μπορείς να διαλέξεις το υλικό που θέλεις να διαβάσεις επιλέγοντας απο την λίστα την ενότητα που θες.Επίσης μπορείς να παρακολουθήσεις την θεωρία με την μορφή βίντεο πατώντας το κουμπί 'ΠΑΡΑΚΟΛΟΥΘΗΣΗ ΒΙΝΤΕΟ'.", "Βοηθεια");
        }
    }
}
