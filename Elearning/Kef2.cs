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
    public partial class Kef2 : Form
    {
        public Kef2()
        {
            InitializeComponent();
        }


        






        public int TotalNumberOfQuestions = 5;

        System.Collections.ArrayList lstNumbers;
        int CurrentQuestion;
        int QuestionCounter;
        int CurrentNumberOfQuestions;
        double Sum;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;

        int numofch1 = 0;
        int numofch2 = 0;
        int numofch3 = 0;


        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=6987690582; database=elearningdb");
        MySqlCommand mcd, cmd, cmd2;
        MySqlDataReader mdr;
        string s;


        void PresentQuestion(int qstNumber)
        {


            // lblQuestion.Visible = true;
            Question.Visible = true;

            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
            Answer4.Checked = false;

            switch (qstNumber)
            {

                case 1:
                    Question.Text = "Να κάνετε την πράξη 3/4 + 2/5";




                    Answer1.Text = "Α.6/20";
                    Answer2.Text = "Β.6/30";
                    Answer3.Text = "Γ.1/20";
                    Answer4.Text = "Δ.3/20";

                    break;

                case 2:

                    Question.Text = "Να κάνετε την πράξη 3/5 * 3/8";


                    Answer1.Text = "Α.5";
                    Answer2.Text = "Β.9/40";
                    Answer3.Text = "Γ.3";
                    Answer4.Text = "Δ.1";
                    break;

                case 3:
                    Question.Text = "Να κάνετε την πράξη 8/7 / 3";




                    Answer1.Text = "Α.0";
                    Answer2.Text = "B.5/7";
                    Answer3.Text = "Γ.6/7";
                    Answer4.Text = "Δ.20";

                    break;

                case 4:
                    Question.Text = "Να κάνετε την πράξη 2/5 * 2*1/2";




                    Answer1.Text = "Α.x=47";
                    Answer2.Text = "Β.x=96";
                    Answer3.Text = "Γ.x=65";
                    Answer4.Text = "Δ.x=1";


                    break;

                case 5:

                    Question.Text = "Να λύσετε την εξίσωση 6x - x = 20";


                    Answer1.Text = "Α.5";
                    Answer2.Text = "Β.4";
                    Answer3.Text = "Γ.3";
                    Answer4.Text = "Δ.1";
                    break;

                case 6:
                    Question.Text = "Να λύσετε το πρόβλημα:Ο Κώστας μετά από 5 χρόνια θα είναι 16 χρονών. Πόσων χρονών είναι σήμερα; (Με εξίσωση)";




                    Answer1.Text = "Α.x=47";
                    Answer2.Text = "Β.x=96";
                    Answer3.Text = "Γ.x=65";
                    Answer4.Text = "Δ.x=11";


                    break;

                case 7:
                    Question.Text = "Να λύσετε την παρακάτω εξίσωση x/5=21/15 ";



                    Answer1.Text = "Α.7";
                    Answer2.Text = "Β.8";
                    Answer3.Text = "Γ.9";
                    Answer4.Text = "Δ.10";

                    break;

                case 8:
                    Question.Text = "Να λύσετε την εξίσωση x-12=13";



                    Answer1.Text = "Α.0.3";
                    Answer2.Text = "Β.0.2";
                    Answer3.Text = "Γ.25";
                    Answer4.Text = "Δ.0.5";

                    break;


            }
        }

        void CheckAnswer(int qstNumber)
        {

            switch (qstNumber)
            {

                case 1://7
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;

                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch2++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    break;

                case 2://16
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch2++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    break;

                case 3://8
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch2++;
                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    break;

                case 4://17
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }

                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        numofch2++;
                        count2 = count2 + 1;
                    }
                    else if (Answer4.Checked == true)
                    {

                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch2++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count2 = count2 + 1;
                        numofch2++;
                    }
                    break;

                case 5://9
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else if (Answer2.Checked == true)
                    {

                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch3++;
                    }

                    else if (Answer3.Checked == true)
                    {

                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else if (Answer4.Checked == true)
                    {

                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    break;

                case 6://18
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch3++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count3 = count3 + 1;
                        numofch3++;
                    }
                    break;

                case 7://18
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch1++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    break;

                case 8://18
                    if (Answer1.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else if (Answer2.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else if (Answer3.Checked == true)
                    {
                        MessageBox.Show("Σωστό");
                        Sum++;
                        numofch1++;
                    }
                    else if (Answer4.Checked == true)
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    else
                    {
                        MessageBox.Show("Λάθος");
                        count1 = count1 + 1;
                        numofch1++;
                    }
                    break;

            }

            if (CurrentNumberOfQuestions == (TotalNumberOfQuestions))
            {
                Next.Visible = false;
                button1.Visible = true;



            }
            else
            {
                button1.Visible = false;

            }
        }




        public static void OpenTestMenu()
        {
            Application.Run(new TestMenu());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {


            double average = 1;

            if (QuestionCounter != 0)
                average = Sum / QuestionCounter;
            string strCongratulations = "";

            if (count2 <= (numofch2 / 2))
                strCongratulations = "\n Πέρασες την δοκιμασία του επαναληπτικού τεστ !";

            DialogResult res = MessageBox.Show("Συνολικές Ερωτήσεις : " +
                               QuestionCounter.ToString() +
                               "\nΣωστές Ερωτήσεις : " +
                               Sum.ToString() +
                               "\nΠοσοστό επιτυχίας :                   " +
                               (average * 100).ToString("F") +
                               " %\n" + strCongratulations);



            string userid = LogInForm.id_s;


            MySqlCommand cmd = con.CreateCommand();
            MySqlCommand cmd2 = con.CreateCommand();
            string username = LogInForm.username_s;

            con.Open();
            s = "Select * From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where u.username='" + username + "';";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();



           
                cmd.CommandText = "Insert into revtests (userid,testid,grade) values ('" + userid + "',2,'" + average * 100 + "')";

            con.Close();




            if (count2 > (numofch2 / 2))
            {
                con.Open();
                cmd2.CommandText = "UPDATE results SET chap2weak='check' where userid='" + userid + "'; ";
                cmd2.ExecuteNonQuery();
                con.Close();

            }
            else if (count1 <= (numofch1 / 2))
            {

                con.Open();
                cmd2.CommandText = "UPDATE results SET chap2weak=null where userid='" + userid + "'; ";
                cmd2.ExecuteNonQuery();
                con.Close();

            }





            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd2.ExecuteNonQuery();

                if (res == DialogResult.OK)
                {

                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTestMenu));
                    this.Close();
                    t.Start();

                }

                toolStripStatusLabel.Text = "Record Insert Succefully";

            }
            catch (Exception)
            {
                toolStripStatusLabel.Text = "Query execution error";
            }


        }



        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            CurrentNumberOfQuestions++;
            CheckAnswer(CurrentQuestion);

            CurrentQuestion = (int)(lstNumbers[QuestionCounter++]);

            if (CurrentQuestion == 0)
            {
                //lblQuestion.Visible = false;
                Question.Visible = false;

                MessageBox.Show("No question yet!");
            }
            else
            {
                PresentQuestion(CurrentQuestion);
            }
        }


        private void QuestionAnswer_Load(object sender, EventArgs e)
        {
            string username = LogInForm.username_s;

          



                QuestionCounter = 0;
                CurrentNumberOfQuestions = 0;

                lstNumbers = new System.Collections.ArrayList();
                Random rndNumber = new Random();

                int number = rndNumber.Next(1, 7);
                lstNumbers.Add(number);
                int count = 0;

                do
                {
                    number = rndNumber.Next(1, 7);

                    if (!lstNumbers.Contains(number))
                    {
                        lstNumbers.Add(number);
                    }

                    count++;
                } while (count <= 100);

                btnCheckAnswer_Click(sender, e);
                con.Close();

            



        }






    }
}




