using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz_Exam_Management_System
{
    
    public partial class Kandidaten : Form
    {
        public Kandidaten()
        {
            InitializeComponent();
            KandidatenAnzeigen();
            GetFaecher();

        }
        /*
         yea type prop and press TAB. Visual Studio has a snippet for automatic property.

        For property with public get and private set, you can use propg and press TAB.

        For complete non auto property you can use propfull and press TAB.
        */
        DataTable dt;
        int key = 0;
        SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = QuizDb; Integrated Security = True");
        private void panel_Haupt_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Reset()
        {
            txt_Vorname.Text = "";
            txt_Nachname.Text = "";
            txt_Benutzername.Text = "";
            txt_Passwort.Text = "";
            txt_Strasse.Text = "";
            txt_HausNr.Text = "";
            txt_Ort.Text = "";
            txt_Plz.Text = "";
            txt_Telefon.Text = "";
            dateTimePicker_Geburtsdatum.Value = System.DateTime.Today;
            txt_Hinweise.Text = "";
        }
        private void KandidatenAnzeigen()
        {
            try
            {
                con.Open();
                string SelectIntoKandidatTbl = "Select * From KandidatTbl";
                SqlDataAdapter sda = new SqlDataAdapter(SelectIntoKandidatTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Kandidatenliste.DataSource = ds.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Kandidaten anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetFaecher()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select fachId, fachName From FachTbl ", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Columns.Add("fachId", typeof(int));
                dt.Columns.Add("fachName", typeof(string));
                dt.Load(reader);
                cbo_Fach.ValueMember = "fachName";
                cbo_Fach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Fragen anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                con.Close();
            }
        }
        private void btn_Speicher_Click(object sender, EventArgs e)
        {
            if(txt_Benutzername.Text == "" || txt_Vorname.Text == "" || txt_Nachname.Text == "" || txt_Strasse.Text == "" || 
                txt_HausNr.Text == "" || txt_Ort.Text == "" || txt_Plz.Text == "" || txt_Telefon.Text == "" )
            {
                MessageBox.Show("info", "info fehlt",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string InsertIntoKandidatTbl =  "Insert Into KandidatTbl (kandidatVorname, kandidatNachname, kandidatBenutzername, kandidatPasswort, kandidatTelefonnummer," +
                                                    " kandidatStrasse, kandidatHausNr, kandidatPlz, kandidatOrt, kandidatHinweise, kandidatGeburtsdatum )" +
                                                    " Values" +
                                                    " (@kVorname, @kNachname, @kBenutzername, @kPasswort, @kTel," +
                                                    "  @kStrasse, @kHausNr, @kPlz, @kOrt, @kHinweise, @kGeburtsdatum)";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(InsertIntoKandidatTbl, con);
                    cmd.Parameters.AddWithValue("@kVorname",txt_Vorname.Text);
                    cmd.Parameters.AddWithValue("@kNachname", txt_Nachname.Text);
                    cmd.Parameters.AddWithValue("@kBenutzername", txt_Benutzername.Text);
                    cmd.Parameters.AddWithValue("@kPasswort", txt_Passwort.Text);
                    cmd.Parameters.AddWithValue("@kTel", txt_Telefon.Text);
                    cmd.Parameters.AddWithValue("@kStrasse", txt_Strasse.Text);
                    cmd.Parameters.AddWithValue("@kHausNr", txt_HausNr.Text);
                    cmd.Parameters.AddWithValue("@kPlz", txt_Plz.Text);
                    cmd.Parameters.AddWithValue("@kOrt", txt_Ort.Text);
                    cmd.Parameters.AddWithValue("@kHinweise", txt_Hinweise.Text);
                    cmd.Parameters.AddWithValue("@kGeburtsdatum", dateTimePicker_Geburtsdatum.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kandidat ist gespeichert!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    con.Close();
                    KandidatenAnzeigen();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                
            }
        }

        private void btn_Bearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                string UpdateKandidatTbl = "Update dbo.KandidatTbl Set" +
                                           " kandidatVorname = @kVorname, " +
                                           " kandidatNachname = @kNachname," +
                                           " kandidatBenutzername = @kBenutzername," +
                                           " kandidatPasswort = @kPasswort," +
                                           " kandidatTelefonnummer = @kTel," +
                                           " kandidatStrasse = @kStrasse, " +
                                           " kandidatHausNr = @kHausNr, " +
                                           " kandidatPlz = @kPlz, " +
                                           " kandidatOrt = @kOrt, " +
                                           //" kandidatNote INT NULL, " +
                                           " kandidatHinweise = @kHinweise," +
                                           " kandidatGeburtsdatum = @kGeburtsdatum " +
                                           "Where " +
                                           "kandidatId = @kId";
                if (txt_Benutzername.Text == "" || txt_Vorname.Text == "" || txt_Nachname.Text == "" || txt_Strasse.Text == "" ||
                txt_HausNr.Text == "" || txt_Ort.Text == "" || txt_Plz.Text == "" || txt_Telefon.Text == "")
                {
                    MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(UpdateKandidatTbl, con);
                    cmd.Parameters.AddWithValue("@kId", key);
                    cmd.Parameters.AddWithValue("@kVorname", txt_Vorname.Text);
                    cmd.Parameters.AddWithValue("@kNachname", txt_Nachname.Text);
                    cmd.Parameters.AddWithValue("@kBenutzername", txt_Benutzername.Text);
                    cmd.Parameters.AddWithValue("@kPasswort", txt_Passwort.Text);
                    cmd.Parameters.AddWithValue("@kTel", txt_Telefon.Text);
                    cmd.Parameters.AddWithValue("@kStrasse", txt_Strasse.Text);
                    cmd.Parameters.AddWithValue("@kHausNr", txt_HausNr.Text);
                    cmd.Parameters.AddWithValue("@kPlz", txt_Plz.Text);
                    cmd.Parameters.AddWithValue("@kOrt", txt_Ort.Text);
                    cmd.Parameters.AddWithValue("@kHinweise", txt_Hinweise.Text);
                    cmd.Parameters.AddWithValue("@kGeburtsdatum", dateTimePicker_Geburtsdatum.Value);
                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("info", "Kandidat ist gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    KandidatenAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Rest_Click(object sender, EventArgs e)
        {
            Reset();
        }
       
        private void dgv_Kandidatenliste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Vorname.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[1].Value.ToString();
                txt_Nachname.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[2].Value.ToString();
                txt_Benutzername.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[3].Value.ToString();
                txt_Passwort.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[4].Value.ToString();
                txt_Telefon.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[5].Value.ToString();
                txt_Strasse.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[6].Value.ToString();
                txt_HausNr.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[7].Value.ToString();
                txt_Plz.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[8].Value.ToString();
                txt_Ort.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[9].Value.ToString();
                txt_Hinweise.Text = dgv_Kandidatenliste.SelectedRows[0].Cells[11].Value.ToString();
                dateTimePicker_Geburtsdatum.Value = Convert.ToDateTime(dgv_Kandidatenliste.SelectedRows[0].Cells[12].Value);
                if (txt_Vorname.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(dgv_Kandidatenliste.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei DGV mouse click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }

        }

        private void btn_CreateTables_Click(object sender, EventArgs e)
        {
            try
            {
                string CREATEKandidatTbl = "CREATE TABLE dbo.KandidatTbl " +
                    "(" +
                    " kandidatId int NOT NULL IDENTITY (1, 1)  PRIMARY KEY, " +
                    " kandidatVorname VARCHAR(100) NOT NULL," +
                    " kandidatNachname VARCHAR(100) NOT NULL," +
                    " kandidatBenutzername VARCHAR(100) NOT NULL," +
                    " kandidatPasswort VARCHAR(100) NOT NULL," +
                    " kandidatTelefonnummer VARCHAR(30) NOT NULL," +
                    " kandidatStrasse VARCHAR(100) NOT NULL, " +
                    " kandidatHausNr VARCHAR(10) NOT NULL, " +
                    " kandidatPlz VARCHAR(7) NOT NULL, " +
                    " kandidatOrt VARCHAR(30) NOT NULL, " +
                    " kandidatNote INT NULL, " +
                    " kandidatHinweise VARCHAR(500)   NULL," +
                    " kandidatGeburtsdatum DATE NOT NULL " +
                    ");";



                SqlCommand cmd1 = new SqlCommand(CREATEKandidatTbl, con);
                cmd1.ExecuteNonQuery();
                // MessageBox.Show("info", "Kandidat ist gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void lbl_Faecher_Click(object sender, EventArgs e)
        {
            Faecher fach = new Faecher();
            fach.Show();
            this.Hide();
        }

        private void lbl_Fragen_Click(object sender, EventArgs e)
        {
            Fragen frage = new Fragen();
            frage.Show();
            this.Hide();
        }

        private void lbl_ErgebnisseAnzeigen_Click(object sender, EventArgs e)
        {
            ErgebnisseAnzeigen ergebnisseAnzeigen = new ErgebnisseAnzeigen();
            ergebnisseAnzeigen.Show();
            this.Hide();
        }
    }
}
