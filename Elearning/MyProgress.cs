using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elearning
{
    public partial class MyProgress : Form
    {
        public MyProgress()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand command, command2, mcd;
       
        MySqlDataReader mdr;
        string userid = LogInForm.id_s;
        MySqlDataAdapter adapter;
        DataTable table;


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //pictureBox1.Image = new Bitmap(@"C:/Users/stasa/Desktop/sun.png");



        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            
        }

       

        private void MyProgress_Load(object sender, EventArgs e)
        {
            chapt4_but.Visible = false;
            chapt2_but.Visible = false;
            chapt1_but.Visible = false;

            textBox6.Text = LogInForm.name_s + " " + LogInForm.surname_s;

            string test1, test2, final, test3, q1, q2, q3, q4,adunamia1,adunamia2,adunamia3,adunamia4;

            

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
           // this.one_box.Text = null;

            con.Open();
            q1 = "Select test1,chap1weak From elearningdb.results WHERE userid='" +userid+"' AND test1>='0' ;";
            command2 = new MySqlCommand(q1, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test1 = mdr.GetString("test1");
                double y1 ;
                Double.TryParse(test1, out y1);
                adunamia1 = mdr.GetString("chap1weak");
                if (adunamia1 == "e")
                {
                    textBox11.Text = "Εύκολες ερωτήσεις";


                }
                else if (adunamia1 == "m")
                {
                    textBox11.Text = "Μεσαίες Ερωτήσεις";
                }
                else if (adunamia1 == "d")
                {
                    textBox11.Text = "Δύσκολες Ερωτήσεις";
                }
                else
                {
                    textBox11.Text = "Δεν έχεις αδυναμία";
                }
                this.chart1.Series["Grades"].Points.AddXY("test1", y1);
            }

            con.Close();

            con.Open();
            q2 = "Select test2,chap2weak From elearningdb.results WHERE userid='" + userid+ "' AND test2>='0' ;";
            command2 = new MySqlCommand(q2, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test2 = mdr.GetString("test2");
                double y15;
                Double.TryParse(test2, out y15);
                adunamia2 = mdr.GetString("chap2weak");
                if (adunamia2 == "e")
                {
                    textBox12.Text = "Εύκολες ερωτήσεις";


                }
                else if (adunamia2 == "m")
                {
                    textBox12.Text = "Μεσαίες Ερωτήσεις";
                }
                else if (adunamia2 == "d")
                {
                    textBox12.Text = "Δύσκολες Ερωτήσεις";
                }
                else
                {
                    textBox12.Text = "Δεν έχεις αδυναμία";
                }
                this.chart1.Series["Grades"].Points.AddXY("test2", y15);
            }

            con.Close();

            con.Open();
            q3 = "Select test3,chap3weak From elearningdb.results WHERE userid='" + userid + "' AND test3>='0' ;";
            command2 = new MySqlCommand(q3, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test3 = mdr.GetString("test3");
                double y16;
                Double.TryParse(test3, out y16);
                adunamia3 = mdr.GetString("chap3weak");
               
                if (adunamia3 == "e")
                {
                    textBox13.Text = "Εύκολες ερωτήσεις" ;

                    
                }
                else if (adunamia3 == "m")
                {
                    textBox13.Text = "Μεσαίες Ερωτήσεις";
                }
                else if (adunamia3 == "d")
                {
                    textBox13.Text = "Δύσκολες Ερωτήσεις";
                }
                else
                {
                    textBox13.Text = "Δεν έχεις αδυναμία";
                }
                this.chart1.Series["Grades"].Points.AddXY("test3", y16);
            }

            con.Close();

            con.Open();
            q4 = "Select final,weakness From elearningdb.results WHERE userid='" + userid + "' AND final>='0';";
            command2 = new MySqlCommand(q4, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {




                final = mdr.GetString("final");
                double f;
                Double.TryParse(final, out f);
                adunamia4 = mdr.GetString("weakness");
                

                if (adunamia4 == "1")
                {
                    textBox14.Text = "ΚΕΦ1";
            
                    chapt1_but.Visible = true;
                }
                else if(adunamia4=="2")
                {
                    textBox14.Text = "ΚΕΦ2";
                    chapt2_but.Visible = true;
                }
                else if (adunamia4 == "3")
                {
                    textBox14.Text = "ΚΕΦ3";
                    chapt4_but.Visible = true;
                }
                else
                {
                    textBox14.Text = "Δεν έχεις αδυναμία";
                }

                this.chart1.Series["Grades"].Points.AddXY("final", f);

            }

            mdr.Close();
            con.Close();


            















            con.Open();
            string s, y;
            double grade;

            s = "Select test1 from results where userid = '" + userid + "' and test1>0 ";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())

            {

                y = mdr.GetString("test1");


                Double.TryParse(y, out grade);
                if (grade <= 50 && grade > 0)
                {
                    pictureBox1.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\crying.png");
                }
                else if (grade <= 80 && grade > 50)
                {
                    pictureBox1.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\medium.png");
                }
                else
                {
                    pictureBox1.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\sun.png");
                }

            }
            else
            {
                
            }

            con.Close();

            con.Open();
            string s2, y2;
            double grade2;

            s2 = "Select test2 from results where userid = '" + userid + "' and test2>0 ";
            mcd = new MySqlCommand(s2, con);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())

            {

                y2 = mdr.GetString("test2");


                Double.TryParse(y2, out grade2);
                if (grade2 <= 50 && grade2 > 0)
                {
                    pictureBox2.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\crying.png");
                }
                else if (grade2 <= 80 && grade2 > 50)
                {
                    pictureBox2.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\medium.png");
                }
                else
                {
                    pictureBox2.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\sun.png");
                }

            }
            else
            {

            }

            con.Close();

            con.Open();
            string s3, y3;
            double grade3;

            s3 = "Select test3 from results where userid = '" + userid + "' and test3>0 ";
            mcd = new MySqlCommand(s3, con);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())

            {

                y3 = mdr.GetString("test3");


                Double.TryParse(y3, out grade3);
                if (grade3 <= 50 && grade3 > 0)
                {
                    pictureBox3.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\crying.png");
                }
                else if (grade3 <= 80 && grade3 > 50)
                {
                    pictureBox3.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\medium.png");
                }
                else
                {
                    pictureBox3.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\sun.png");
                }

            }
            else
            {

            }

            con.Close();

            





            con.Open();
            string s4, y4;
            double grade4;

            s4 = "Select final from results where userid = '" + userid + "' and final>0 ";
            mcd = new MySqlCommand(s4, con);
            mdr = mcd.ExecuteReader();
            if (mdr.Read())

            {

                y4 = mdr.GetString("final");


                Double.TryParse(y4, out grade4);
                if (grade4 <= 50 && grade4 > 0)
                {
                    pictureBox4.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\crying.png");
                }
                else if (grade4 <= 75 && grade4 > 50)
                {
                    pictureBox4.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\medium.png");
                }
                else
                {
                    pictureBox4.Image = new Bitmap(@" C:\Users\stasa\Desktop\Elearning\Elearning\Resources\sun.png");
                }

            }
            else
            {

            }

            con.Close();


        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
        public static void OpenTheory1()
        {
            Application.Run(new Chapter1());
        }

        private void chapt1_but_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTheory1));
            this.Close();
            t.Start();
        }

        public static void OpenTheory2()
        {
            Application.Run(new Chapter2());
        }

        private void chapt2_but_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTheory2));
            this.Close();
            t.Start();
        }

        public static void OpenTheory3()
        {
            Application.Run(new Chapter3());
        }

        private void chapt4_but_Click(object sender, EventArgs e)
        {

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTheory3));
            this.Close();
            t.Start();
        }

        public static void OpenForm()
        {
            Application.Run(new TestMenu());
        }


        private void Back_click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Βρίσκεστε στην σελίδα 'ΠΡΟΟΔΟΣ'.Εδώ,μπορείτε να δείτε αναλυτικά τους βαθμούς σας σε κάθε διαγώνισμα και τις αδυναμίες που έχετε.Δεξιά,ανάλογα με την βαθμολογία του κάθε διαγωνίσματος κερδίζετε ένα αυτοκόλλητο.Αν δεν έχετε πραγματοποιήσει το διαγώνισμα δεν θα εμφανίζεται αυτοκόλλητο.", "Βοηθεια");
        }

    }

}