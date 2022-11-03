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
    public partial class ErgebnisseAnzeigen : Form
    {
        DataTable dt_faecher;
        DataTable dt_Kandidat;
        SqlConnection con = new SqlConnection(@"Data Source = HAUPT-PC; Initial Catalog = QuizDb; Integrated Security = True");
        public ErgebnisseAnzeigen()
        {
            InitializeComponent();
            GetFaecher();
            GetKandidat();
            ergebnisseAnzeigen();
        }
        private void GetFaecher()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select fachId, fachName From FachTbl ", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt_faecher = new DataTable();
                dt_faecher.Columns.Add("fachId", typeof(int));
                dt_faecher.Columns.Add("fachName", typeof(string));
                dt_faecher.Load(reader);
                cbo_Fach.ValueMember = "fachName";
                con.Close();
                cbo_Fach.DataSource = dt_faecher;
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
        private void GetKandidat()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select kandidatId, kandidatVorname, kandidatNachname From KandidatTbl ", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dt_Kandidat = new DataTable();
                dt_Kandidat.Columns.Add("kandidatId", typeof(int));
                dt_Kandidat.Columns.Add("kandidatVorname", typeof(string));
                dt_Kandidat.Load(reader);
                cbo_Kandidat.ValueMember = "kandidatVorname";
                con.Close();
                cbo_Kandidat.DataSource = dt_Kandidat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Fragen anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close(); //Ausloggen
            }
        }
        private void ergebnisseAnzeigen()
        {
            try
            {
                con.Open();
                string selectaalleFromErgebnisTbl = "SELECT ErgebnisTbl.ErgebnisId ,KandidatTbl.kandidatVorname, KandidatTbl.kandidatNachname," +
                                                    " FachTbl.fachName, ErgebnisDatum,ErgebnisZeit, ErgebnisTbl.ErgebnisNoten As 'Note', ErgebnisHinweise As Hinweise " +
                                                    " FROM ErgebnisTbl " +
                                                    " Inner Join KandidatTbl On (KandidatTbl.kandidatId = ErgebnisTbl.kandidatId)" +
                                                    " Inner Join FachTbl On (FachTbl.fachId = ErgebnisTbl.FachId)";
                SqlDataAdapter sda = new SqlDataAdapter(selectaalleFromErgebnisTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Ergebnisse.DataSource = ds.Tables[0];

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
        private void FilterByFach()
        {
            try
            {
                con.Open();
                string selectaalleFromErgebnisTbl;
                if (cbo_Kandidat.SelectedIndex > 0)
                {
                    selectaalleFromErgebnisTbl = "SELECT ErgebnisTbl.ErgebnisId ,KandidatTbl.kandidatVorname, KandidatTbl.kandidatNachname," +
                                                   " FachTbl.fachName, ErgebnisDatum,ErgebnisZeit, ErgebnisTbl.ErgebnisNoten As 'Note', ErgebnisHinweise As Hinweise " +
                                                   " FROM ErgebnisTbl " +
                                                   " Inner Join KandidatTbl On (KandidatTbl.kandidatId = ErgebnisTbl.kandidatId)" +
                                                   " Inner Join FachTbl On (FachTbl.fachId = ErgebnisTbl.FachId)" +
                                                   " Where ErgebnisTbl.FachId = " + dt_faecher.Rows[cbo_Fach.SelectedIndex][0] +
                                                   " and KandidatTbl.KandidatId = " + dt_Kandidat.Rows[cbo_Kandidat.SelectedIndex][0]; 
                }
                else
                {
                    selectaalleFromErgebnisTbl = "SELECT ErgebnisTbl.ErgebnisId ,KandidatTbl.kandidatVorname, KandidatTbl.kandidatNachname," +
                                                   " FachTbl.fachName, ErgebnisDatum,ErgebnisZeit, ErgebnisTbl.ErgebnisNoten As 'Note', ErgebnisHinweise As Hinweise " +
                                                   " FROM ErgebnisTbl " +
                                                   " Inner Join KandidatTbl On (KandidatTbl.kandidatId = ErgebnisTbl.kandidatId)" +
                                                   " Inner Join FachTbl On (FachTbl.fachId = ErgebnisTbl.FachId)" +
                                                   " Where ErgebnisTbl.FachId = " + dt_faecher.Rows[cbo_Fach.SelectedIndex][0];
                }
                
                SqlDataAdapter sda = new SqlDataAdapter(selectaalleFromErgebnisTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Ergebnisse.DataSource = ds.Tables[0];
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
        private void FilterByKandidat()
        {
            try
            {
                con.Open();
                string selectaalleFromErgebnisTbl_with_Kanditat_Condition = "SELECT ErgebnisTbl.ErgebnisId ,KandidatTbl.kandidatVorname, KandidatTbl.kandidatNachname," +
                                                    " FachTbl.fachName, ErgebnisDatum,ErgebnisZeit, ErgebnisTbl.ErgebnisNoten As 'Note', ErgebnisHinweise As Hinweise " +
                                                    " FROM ErgebnisTbl " +
                                                    " Inner Join KandidatTbl On (KandidatTbl.kandidatId = ErgebnisTbl.kandidatId)" +
                                                    " Inner Join FachTbl On (FachTbl.fachId = ErgebnisTbl.FachId)" +
                                                    " Where KandidatTbl.KandidatId = " + dt_Kandidat.Rows[cbo_Kandidat.SelectedIndex][0] +
                                                    " And ErgebnisTbl.FachId = " + dt_faecher.Rows[cbo_Fach.SelectedIndex][0];
                SqlDataAdapter sda = new SqlDataAdapter(selectaalleFromErgebnisTbl_with_Kanditat_Condition, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Ergebnisse.DataSource = ds.Tables[0];
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbo_Fach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByFach();
        }

        private void cbo_Kandidat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByKandidat();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Einloggen ein = new Einloggen();
            ein.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kandidaten ein = new Kandidaten();
            ein.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Fragen ein = new Fragen();
            ein.Show();
            this.Hide();
        }

        private void pictureBox_Faecher_Click(object sender, EventArgs e)
        {
            Faecher ein = new Faecher();
            ein.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            About ein = new About();
            ein.ShowDialog();
            //this.Hide();
            //this.Hide();
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

        private void lbl_Kandidaten_Click(object sender, EventArgs e)
        {
            Kandidaten kandi = new Kandidaten();
            kandi.Show();
            this.Hide();
        }

        private void lbl_QuizPro_DoubleClick(object sender, EventArgs e)
        {
            Pruefung pruefung = new Pruefung();
            pruefung.Show();
            this.Close();
        }

        private void cbo_Fach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Kandidat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
