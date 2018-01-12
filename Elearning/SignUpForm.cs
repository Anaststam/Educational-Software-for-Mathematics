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
    public partial class SignUpForm : Form
    {
        MySqlConnection con = new MySqlConnection("host=127.0.0.1; user=root; password=123456; database=elearningdb");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        public static void OpenForm()
        {
            Application.Run(new LogInForm());
        }


        private void submitBut_Click(object sender, EventArgs e)
        {


            if (name.Text != "" && surname.Text != "" && telnumber.Text != "" && username.Text != "" && password.Text != "" && type.Text!="")
            {

               
                Boolean accepted = false;

                try
                {
                    con.Open();
                    s = "Select * From elearningdb.users Where username='" + username.Text + "';";
                    mcd = new MySqlCommand(s, con);
                    mdr = mcd.ExecuteReader();
                    
                    if (mdr.Read())
                    {

                        MessageBox.Show("Αυτό το όνομα χρήστη υπάρχει ήδη.","ΕRROR");
                        accepted = false;
                    }
                    else
                    {
                        //name_s = mdr.GetString("name");
                        //surname_s= mdr.GetString("surname");
                        //telnumber_s= mdr.GetString("telnumber");
                        //username_s= mdr.GetString("username");
                        //password_s= mdr.GetString("password");
                        //type_s = mdr.GetString("type");
                        if (passwordver.Text == password.Text)
                        {

                            accepted = true;
                        }
                        else
                            MessageBox.Show("Οι κωδικοί που πληκτρολογήσατε είναι διαφορετικοί", "ERROR");
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    toolStripStatusLabel.Text = "Data Readng Error";
                }



                if (accepted == true)
                {
                    try
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        if (type.SelectedItem == "Μαθητής")
                        {
                            cmd.CommandText = "Insert into users (name,surname,telnumber,username,password,type,namesurname) values ('" + name.Text + "','" + surname.Text + "','" + telnumber.Text + "','" + username.Text + "','" + password.Text + "',1,'" + name.Text + " " + surname.Text + "')";
                        }
                        else if (type.SelectedItem == "Καθηγητής")
                        {
                            cmd.CommandText = "Insert into users (name,surname,telnumber,username,password,type,namesurname) values ('" + name.Text + "','" + surname.Text + "','" + telnumber.Text + "','" + username.Text + "','" + password.Text + "',2,'" + name.Text + " " + surname.Text + "')";
                        }


                        try
                        {

                            cmd.ExecuteNonQuery();

                            var msgd= MessageBox.Show("Η εγγραφή σας ολοκληρώθηκε με επιτυχία!! Κάντε είσοδο στο σύστημα ", "Επιτυχής Εγγραφή");

                            if (msgd == DialogResult.OK) {
        
                                 System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
                                 this.Close();
                                 t.Start();

                            }

                            toolStripStatusLabel.Text = "Record Insert Succefully";

                        }
                        catch (Exception)
                        {
                            toolStripStatusLabel.Text = "Query execution error";
                        }

                        con.Close();

                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel.Text = "Connection error";
                    }

                    

                }

            }
            else
            {
                    MessageBox.Show("Πρέπει να συμπληρώσετε όλα τα πεδία ");


           }
            
         }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsLetter(e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void telnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar)) && (!char.IsDigit(e.KeyChar)))
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar))&& (!char.IsLetterOrDigit(e.KeyChar)))
                
                e.Handled = true;
            base.OnKeyPress(e);
        }

        private void back_click(object sender, EventArgs e)
        {
        
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenForm));
            this.Close();
            t.Start();

        
    }

        private void info_panel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Συμπλήρωσε το όνομα σου,το επίθετο σου,το τηλέφωνο σου,το ψευδώνυμο σου στο πεδίο 'username',ένα κωδικό πρόσβασης όπου πρέπει να τον επιβεβαιώσεις στο αμέσως επόμενο πεδίο και τέλος την κατηγορία χρήστη στην οποία ανήκεις.Καλωσήρθες!", "Βοηθεια");
        }
    }
       
    }

