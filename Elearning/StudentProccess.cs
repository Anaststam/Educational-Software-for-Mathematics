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
    public partial class StudentProccess : Form
    {
        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand command, command2,mcd;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;
        DataTable table;
        string username = LogInForm.username_s;

        public StudentProccess()
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

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Από την διαθέσιμη λίστα με τους μαθητές που παρουσιάζεται στο αριστερό μέρος της φόρμας μπορείται να διαλέξετε τον μαθητή που θέλετε να δείτε την πρόοδό του.Τα αποτελέσματα θα παρουσιαστούν σε μορφή διαγράμματος στην μέση της φόρμας.Επίσης δίνεται η δυνατότητα να δείτε τις αδυναμίες του μαθητή.", "Βοηθεια");
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
            string test1, test2, final,test3, s;
            
            int val = 28;
            Int32.TryParse(Students_list.SelectedValue.ToString(), out val);

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            this.one_box.Text = null;

            con.Open();
            string query2 = "Select test1 From elearningdb.results WHERE userid='" + val + "' AND test1>='0' ;";
            command2 = new MySqlCommand(query2, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test1 = mdr.GetString("test1");
                double t1;
                Double.TryParse(test1, out t1);
                this.chart1.Series["Grades"].Points.AddXY("test1", t1);
            }

            con.Close();


            con.Open();
            query2 = "Select test2 From elearningdb.results WHERE userid='" + val + "' AND test2>='0' ;";
            command2 = new MySqlCommand(query2, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test2 = mdr.GetString("test2");
                double t2;
                Double.TryParse(test2, out t2);
                this.chart1.Series["Grades"].Points.AddXY("test2", t2);
            }

            con.Close();




            con.Open();
            query2 = "Select test3 From elearningdb.results WHERE userid='" + val + "' AND test3>='0' ;";
            command2 = new MySqlCommand(query2, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {



                test3 = mdr.GetString("test3");
                double t3;
                Double.TryParse(test3, out t3);
                this.chart1.Series["Grades"].Points.AddXY("test3", t3);
            }

            con.Close();



            con.Open();
            query2 = "Select final From elearningdb.results WHERE userid='" + val + "' AND final>='0';";
            command2 = new MySqlCommand(query2, con);

            mdr = command2.ExecuteReader();

            if (mdr.Read())
            {




                final = mdr.GetString("final");
                double fin;
                 Double.TryParse(final, out fin);
                this.chart1.Series["Grades"].Points.AddXY("final", fin);
                
            }

            mdr.Close();
            one_box.Text = "";
            two_box.Text = "";
            three_box.Text = "";

            textBox3.Visible = false;

            s = "Select rs.weakness  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND ( weakness >0);";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string weak1 = mdr.GetString("weakness");
                if (weak1 == "1")
                {
                    textBox3.Visible = true;
                    one_box.Text = "1";
                    
                }
            }
            mdr.Close();

            s = "Select  rs.weakness  From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND( weakness >0);";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string weak2 = mdr.GetString("weakness");
                if (weak2 == "2")
                {
                    textBox3.Visible = true;
                    two_box.Text = "2";

                }
            }
            mdr.Close();

            s = "Select  rs.weakness From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND( weakness >0);";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();



            if (mdr.Read())
            {

                string weak3 = mdr.GetString("weakness");
                if (weak3 == "3")
                {
                    textBox3.Visible = true;
                    three_box.Text = "3";

                }



            }
            mdr.Close();

            //Αδυναμίες σε κεφάλαια 
            chap1_txtbox.Visible = false;
            dif_weak1.Visible = false;
            chap2_txtbox.Visible = false;
            dif_weak2.Visible = false;
            chap3_txtbox.Visible = false;
            dif_weak3.Visible = false;

            s = "Select rs.chap1weak From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND ( chap1weak !='nullif()');";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string weak1 = mdr.GetString("chap1weak");
                if (weak1 == "e")
                {
                    chap1_txtbox.Visible = true;
                    dif_weak1.Visible = true;
                    dif_weak1.Text = "Εύκολες Ερωτήσεις";
                   

                }
                else if (weak1 == "m")
                {
                    chap1_txtbox.Visible = true;
                    dif_weak1.Visible = true;
                    dif_weak1.Text = "Μεσαίες Ερωτήσεις";


                }
                else if (weak1 == "d")
                {
                    chap1_txtbox.Visible = true;
                    dif_weak1.Visible = true;
                    dif_weak1.Text = "Δύσκολες Ερωτήσεις";


                }
                else if (weak1 == "n")
                {
                    chap1_txtbox.Visible = true;
                    dif_weak1.Visible = true;
                    dif_weak1.Text = "Δεν έχει αδυναμία ";


                }
            }
            mdr.Close();

            s = "Select rs.chap2weak From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND ( chap2weak !='nullif()');";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string weak2 = mdr.GetString("chap2weak");
                if (weak2 == "e")
                {
                    chap2_txtbox.Visible = true;
                    dif_weak2.Visible = true;
                    dif_weak2.Text = "Εύκολες Ερωτήσεις";


                }
                else if (weak2 == "m")
                {
                    chap2_txtbox.Visible = true;
                    dif_weak2.Visible = true;
                    dif_weak2.Text = "Μεσαίες Ερωτήσεις";


                }
                else if (weak2 == "d")
                {
                    chap2_txtbox.Visible = true;
                    dif_weak2.Visible = true;
                    dif_weak2.Text = "Δύσκολες Ερωτήσεις";


                }
                else if (weak2 == "n")
                {
                    chap2_txtbox.Visible = true;
                    dif_weak2.Visible = true;
                    dif_weak2.Text = "Δεν έχει αδυναμία ";


                }
            }
            mdr.Close();





            s = "Select rs.chap3weak From elearningdb.results as rs Inner Join users as u on rs.userid=u.userid Where rs.userid= '" + val + "' AND ( chap3weak !='nullif()');";
            mcd = new MySqlCommand(s, con);
            mdr = mcd.ExecuteReader();

            if (mdr.Read())
            {
                string weak3 = mdr.GetString("chap3weak");
                if (weak3 == "e")
                {
                    chap3_txtbox.Visible = true;
                    dif_weak3.Visible = true;
                    dif_weak3.Text = "Εύκολες Ερωτήσεις";


                }
                else if (weak3 == "m")
                {
                    chap3_txtbox.Visible = true;
                    dif_weak3.Visible = true;
                    dif_weak3.Text = "Μεσαίες Ερωτήσεις";


                }
                else if (weak3 == "d")
                {
                    chap3_txtbox.Visible = true;
                    dif_weak3.Visible = true;
                    dif_weak3.Text = "Δύσκολες Ερωτήσεις";


                }
                else if (weak3 == "n")
                {
                    chap3_txtbox.Visible = true;
                    dif_weak3.Visible = true;
                    dif_weak3.Text = "Δεν έχει αδυναμία ";


                }
            }
            mdr.Close();







            con.Close();


        }




    

            }
    }

