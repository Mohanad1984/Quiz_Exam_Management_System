//using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Quiz_Exam_Management_System
{
    public partial class Einloggen : Form
    {
        public Einloggen()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = HAUPT-PC; Initial Catalog = QuizDb; Integrated Security = True");
        public static DataTable dataTable_kandidat;
        public static string KandidatbenutzerName= "";
        private void btn_Einloggen_Click(object sender, EventArgs e)
        {
            //User user = new User();
            //user.Id = 10;

            if (txt_Benutzername.Text == "" || txt_Passwort.Text == "")
            {
                MessageBox.Show("Du Bist Dumm!");
            }
            else
            {
                try
                {
                    con.Open();
                    string s = "Select kandidatId, kandidatVorname, kandidatNachname From KandidatTbl Where kandidatBenutzername= '" +
                        txt_Benutzername.Text + "' and kandidatPasswort = '" + txt_Passwort.Text + "' ;";
                    SqlDataAdapter sda = new SqlDataAdapter(s ,con);
                    dataTable_kandidat = new DataTable();
                    sda.Fill(dataTable_kandidat);
                   // if(dataTable_kandidat.Rows[0][0].ToString() == "1")
                    if(dataTable_kandidat.Rows.Count > 0)
                    {
                        KandidatbenutzerName = txt_Benutzername.Text;
                        Pruefung pruefung = new Pruefung();
                        pruefung.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("falsche Benutzer Name oder Passwort!");
                    }
                    con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void vorbereitung()
        {
           
        }
        private void btn_Admin_Click(object sender, EventArgs e)
        {
            lbl_Benutzername.Visible = false;
            txt_Benutzername.Visible = false;
            if (txt_Passwort.Text == "")
            {
                MessageBox.Show("Bitte geben Sie die Passwort ein");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From AdmiTbl Where AdmiPasswort = '" +
                   // SqlDataAdapter sda = new SqlDataAdapter("Select kandidatId, kandidatVorname, kandidatNachname From AdmiTbl Where AdmiPasswort = '" +
                        txt_Passwort.Text +"' ;", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        KandidatbenutzerName = txt_Benutzername.Text;
                        Fragen fragen = new Fragen();
                        fragen.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("falsche Benutzer Name oder Passwort!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
