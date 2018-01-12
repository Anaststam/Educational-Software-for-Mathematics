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
    public partial class theory : Form
    {
        public theory()
        {
            InitializeComponent();
        }

        public static void OpenForm()
        {
            Application.Run(new MainPage());
        }


        private void Back_click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();

        }

        public static void OpenChapter1()
        {
            Application.Run(new Chapter1());
        }

        private void Chapter1_open (object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter1));
            this.Close();
            t.Start();





        }

        public static void OpenChapter2()
        {
            Application.Run(new Chapter2());
        }

        private void Chapter2_open(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter2));
            this.Close();
            t.Start();



        }

        public static void OpenChapter3()
        {
            Application.Run(new Chapter3());
        }

        private void Chapter3_open(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter3));
            this.Close();
            t.Start();




        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Μπορείς να δεις την διαθέσιμη θεωρία για τα κεφάλαια 1,2 και 3 πατώντας το αντίστοιχο κουμπί.", "Βοηθεια");
        }

        
    }
}
