using System;
using MySql.Data.MySqlClient;
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
    public partial class ProsthikiErwthsewn : Form
{

        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;
        string s1;

        public ProsthikiErwthsewn()
        {
            InitializeComponent();
        }
        public static void OpenTeacherpage()
        {
            Application.Run(new TeacherPage());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((questionInput.Text == "" & kefalaio.Text == "" & diskolia.Text == "" & answer1.Text == "" & answer2.Text == "" & answer3.Text == "" & (AnswerButton1.Checked | AnswerButton2.Checked | AnswerButton3.Checked)))
                {
                    MessageBox.Show("Πρέπει να συμπληρώσετε όλα τα πεδία", "ERROR");
                }


                else if (questionInput.Text != "" & kefalaio.Text != "" & diskolia.Text != "" & answer1.Text != "" & answer2.Text != "" & answer3.Text != "" & (AnswerButton1.Checked | AnswerButton2.Checked | AnswerButton3.Checked))
                {
                    if ((diskolia.Text == "e" | diskolia.Text == "m" | diskolia.Text == "d") & (kefalaio.Text == "1" | kefalaio.Text == "2" | kefalaio.Text == "3") & (answer1.Text != answer2.Text) & (answer2.Text != answer3.Text) & (answer1.Text != answer3.Text))
                    {
                        con.Open();


                        s = "Select * From elearningdb.questions Where question='" + questionInput.Text + "';";
                        mcd = new MySqlCommand(s, con);
                        mdr = mcd.ExecuteReader();


                        if (mdr.Read())
                        {

                            MessageBox.Show("H ερώτηση υπάρχει ήδη", "ΕRROR");

                        }

                        else
                        {
                            con.Close();
                            con.Open();
                            MySqlCommand cmd = con.CreateCommand();
                            string teacher_id = LogInForm.id_s;

                            if (AnswerButton1.Checked == true)
                            {
                                // string usname = LogInForm.username_s ;
                                //s1 = "Select userid From elearningdb.users where username=usname"; 


                                cmd.CommandText = "INSERT INTO questions (question,kefalaio,difficulty,panswer1,panswer2,panswer3,RightAnswer,TeacherID) VALUES ('" + questionInput.Text + "','" + kefalaio.Text + "','" + diskolia.Text + "', '" + answer1.Text + "','" + answer2.Text + "','" + answer3.Text + "',1,'" + teacher_id + "')";
                                //cmd.Prepare();
                                cmd.ExecuteNonQuery();


                            }
                            else if (AnswerButton2.Checked == true)
                            {
                                cmd.CommandText = "INSERT INTO questions (question,kefalaio,difficulty,panswer1,panswer2,panswer3,RightAnswer,TeacherID) VALUES ('" + questionInput.Text + "','" + kefalaio.Text + "','" + diskolia.Text + "', '" + answer1.Text + "','" + answer2.Text + "','" + answer3.Text + "',2,'" + teacher_id + "')";

                                cmd.ExecuteNonQuery();

                            }
                            else if (AnswerButton3.Checked == true)
                            {
                                cmd.CommandText = "INSERT INTO questions (question,kefalaio,difficulty,panswer1,panswer2,panswer3,RightAnswer,TeacherID) VALUES ('" + questionInput.Text + "','" + kefalaio.Text + "','" + diskolia.Text + "', '" + answer1.Text + "','" + answer2.Text + "','" + answer3.Text + "',3,'" + teacher_id + "')";

                                cmd.ExecuteNonQuery();
                            }
                        }





                        con.Close();
                        DialogResult res = MessageBox.Show("H καταχώρηση της ερώτησης ολοκληρώθηκε επιτυχώς ", "Success");


                        if (res == DialogResult.OK)
                        {

                            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTeacherpage));
                            this.Close();
                            t.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Δεν έχετε συμπληρώσει σωστά τα πεδία 'ΚΕΦΑΛΑΙΟ' ή 'ΔΥΣΚΟΛΙΑ' ή οι απαντήσεις που δώσατε είναι ίδιες μεταξύ του.Για περισσότερες πληροφορίες διαβάστε την 'ΒΟΗΘΕΙΑ'.", "ERROR");
                    }


                    





                }
                else
                {
                    MessageBox.Show("Δεν έχετε συμπληρώσει όλα τα πεδία", "ERROR");
                }


            }



            catch (Exception)
            {

            }
                

              









           


        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Βρίσκεστε στην σελίδα του καθηγητή 'ΚΑΤΑΣΚΕΥΗ ΤΕΣΤ'.Μπορείτε να δημιουργήσετε και να προσθέσετε τις δικές σας ερωτήσεις.Υποχρεωτικά πρέπει να συμπληρώσετε όλα τα πεδία και οι πιθανές απαντήσεις να είναι διαφορετικές μεταξύ τους.Οι επιτρεπτές τιμές για το κεφάλαιο είναι 1,2 η 3.Οι επιτρεπτές τιμές για την δυσκολία είναι e,m η d.Πατήστε το κουμπί 'ΥΠΟΒΟΛΗ' για να καταχωρήσετε την ερώτησή σας. ", "Βοηθεια");
        }

        private void back_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        public static void OpenTeacherPage()
        {
            Application.Run(new TeacherPage());
        }

        private void back_pnl_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTeacherPage));
            this.Close();
            t.Start();
        }
    }
}
