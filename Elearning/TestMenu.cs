using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class TestMenu : Form
    {

        //MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        //MySqlCommand mcd;
        //MySqlDataReader mdr;
        //string s;
        public TestMenu()
        {
            InitializeComponent();
        }

        public static void OpenMainPage()
        {
            Application.Run(new MainPage());
        }

        private void back_pnl_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMainPage));
            this.Close();
            t.Start();
        }

        public static void OpenTest1()
        {
            Application.Run(new Test1());
        }

        public static void OpenTest2()
        {
            Application.Run(new Test2());
        }

        public static void OpenTest3()
        {
            Application.Run(new Test3());
        }

        private void test1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTest1));
            this.Close();
            t.Start();
        }

        private void test2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTest2));
            this.Close();
            t.Start();
        }

        private void test3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTest3));
            this.Close();
            t.Start();

        }
        public static void OpenRevTest()
        {
            Application.Run(new RevTest());
        }



        private void final_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenRevTest));
            this.Close();
            t.Start();
        }

        //public static void OpenChapter3()
        //{
        //    Application.Run(new Chapter3());
        //}
        //private void button5_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter3));
        //    this.Close();
        //    t.Start();
        //}

        //private void TestMenu_Load(object sender, EventArgs e)
        //{
           

        //    MySqlCommand cmd = con.CreateCommand();
        //    MySqlCommand cmd2 = con.CreateCommand();
        //    string username = LogInForm.username_s;
        //    con.Open();
        //    s = "Select rs.chap1weak    From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where u.username= '" + username + "' AND( chap1weak = 'check');";
        //    mcd = new MySqlCommand(s, con);
        //    mdr = mcd.ExecuteReader();

        //    if (mdr.Read())
        //    {
        //        string weak1 = mdr.GetString("chap1weak");
        //        if (weak1 == "check")
        //        {
        //            Intro_txt.Visible = true;
        //            Theoria_col.Visible = true;
        //            RevTest_col.Visible = true;

        //            Ch1_but.Visible = true;
        //            RevTest1_but.Visible = true;

        //        }
        //    }
        //    mdr.Close();

        //    s = "Select  rs.chap2weak  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where u.username= '" + username + "' AND( chap2weak = 'check');";
        //    mcd = new MySqlCommand(s, con);
        //    mdr = mcd.ExecuteReader();

        //    if (mdr.Read())
        //    {
        //        string weak2 = mdr.GetString("chap2weak");
        //        if (weak2 == "check")
        //        {
        //            Intro_txt.Visible = true;
        //            Theoria_col.Visible = true;
        //            RevTest_col.Visible = true;

        //            Ch2_but.Visible = true;
        //            RevTest2_but.Visible = true;

        //        }
        //    }
        //    mdr.Close();

        //    s = "Select  rs.chap3weak  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where u.username= '" + username + "' AND( chap3weak = 'check');";
        //    mcd = new MySqlCommand(s, con);
        //    mdr = mcd.ExecuteReader();

           

        //    if (mdr.Read())
        //    {

        //        string weak3 = mdr.GetString("chap3weak");
        //        if (weak3 == "check")
        //        {
        //            Intro_txt.Visible = true;
        //            Theoria_col.Visible = true;
        //            RevTest_col.Visible = true;

        //            Ch3_but.Visible = true;
        //            RevTest3_but.Visible = true;

        //        }



        //    }
        //    mdr.Close();
        //    con.Close();
        //}
        //public static void OpenChapter1()
        //{
        //    Application.Run(new Chapter1());
        //}
        //private void Ch1_but_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter1));
        //    this.Close();
        //    t.Start();
        //}
        //public static void OpenChapter2()
        //{
        //    Application.Run(new Chapter2());
        //}

        //private void Ch2_but_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenChapter2));
        //    this.Close();
        //    t.Start();
        //}

        //public static void OpenRevTest1()
        //{
        //    Application.Run(new Kef1());
        //}

        //private void RevTest1_but_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenRevTest1));
        //    this.Close();
        //    t.Start();
        //}
        //public static void OpenRevTest2()
        //{
        //    Application.Run(new Kef2());
        //}

        //private void RevTest2_but_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenRevTest2));
        //    this.Close();
        //    t.Start();
        //}

        //public static void OpenRevTest3()
        //{
        //    Application.Run(new Kef3());
        //}

        //private void RevTest3_but_Click(object sender, EventArgs e)
        //{
        //    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenRevTest3));
        //    this.Close();
        //    t.Start();
        //}

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Βρίσκεσαι στην κεντρική σελίδα των διαγωνισμάτων.Μπορείς να διαλέξεις να πραγματοποιήσεις όποιο διαγώνισμα επιθυμείς.Το επαναληπτικό διαγώνισμα περιέχει ερώτησεις από όλα τα κεφάλαια της θεωρίας.Τά διαγωνίσματα για το κεφάλαιο 1,2 και 3 περιέχουν ερωτήσεις από τα αντίστοιχα κεφάλαια.Τα τεστ είναι προσαρμοστικά,δηλαδή ανάλογα με τα λάθη σου την επόμενη φορά που θα το επαναλάβεις οι ερωτήσεις θα είναι ίδιου επιπέδου δυσκολίας με αυτές που απάντησες λάθος την τελευταία φορά.Προτείνεται να διαβάσεις πρώτα την θεωρία και μετά να πραγματοποιήσεις τα διαγωνίσματα.Καλή επιτυχία!", "Βοηθεια");
        }

        public static void OpenMyProgress()
        {
            Application.Run(new MyProgress());
        }

        private void progressbut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMyProgress));
            this.Close();
            t.Start();
        }
    }
    }






