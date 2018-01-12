using MySql.Data.MySqlClient;
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
    public partial class LogInForm : Form
    {
        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;
        public static string name_s="";
        public static string surname_s;
        public static string username_s;
        public static string id_s;
        public LogInForm()
        {
            InitializeComponent();
        }

        public static void OpenSignup()
        {
            Application.Run(new SignUpForm());
        }

        private void Signup_action(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenSignup));
            this.Close();
            t.Start();
        }

        public static void OpenForm()
        {
            Application.Run(new MainPage());
        }

        public static void OpenFormTeacher()
        {
            Application.Run(new TeacherPage());
        }
        private void login_but_Click(object sender, EventArgs e)
        {
            

            try
            {
                con.Open();
                s = "Select * From elearningdb.users Where username='" + usernameInput.Text +"' AND password='" + passwordInput.Text + "';";
                mcd = new MySqlCommand(s, con);
                mdr = mcd.ExecuteReader();

                if (mdr.Read())
                {

                   

                    
                   
                    string type_s = mdr.GetString("type");
                    id_s = mdr.GetString("userid");

                    if (type_s == "2")
                    {
                        username_s = mdr.GetString("username");
                        name_s = mdr.GetString("name");
                        surname_s = mdr.GetString("surname");
                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenFormTeacher));
                        this.Close();
                        t.Start();
                        toolStripStatusLabel1.Text = "Log in Succefully";



                    }
                    else {
                        username_s = mdr.GetString("username");
                        name_s = mdr.GetString("name");
                        surname_s = mdr.GetString("surname");

                        System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
                        this.Close();
                        t.Start();
                        toolStripStatusLabel1.Text = "Log in Succefully";

                    }

                    

                }
                else
                {
                    MessageBox.Show("Ο συνδυασμός ονόματος χρήστης και κωδικός που καταχωρείτε δεν ταιριάζουν ", "Error");
                }
                con.Close();
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Data Readng Error";
            }




        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Καλωσήρθατε στο εκπαιδευτικό λογισμικό ΘΑΛΗΣ.Αν δεν είστε μέλος της κοινότητάς μπορείτε να κάνετε εγγραφή πατώντας το κουμπί 'ΕΓΓΡΑΦΗ'.Διαφορετικά,πληκτρολογήστε το username και τον προσωπικό σας κωδικό και πατήστε 'ΕΙΣΟΔΟΣ'.", "Βοηθεια");
        }

        private void info_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
