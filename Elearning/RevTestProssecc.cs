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

        public partial class  RevTestProssecc : Form
        {
            MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
            MySqlCommand command, command2,mcd;
            MySqlDataAdapter adapter;
            MySqlDataReader mdr;
            DataTable table;

            public RevTestProssecc()
            {
                InitializeComponent();
            }

            public static void OpenForm()
            {
                Application.Run(new TeacherPage());
            }

            private void back_click(object sender, EventArgs e)
            {

                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
                this.Close();
                t.Start();


            }

            private void StudentProccess_Load(object sender, EventArgs e)
            {
                string query = "Select * From elearningdb.users where type=1;";
                fillCombo(Students_list, query, "namesurname", "userid");


            }

        public static void OpenTeacher()
        {
            Application.Run(new TeacherPage());
        }

        private void back_pnl_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenTeacher));
            this.Close();
            t.Start();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Από την διαθέσιμη λίστα με τους μαθητές που παρουσιάζεται στο αριστερό μέρος της φόρμας μπορείται να διαλέξετε τον μαθητή που θέλετε να δείτε την πρόοδό του στα επαναληπτικά διαγωνίσματα στα οποία παρουσιάζει αδυναμία.Τα αποτελέσματα θα παρουσιαστούν σε μορφή διαγράμματος στην μέση της φόρμας.Επίσης δίνεται η δυνατότητα να δείτε τα αδύναμα κεφάλαια του μαθητή στα οποία εξακολουθεί να αντιμετωπίζει δυσκολία. ", "Βοηθεια");
        }

        public void fillCombo(ComboBox combo, string query, string displayMember, string valueMember)
            {

                command = new MySqlCommand(query, con);
                adapter = new MySqlDataAdapter(command);
                table = new DataTable();
                adapter.Fill(table);
                combo.DataSource = table;
                combo.DisplayMember = displayMember;
                combo.ValueMember = valueMember;



            }

        private void Students_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            double test1, test2, test3;
            string s;

            int val = 18;
            Int32.TryParse(Students_list.SelectedValue.ToString(), out val);

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
           
            if (val != 0)
            {
                con.Open();
                string query2 = "Select * From (Select sum(grade)/count(testid) as average from revtests as rvt inner join users as u on rvt.userid = u.userid where rvt.testid = 1 AND rvt.userid =" + val + " ) as av where average>=0;";
                command2 = new MySqlCommand(query2, con);

                mdr = command2.ExecuteReader();




                if (mdr.Read())
                {



                    test1 = mdr.GetDouble("average");
                    this.chart1.Series["Grades"].Points.AddXY("test1", test1);
                }

                con.Close();


                con.Open();
                query2 = "Select * From (Select sum(grade)/count(testid) as average from revtests as rvt inner join users as u on rvt.userid = u.userid where rvt.testid = 2 AND rvt.userid =" + val + " ) as av where average>=0;";
                command2 = new MySqlCommand(query2, con);

                mdr = command2.ExecuteReader();

                if (mdr.Read() )
                {



                    test2 = mdr.GetDouble("average");
                    this.chart1.Series["Grades"].Points.AddXY("test2", test2);
                }

                con.Close();




                con.Open();
                query2 = "Select * From (Select sum(grade)/count(testid) as average from revtests as rvt inner join users as u on rvt.userid = u.userid where rvt.testid = 3 AND rvt.userid =" + val + " ) as av where average>=0;";
                command2 = new MySqlCommand(query2, con);

                mdr = command2.ExecuteReader();

                if (mdr.Read())
                {



                    test3 = mdr.GetDouble("average");
                    this.chart1.Series["Grades"].Points.AddXY("test3", test3);
                }
                mdr.Close();

                one_box.Text = "";
                two_box.Text = "";
                three_box.Text = "";

                s = "Select rs.chap1weak  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND( chap1weak = 'check');";
                mcd = new MySqlCommand(s, con);
                mdr = mcd.ExecuteReader();

                if (mdr.Read())
                {
                    string weak1 = mdr.GetString("chap1weak");
                    if (weak1 == "check")
                    {

                        one_box.Text = "1";

                    }
                }
                mdr.Close();

                s = "Select  rs.chap2weak  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND( chap2weak = 'check');";
                mcd = new MySqlCommand(s, con);
                mdr = mcd.ExecuteReader();

                if (mdr.Read())
                {
                    string weak2 = mdr.GetString("chap2weak");
                    if (weak2 == "check")
                    {
                        two_box.Text = "2";

                    }
                }
                mdr.Close();

                s = "Select  rs.chap3weak  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND( chap3weak = 'check');";
                mcd = new MySqlCommand(s, con);
                mdr = mcd.ExecuteReader();



                if (mdr.Read())
                {

                    string weak3 = mdr.GetString("chap3weak");
                    if (weak3 == "check")
                    {
                        three_box.Text = "3";

                    }



                }
                mdr.Close();
                con.Close();

            }

        }




        }
    }


