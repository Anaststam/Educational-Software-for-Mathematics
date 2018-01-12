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
    public partial class Test1 : Form
    {
        public Test1()
        {
            InitializeComponent();

        }


        string[,] questions = new string[4, 9];

        int count1 = 0;
        int count2 = 0;
        public double counte = 0;
        public double countm = 0;
        public double countd = 0;
        string userid = LogInForm.id_s;


        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;





        public static void OpenTestMenu()
        {
            Application.Run(new TestMenu());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (metrhths == questions.GetLength(0))
            {


                RightAnswer = questions[metrhths - 1, 7];

                if ((RightAnswer == "1") && (Answer1.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "1") && (Answer1.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }

                if ((RightAnswer == "2") && (Answer2.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "2") && (Answer2.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }

                if ((RightAnswer == "3") && (Answer3.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "3") && (Answer3.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }
            }

            double average = 1.0;

            average = countRightAnswers / 4;
            string strCongratulations = "";



            // if (average >= 0.5)
            //   strCongratulations = "\nΣυγχαρητήρια πέρασες!"; tha mporousame na allaksoume to mhnuma

            DialogResult res = MessageBox.Show("Συνολικές Ερωτήσεις : " +
                               4 +
                               "\nΣωστές Ερωτήσεις : " +
                               countRightAnswers.ToString() +
                               "\nΠοσοστό επιτυχίας :                   " +
                               (average * 100).ToString("F") +
                               " %\n" + strCongratulations);





            System.Console.WriteLine(counte);
            System.Console.WriteLine(countm);
            System.Console.WriteLine(countd);

            double sume;//starts calculate the weakness
            double summ;
            double sumd;



            string weakness = "n";
            sume = counte * 3;
            summ = countm * 2;
            sumd = countd * 1.6;

            double max = sume;

            if (max < summ) max = summ;
            if (max < sumd) max = sumd;

            if (max == sume) weakness = "e";
            if (max == summ) weakness = "m";
            if (max == sumd) weakness = "d";



            System.Console.WriteLine("------------------");

            System.Console.WriteLine(sume);
            System.Console.WriteLine(summ);
            System.Console.WriteLine(sumd);
            System.Console.WriteLine(max);
            System.Console.WriteLine("------------------");

            if (sume == 0 && summ == 0 && sumd == 0)
            {
                weakness = "n";
            }

            con.Open();
            string s2;
            s2 = "select userid,chap1weak from elearningdb.results where userid='" + userid + "' ";
            mcd = new MySqlCommand(s2, con);
            mdr = mcd.ExecuteReader();



            if (mdr.Read())
            {
                con.Close();
                con.Open();
                MySqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandText = "Update results set chap1weak='" + weakness + "' where userid='" + userid + "' ;";
                cmd6.ExecuteNonQuery();
                con.Close();

            }
            else
            {
                con.Close();
                con.Open();
                MySqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandText = "INSERT INTO results (userid,chap1weak) VALUES ('" + userid + "','" + weakness + "')  ";
                cmd3.ExecuteNonQuery();
                con.Close();
            }






            MySqlCommand cmd2 = con.CreateCommand();


            string username = LogInForm.username_s;

            con.Open();

            string s1;
            double test1grade = 0.0;

            s1 = "select test1 from elearningdb.results where userid='" + userid + "' AND test1>=0 ;";
            mcd = new MySqlCommand(s1, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string y = mdr.GetString("test1");


                Double.TryParse(y, out test1grade);


            }


            con.Close();

            //con.Open();

            //MySqlCommand cmd = con.CreateCommand();


            //cmd.CommandText = "INSERT INTO results (test1) VALUES ('" + telikosvathmos + "')";
            //cmd.ExecuteNonQuery();
            //con.Close();



            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            s = "Select * From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where u.username='" + username + "' AND test1>=0;";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                cmd.CommandText = "UPDATE results SET test1='" + (test1grade + (average * 100)) / 2 + "' where userid='" + userid + "'; ";
                Console.WriteLine(" είμαι εδώ 1! " + (test1grade + (average * 100)));

            }
            else
            {
                cmd.CommandText = "Update results SET test1 = '" + (average * 100) + "'where userid='" + userid + "';";
                Console.WriteLine(" είμαι εδώ 2!" + userid + "  bathmos:" + (average * 100));
            }
            con.Close();
            System.Collections.ArrayList counter = new System.Collections.ArrayList();
            counter.Add(count1);
            counter.Add(count2);









            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();



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


        int metrhths = 1;
        double countRightAnswers = 0;
        string RightAnswer;

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {



            //System.Console.WriteLine(questions.GetLength(0));
            if (metrhths < questions.GetLength(0))
            {


                Question.Text = questions[metrhths, 1];
                Answer1.Text = questions[metrhths, 4];
                Answer2.Text = questions[metrhths, 5];
                Answer3.Text = questions[metrhths, 6];
                RightAnswer = questions[metrhths - 1, 7];
                System.Console.WriteLine(RightAnswer + " metrhths " + metrhths + " Answer1.Checked " + Answer1.Checked + " Answer2.Checked " + Answer2.Checked + " Answer3.Checked " + Answer3.Checked);

                if ((RightAnswer == "1") && (Answer1.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "1") && (Answer1.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }


                if ((RightAnswer == "2") && (Answer2.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "2") && (Answer2.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }


                if ((RightAnswer == "3") && (Answer3.Checked == true))
                {

                    MessageBox.Show("Σωστο");
                    countRightAnswers++;

                }
                else if ((RightAnswer == "3") && (Answer3.Checked == false))
                {
                    MessageBox.Show("Λάθος");
                    if (questions[metrhths - 1, 3] == "e")
                    {
                        counte = counte + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "m")
                    {
                        countm = countm + 1;
                    }
                    else if (questions[metrhths - 1, 3] == "d")
                    {
                        countd = countd + 1;
                    }
                }


                if (metrhths + 1 == questions.GetLength(0))
                {
                    Next.Visible = false;
                    button1.Visible = true;

                }

                metrhths++;
            }


            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;

        }


        string s4;
        string weakness1;

        private void FindQuestion(object sender, EventArgs e)
        {




            con.Open();
            s4 = "Select chap1weak from results where userid='" + userid + "' and chap1weak!='nullif()'";

            mcd = new MySqlCommand(s4, con);
            mdr = mcd.ExecuteReader();


            if (mdr.Read())
            {
                weakness1 = mdr.GetString("chap1weak");
                if (weakness1 == "n")
                {
                    con.Close();
                    con.Open();
                    s = "select * from elearningdb.questions where kefalaio=1 order by rand() limit 4;";
                    mcd = new MySqlCommand(s, con);
                    mdr = mcd.ExecuteReader();
                }
                else
                {
                    con.Close();
                    con.Open();
                    s = "select * from elearningdb.questions where kefalaio=1 and difficulty='" + weakness1 + "' order by rand() limit 4;";
                    mcd = new MySqlCommand(s, con);
                    mdr = mcd.ExecuteReader();
                }
            }
            else
            {
                con.Close();
                con.Open();
                s = "select * from elearningdb.questions where kefalaio=1 order by rand() limit 4;";
                mcd = new MySqlCommand(s, con);
                mdr = mcd.ExecuteReader();
            }





            int i = 0;

            while (mdr.Read())
            {

                questions[i, 0] = mdr.GetString("idquestions");
                questions[i, 1] = mdr.GetString("question");
                questions[i, 2] = mdr.GetString("kefalaio");
                questions[i, 3] = mdr.GetString("difficulty");
                questions[i, 4] = mdr.GetString("panswer1");
                questions[i, 5] = mdr.GetString("panswer2");
                questions[i, 6] = mdr.GetString("panswer3");
                questions[i, 7] = mdr.GetString("RightAnswer");
                questions[i, 8] = mdr.GetString("TeacherID");
                i++;

            }

            System.Console.WriteLine(questions[0, 3]);
            System.Console.WriteLine(questions[1, 3]);
            System.Console.WriteLine(questions[2, 3]);
            System.Console.WriteLine(questions[3, 3]);


            Question.Text = questions[0, 1];
            Answer1.Text = questions[0, 4];
            Answer2.Text = questions[0, 5];
            Answer3.Text = questions[0, 6];



            con.Close();


        }
    }
}


