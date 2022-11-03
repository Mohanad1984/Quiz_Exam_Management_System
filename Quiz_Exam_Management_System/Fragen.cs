using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz_Exam_Management_System
{

    public partial class Fragen : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = HAUPT-PC; Initial Catalog = QuizDb; Integrated Security = True");
        string import_FileName_Pfad;
        int key = 0;
        int admiId = 1;
        DataTable dt;
        DatenbankConnection datenbankConnection;
        public Fragen()
        {
            InitializeComponent();
            //CreateTablesFragenTbl();
            datenbankConnection = new DatenbankConnection();
            FragenAnzeigen();
            GetFaecher();
        }
        private void Reset()
        {
            txt_Auswahl_1.Text = "";
            txt_Auswahl_2.Text = "";
            txt_Auswahl_3.Text = "";
            txt_Auswahl_4.Text = "";
            txt_Frage.Text = "";
            txt_Anwort.Text = "";
            cbo_Fach.SelectedIndex = -1;
            foreach (Control x in this.grb_Antworten.Controls)
            {
                if (x is RadioButton)
                {
                    if (((RadioButton)x).Checked == true)
                    {
                       ((RadioButton)x).Checked = false;
                    }
                }
            }
        }
        private void FragenAnzeigen()
        {
            try
            {
                con.Open();
                string SelectIntoFrageTbl = "SELECT frageId ,frageBeschreibung, frageWahl_1, frageWahl_2, frageWahl_3, frageWahl_4, frageAntwort, FachTbl.fachName As 'Fach Name' " +
                                            "FROM FachTbl " +
                                            "Join FrageTbl " +
                                            "On (FrageTbl.fachId = FachTbl.fachId)";
                SqlDataAdapter sda = new SqlDataAdapter(SelectIntoFrageTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Fragen.DataSource = ds.Tables[0];
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
        private void lbl_Faecher_Click(object sender, EventArgs e)
        {
            Faecher fach = new Faecher();
            fach.Show();
            this.Hide();
        }

        private void lbl_Kandidaten_Click(object sender, EventArgs e)
        {
            Kandidaten kandi = new Kandidaten();
            kandi.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Speicher_Click(object sender, EventArgs e)
        {
            string antwort = "";
            if (txt_Auswahl_1.Text == "" || txt_Auswahl_2.Text == "" || txt_Auswahl_3.Text == "" || txt_Auswahl_4.Text == "" || txt_Frage.Text == "")
            {
                MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!rdoBtn_Auswahl_1_Richtig.Checked && !rdoBtn_Auswahl_2_Richtig.Checked && !rdoBtn_Auswahl_3_Richtig.Checked && !rdoBtn_Auswahl_4_Richtig.Checked)
            {
                MessageBox.Show("Bitte wählen Sie die richtige Antwort!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                try
                {
                    if (rdoBtn_Auswahl_1_Richtig.Checked)       {antwort = txt_Auswahl_1.Text; }
                    else if (rdoBtn_Auswahl_2_Richtig.Checked) { antwort = txt_Auswahl_2.Text; }
                    else if (rdoBtn_Auswahl_3_Richtig.Checked) { antwort = txt_Auswahl_2.Text; }
                    else if (rdoBtn_Auswahl_4_Richtig.Checked) { antwort = txt_Auswahl_4.Text; } 
                    string InsertIntoKandidatTbl = "Insert Into FrageTbl (frageBeschreibung, frageWahl_1, frageWahl_2, frageWahl_3, frageWahl_4," +
                                                    " frageAntwort, fachId, admiId, EintragungsDatum)" +
                                                    " Values" +
                                                    " (@frageBeschreibung, @frageWahl_1, @frageWahl_2, @frageWahl_3, @frageWahl_4," +
                                                    "  @frageAntwort, @fachId, @admiId, @EintragungsDatum )";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(InsertIntoKandidatTbl, con);
                    cmd.Parameters.AddWithValue("@frageBeschreibung", txt_Frage.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_1", txt_Auswahl_1.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_2", txt_Auswahl_2.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_3", txt_Auswahl_3.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_4", txt_Auswahl_4.Text);
                    cmd.Parameters.AddWithValue("@frageAntwort", antwort);
                    cmd.Parameters.AddWithValue("@fachId", dt.Rows[cbo_Fach.SelectedIndex][0]);
                    cmd.Parameters.AddWithValue("@admiId", admiId);
                    cmd.Parameters.AddWithValue("@EintragungsDatum", System.DateTime.Now);

                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Frage ist gespeichert!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    con.Close();
                    FragenAnzeigen();
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
        }

        private void btn_Bearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                string UpdateFrageTbl = "Update dbo.FrageTbl Set" +
                                           " frageBeschreibung = @frageBeschreibung, " +
                                           " frageWahl_1 = @frageWahl_1," +
                                           " frageWahl_2 = @frageWahl_2," +
                                           " frageWahl_3 = @frageWahl_3," +
                                           " frageWahl_4 = @frageWahl_4, " +
                                           " frageAntwort = @frageAntwort, " +
                                           " fachId = @fachId" +
                                           " Where" +
                                           " frageId = @frageId";
                if (txt_Frage.Text == "" || txt_Auswahl_1.Text == "" || txt_Auswahl_2.Text == "" || txt_Auswahl_3.Text == "" ||
                txt_Auswahl_4.Text == "")
                {
                    MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(UpdateFrageTbl, con);
                    cmd.Parameters.AddWithValue("@frageId", key);
                    cmd.Parameters.AddWithValue("@frageBeschreibung", txt_Frage.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_1", txt_Auswahl_1.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_2", txt_Auswahl_2.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_3", txt_Auswahl_3.Text);
                    cmd.Parameters.AddWithValue("@frageWahl_4", txt_Auswahl_4.Text);
                    //foreach (Control x in this.grb_Antworten.Controls)
                    //{
                    //    if (x is RadioButton)
                    //    {
                    //        if (((RadioButton)x).Checked == true)
                    //        {
                    //            cmd.Parameters.AddWithValue("@frageAntwort", ((RadioButton)x).Text);
                    //        }
                    //    }
                    //}
                    cmd.Parameters.AddWithValue("@frageAntwort", txt_Anwort.Text);
                    cmd.Parameters.AddWithValue("@fachId", dt.Rows[cbo_Fach.SelectedIndex][0]);

                    cmd.ExecuteNonQuery();
                    // MessageBox.Show("info", "Kandidat ist gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    FragenAnzeigen();
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
        private void btn_loeschen_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteFrageTbl = "Delete From dbo.FrageTbl" +
                                        " Where" +
                                        " frageId = @frageId";
                if (txt_Frage.Text == "" || txt_Auswahl_1.Text == "" || txt_Auswahl_2.Text == "" || txt_Auswahl_3.Text == "" ||
                txt_Auswahl_4.Text == "")
                {
                    MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deleteFrageTbl, con);
                    cmd.Parameters.AddWithValue("@frageId", dgv_Fragen.SelectedRows[0].Cells[0].Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Frage ist gelöscht!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    Reset();
                    FragenAnzeigen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  btn_loeschen_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_Rest_Click(object sender, EventArgs e)
        {
            Reset();

            // MessageBox.Show(cbo_Fach.SelectedIndex.ToString(), "SelectedIndex", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBox.Show(dt.Rows[cbo_Fach.SelectedIndex][0].ToString(), "Test Datatable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_Fragen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Frage.Text = dgv_Fragen.SelectedRows[0].Cells[1].Value.ToString();
                txt_Auswahl_1.Text = dgv_Fragen.SelectedRows[0].Cells[2].Value.ToString();
                txt_Auswahl_2.Text = dgv_Fragen.SelectedRows[0].Cells[3].Value.ToString();
                txt_Auswahl_3.Text = dgv_Fragen.SelectedRows[0].Cells[4].Value.ToString();
                txt_Auswahl_4.Text = dgv_Fragen.SelectedRows[0].Cells[5].Value.ToString();

                txt_Anwort.Text = dgv_Fragen.SelectedRows[0].Cells[6].Value.ToString();
                if (txt_Anwort.Text == txt_Auswahl_1.Text)
                {
                    rdoBtn_Auswahl_1_Richtig.Checked = true;

                }
                else if (txt_Anwort.Text == txt_Auswahl_2.Text)
                {
                    rdoBtn_Auswahl_2_Richtig.Checked = true;
                }
                else if (txt_Anwort.Text == txt_Auswahl_3.Text)
                {
                    rdoBtn_Auswahl_3_Richtig.Checked = true;
                }
                else if (txt_Anwort.Text == txt_Auswahl_4.Text)
                {
                    rdoBtn_Auswahl_4_Richtig.Checked = true;
                }
                //cbo_Fach.SelectedIndex = Convert.ToInt32(dgv_Fragen.SelectedRows[0].Cells[7].Value) - 1;
                cbo_Fach.SelectedValue = dgv_Fragen.SelectedRows[0].Cells[7].Value;


                if (txt_Frage.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(dgv_Fragen.SelectedRows[0].Cells[0].Value.ToString());
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

        private void cbo_Fach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  cbo_Fach_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_ErgebnisseAnzeigen_Click(object sender, EventArgs e)
        {
            ErgebnisseAnzeigen ergebnisseAnzeigen = new ErgebnisseAnzeigen();
            ergebnisseAnzeigen.Show();
            this.Hide();
        }
        int[] keys = new int[20];
        private void multirandom()
        {
            HashSet<int> number = new HashSet<int>();
            var rnd = new Random();
            while (number.Count < 15)
            {
                number.Add(rnd.Next(0, 15)); // es wird züfällige Zahlen generiert aber nur genau so wie die Anzahl des Fach Fragen 
            }
            for (int i = 0; i < 15; i++)
            {
                keys[i] = number.ElementAt(i);
            }
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            try
            {
                string[] benutzerAntworten = new string[16] { "als", "an", "auf", "aus", "bei", "für", "gegen", "in"
                                                            , "mit", "nach", "über", "um", "unter", "von", "vor", "zu" };
                //int index = 0;
                var rnd = new Random();
                if (openFileDialog_Import.ShowDialog() == DialogResult.OK)
                {
                    import_FileName_Pfad = @openFileDialog_Import.FileName;
                    string readline;
                    System.IO.StreamReader readfile = new System.IO.StreamReader(import_FileName_Pfad);
                    int index_0, index_1, index_2, index_3;
                    while ((readline = readfile.ReadLine()) != null)
                    {
                        string[] readlines = readline.Split(';');
                        multirandom();
                        do
                        {
                            index_0 = rnd.Next(0, 15);
                        } while (benutzerAntworten[keys[index_0]] == readlines[1]);
                        do
                        {
                            index_1 = rnd.Next(0, 15);
                        } while (index_0 == index_1 || benutzerAntworten[keys[index_1]] == readlines[1]);
                        do
                        {
                            index_2 = rnd.Next(0, 15);
                        } while (index_2 == index_1 || index_2 == index_0 || benutzerAntworten[keys[index_2]] == readlines[1]);
                        //Die richtige Antwort drin 
                        //do
                        //{
                        //    index_3 = rnd.Next(0, 15);
                        //} while (index_3 == index_0 || index_3 == index_1 || index_3 == index_2 || benutzerAntworten[keys[index_3]] == readlines[1]);
                        datenbankConnection.FrageEintragen(readlines[0].Trim(), benutzerAntworten[keys[index_0]], benutzerAntworten[keys[index_1]], benutzerAntworten[keys[index_2]], readlines[1].Trim(), readlines[1].Trim(), datenbankConnection.GetFachId(cbo_Fach.SelectedValue.ToString()));
                        //     counter++;
                        // impCounter++;
                    }
                    readfile.Close();
                    FragenAnzeigen();
                    // tSatusL1.Text = "Es gibt " + impCounter + " Datensätze importiert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btn_Import_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cbo_Fach_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByFach();
        }
        private void FilterByFach()
        {
            try
            {
                con.Open();
                string selectaalleFromErgebnisTbl = "SELECT frageId ,frageBeschreibung, frageWahl_1, frageWahl_2, frageWahl_3, frageWahl_4, frageAntwort, FachTbl.fachName As 'Fach Name' " +
                             " FROM FachTbl " +
                             " Join FrageTbl " +
                             " On (FrageTbl.fachId = FachTbl.fachId)" +
                             " Where FrageTbl.FachId = " + datenbankConnection.GetFachId(cbo_Fach.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(selectaalleFromErgebnisTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_Fragen.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "FilterByFach", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        private void rdoBtn_Auswahl_1_Richtig_CheckedChanged(object sender, EventArgs e)
        {
            txt_Anwort.Text = txt_Auswahl_1.Text;
        }

        private void rdoBtn_Auswahl_2_Richtig_CheckedChanged(object sender, EventArgs e)
        {
            txt_Anwort.Text = txt_Auswahl_2.Text;
        }

        private void rdoBtn_Auswahl_3_Richtig_CheckedChanged(object sender, EventArgs e)
        {
            txt_Anwort.Text = txt_Auswahl_3.Text;
        }

        private void rdoBtn_Auswahl_4_Richtig_CheckedChanged(object sender, EventArgs e)
        {
            txt_Anwort.Text = txt_Auswahl_4.Text;
        }
    }
}
