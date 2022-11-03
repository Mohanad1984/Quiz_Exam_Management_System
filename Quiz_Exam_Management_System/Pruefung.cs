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
    public partial class Pruefung : Form
    {
        public Pruefung()
        {
            InitializeComponent();
            lbl_KandidatName.Text = Einloggen.KandidatbenutzerName;
            datenbankConnection = new DatenbankConnection();
            GetFaecher();
            datenbankConnection.GetFragen(cbo_Fach.SelectedValue.ToString());
            //lbl_KandidatName.Text = Einloggen.dataTable_kandidat.Rows[0][1].ToString() + "  " + Einloggen.dataTable_kandidat.Rows[0][2].ToString();
            Qn = datenbankConnection.GetFragenAnzahl(cbo_Fach.SelectedValue.ToString());
            multirandom();
            // SaveHighest();
        }
        SqlConnection con = new SqlConnection(@"Data Source = HAUPT-PC; Initial Catalog = QuizDb; Integrated Security = True");
        //DataTable dataTable_Fragen;
        string antwort;
        string[] antworten_Array = new string[5];
        int random_generated_Werte;
        int[] keys = new int[1000]; //eine Array mit alle Mögliche random generated Werte
        int index = 0;
        int chrono = 0; // gesamt Zeit
        string[] benutzerAntworten = new string[100]; // eine Array mit alle 10 Benuter Antworten.
        int note = 0;

        int Qn; // Die Anzahl des Fragen in die ausgewählte Fach

        DatenbankConnection datenbankConnection;
        private void multirandom()
        {
            HashSet<int> number = new HashSet<int>();
            var rnd = new Random();
            random_generated_Werte = Qn - 1;
            while (number.Count < random_generated_Werte)
            {
                number.Add(rnd.Next(0, Qn)); // es wird züfällige Zahlen generiert aber nur genau so wie die Anzahl des Fach Fragen 
            }
            for (int i = 0; i < random_generated_Werte; i++)
            {
                keys[i] = number.ElementAt(i);
            }

            for (int y = 0; y < random_generated_Werte; y++)
            {
                textBox1.Text += keys[y].ToString() + "\r\n";
            }
        }
        private void SaveHighest()
        {
            con.Open();
            string selectMaxNoteOfKandidat = "Select Max(ErgebnisNoten) From ErgebnisTbl Where KandidatId = '" + 4 + "';";
            SqlDataAdapter sda = new SqlDataAdapter(selectMaxNoteOfKandidat, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show(dt.Rows[0][0].ToString(), "Fehler bei Fragen anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }
        private void GetFaecher()
        {
            try
            {
                cbo_Fach.ValueMember = "fachName";
                cbo_Fach.DataSource = datenbankConnection.DataTable_faecher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Fragen anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Rest()
        {

            radioBtn_Auswahl_1.Checked = false;
            radioBtn_Auswahl_2.Checked = false;
            radioBtn_Auswahl_3.Checked = false;
            radioBtn_Auswahl_4.Checked = false;
            radioBtn_Auswahl_5.Checked = false;
            radioBtn_Auswahl_1.BackColor = Color.BurlyWood;
            radioBtn_Auswahl_2.BackColor = Color.BurlyWood;
            radioBtn_Auswahl_3.BackColor = Color.BurlyWood;
            radioBtn_Auswahl_4.BackColor = Color.BurlyWood;
            radioBtn_Auswahl_5.BackColor = Color.BurlyWood;
        }
        private void antwortschildern()
        {
            if (radioBtn_Auswahl_1.Text == antworten_Array[0] || radioBtn_Auswahl_1.Text == antworten_Array[1] || radioBtn_Auswahl_1.Text == antworten_Array[2])
            {
                radioBtn_Auswahl_1.BackColor = Color.Green;
            }
            else if (radioBtn_Auswahl_2.Text == antworten_Array[0] || radioBtn_Auswahl_2.Text == antworten_Array[1] || radioBtn_Auswahl_2.Text == antworten_Array[2])
            {
                radioBtn_Auswahl_2.BackColor = Color.Green;
            }
            else if (radioBtn_Auswahl_3.Text == antworten_Array[0] || radioBtn_Auswahl_3.Text == antworten_Array[1] || radioBtn_Auswahl_3.Text == antworten_Array[2])
            {
                radioBtn_Auswahl_3.BackColor = Color.Green;
            }
            else if (radioBtn_Auswahl_4.Text == antworten_Array[0] || radioBtn_Auswahl_4.Text == antworten_Array[1] || radioBtn_Auswahl_4.Text == antworten_Array[2])
            {
                radioBtn_Auswahl_4.BackColor = Color.Green;
            }
            else if (radioBtn_Auswahl_5.Text == antworten_Array[0] || radioBtn_Auswahl_5.Text == antworten_Array[1] || radioBtn_Auswahl_5.Text == antworten_Array[2])
            {
                radioBtn_Auswahl_5.BackColor = Color.Green;
            }
        }
        private void check()
        {
            if (radioBtn_Auswahl_1.Checked)
            {
                benutzerAntworten[ifrage] = radioBtn_Auswahl_1.Text;
                if (benutzerAntworten[ifrage] == antworten_Array[0] || benutzerAntworten[ifrage] == antworten_Array[1] || benutzerAntworten[ifrage] == antworten_Array[2])
                {
                    radioBtn_Auswahl_1.BackColor = Color.Green;
                    note++;
                }
                else
                {
                    radioBtn_Auswahl_1.BackColor = Color.Red;
                    antwortschildern();
                }
            }
            else if (radioBtn_Auswahl_2.Checked)
            {
                benutzerAntworten[ifrage] = radioBtn_Auswahl_2.Text;

                if (benutzerAntworten[ifrage] == antworten_Array[0] || benutzerAntworten[ifrage] == antworten_Array[1] || benutzerAntworten[ifrage] == antworten_Array[2])
                {
                    radioBtn_Auswahl_2.BackColor = Color.Green;
                    note++;
                }
                else
                {
                    radioBtn_Auswahl_2.BackColor = Color.Red;
                    antwortschildern();
                }
            }
            else if (radioBtn_Auswahl_3.Checked)
            {
                benutzerAntworten[ifrage] = radioBtn_Auswahl_3.Text;
                if (benutzerAntworten[ifrage] == antworten_Array[0] || benutzerAntworten[ifrage] == antworten_Array[1] || benutzerAntworten[ifrage] == antworten_Array[2])
                {
                    radioBtn_Auswahl_3.BackColor = Color.Green;
                    note++;
                }
                else
                {
                    radioBtn_Auswahl_3.BackColor = Color.Red;
                    antwortschildern();
                }
            }
            else if (radioBtn_Auswahl_4.Checked)
            {
                benutzerAntworten[ifrage] = radioBtn_Auswahl_4.Text;
                if (benutzerAntworten[ifrage] == antworten_Array[0] || benutzerAntworten[ifrage] == antworten_Array[1] || benutzerAntworten[ifrage] == antworten_Array[2])
                {
                    radioBtn_Auswahl_4.BackColor = Color.Green;
                    note++;
                }
                else
                {
                    radioBtn_Auswahl_4.BackColor = Color.Red;
                    antwortschildern();
                }
            }
            else if (radioBtn_Auswahl_5.Checked)
            {
                benutzerAntworten[ifrage] = radioBtn_Auswahl_5.Text;
                if (benutzerAntworten[ifrage] == antworten_Array[0] || benutzerAntworten[ifrage] == antworten_Array[1] || benutzerAntworten[ifrage] == antworten_Array[2])
                {
                    radioBtn_Auswahl_5.BackColor = Color.Green;
                    note++;
                }
                else
                {
                    radioBtn_Auswahl_5.BackColor = Color.Red;
                    antwortschildern();
                }
            }
            else
            {
                antwortschildern();
            }
            txt_RichtigeAntwort.Text = note.ToString();
        }
        private void ErgebnisEintragen()
        {
            string InsertIntoErgebnisTbl = "Insert Into ErgebnisTbl (FachId, kandidatId, ergebnisDatum, ergebnisZeit," +
                " ergebnisNoten, ergebnisHinweise )" +
                " Values" +
                " (@FachId, @kandidatId, @ergebnisDatum, @ergebnisZeit, @ergebnisNoten, @ergebnisHinweise )";
            con.Open();
            SqlCommand cmd_InsertIntoErgebnisTbl = new SqlCommand(InsertIntoErgebnisTbl, con);
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@FachId", 1);    //lbl_Fach.Text.ToString());
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@kandidatId", 4);// lbl_Kandidaten.Text);
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisDatum", dateTimePicker1.Value.Date);
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisZeit", dateTimeP_PruefungZeit.Text);
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisNoten", note);
            cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisHinweise", " safd");

            cmd_InsertIntoErgebnisTbl.ExecuteNonQuery();
            con.Close();
        }
        int ifrage = 0;
        int gefragten_Fragen = 1;
        bool fragemodus = false;
        string Fragen_Id = "";
        private void btn_Einreichen_Click(object sender, EventArgs e)
        {
            try
            {
                timerFrageZeit.Start();
                grb_Fragen.Text = "Frage " + gefragten_Fragen;
                txt_GesamtFragen.Text = datenbankConnection.DataTable_Fragen.Rows.Count.ToString();
                btn_next.Enabled = true;
                radioBtn_Auswahl_1.Visible = true;
                radioBtn_Auswahl_2.Visible = true;
                radioBtn_Auswahl_3.Visible = true;
                radioBtn_Auswahl_4.Visible = true;
                radioBtn_Auswahl_5.Visible = true;
                //foreach (DataRow dr in datenbankConnection.DataTable_Fragen.Rows)
                //{
                //    textBox2.Text += dr[0].ToString() + "\r\n";
                //    textBox2.Text += dr[1].ToString() + "\r\n";
                //    textBox2.Text += dr[2].ToString() + "\r\n";
                //    textBox2.Text += dr[3].ToString() + "\r\n";
                //    textBox2.Text += dr[4].ToString() + "\r\n";
                //    textBox2.Text += dr[5].ToString() + "\r\n";
                //    textBox2.Text += "" + "\r\n";
                //}
                Fragen_Id = datenbankConnection.DataTable_Fragen.Rows[keys[index]][0].ToString();
                string frage = datenbankConnection.DataTable_Fragen.Rows[keys[index]][1].ToString();
                txt_Frage.Text = frage;
                grb_Fragen.Text = "Antwort Moglichkeiten";
                radioBtn_Auswahl_1.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][2].ToString();
                radioBtn_Auswahl_2.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][3].ToString();
                radioBtn_Auswahl_3.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][4].ToString();
                radioBtn_Auswahl_4.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][5].ToString();
                //radioBtn_Auswahl_5.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][6].ToString();
                antwort = datenbankConnection.DataTable_Fragen.Rows[keys[index]][6].ToString();
                // ich glaube , dass unnötig
                int l = datenbankConnection.GetAntworten(Fragen_Id).Length;
                // ich glaube , dass unnötig
                antworten_Array = datenbankConnection.GetAntworten(Fragen_Id);
                ifrage++;
                index++;
                gefragten_Fragen++;
                btn_Einreichen.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  btn_Einreichen_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //TimerCheck.Start();
            try
            {
                if (gefragten_Fragen <= datenbankConnection.DataTable_Fragen.Rows.Count)
                {
                    if (fragemodus)
                    {
                        Rest();
                        grb_Fragen.Text = "Frage " + gefragten_Fragen;
                        btn_next.Text = "Check";
                        textBox2.Text = "";
                        txt_Frage.Text = datenbankConnection.DataTable_Fragen.Rows[keys[index]][1].ToString();
                        string[] initialArray = new string[4];
                        initialArray[0] = datenbankConnection.DataTable_Fragen.Rows[keys[index]][2].ToString();
                        initialArray[1] = datenbankConnection.DataTable_Fragen.Rows[keys[index]][3].ToString();
                        initialArray[2] = datenbankConnection.DataTable_Fragen.Rows[keys[index]][4].ToString();
                        initialArray[3] = datenbankConnection.DataTable_Fragen.Rows[keys[index]][5].ToString();
                        antwort = datenbankConnection.DataTable_Fragen.Rows[keys[index]][6].ToString();
                        // initialArray[4] = datenbankConnection.DataTable_Fragen.Rows[keys[index]][6].ToString();
                        Random rnd = new Random();
                        string[] MyRandomArray = initialArray.OrderBy(x => rnd.Next()).ToArray();
                        radioBtn_Auswahl_1.Text = MyRandomArray[0];
                        radioBtn_Auswahl_2.Text = MyRandomArray[1];
                        radioBtn_Auswahl_3.Text = MyRandomArray[2];
                        radioBtn_Auswahl_4.Text = MyRandomArray[3];
                        //radioBtn_Auswahl_5.Text = MyRandomArray[4];
                        Fragen_Id = datenbankConnection.DataTable_Fragen.Rows[keys[index]][0].ToString();
                        antworten_Array = datenbankConnection.GetAntworten(Fragen_Id);
                        ////MessageBox.Show("Start");
                        //foreach (string dr in MyRandomArray)
                        //{
                        //    //textBox2.Text += dr + "\r\n";
                        //    textBox2.Text += "antwort " + antwort + "\r\n";
                        //}
                        //for (int i = 0; i < datenbankConnection.GetAntworten(datenbankConnection.DataTable_Fragen.Rows[keys[index]][1].ToString()).Length; i++)
                        //{

                        //    textBox2.Text += "" + "\r\n" + datenbankConnection.GetAntworten(datenbankConnection.DataTable_Fragen.Rows[keys[index]][1].ToString())[i];
                        //}
                        fragemodus = false;
                        index++;
                        gefragten_Fragen++;
                        //MessageBox.Show("Ende");
                    }
                    else
                    {
                        btn_next.Text = "Nächste Frage";
                        check();
                        fragemodus = true;
                        ifrage++;
                    }

                }
                else
                {
                    btn_next.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  btn_next_Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbo_Fach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Clear();
                radioBtn_Auswahl_1.Visible = false;
                radioBtn_Auswahl_2.Visible = false;
                radioBtn_Auswahl_3.Visible = false;
                radioBtn_Auswahl_4.Visible = false;
                grb_Fragen.Text = "Fragen";
                Qn = datenbankConnection.GetFragenAnzahl(cbo_Fach.SelectedValue.ToString());
                datenbankConnection.GetFragen(cbo_Fach.SelectedValue.ToString());
                if (cbo_Fach.SelectedValue.ToString() == "Präpositionen")
                {
                    pic_Hinweis.ImageLocation = "C:\\Users\\Admi\\source\\repos\\Quiz_Exam_Management_System\\Praepositionen_HiweiseBild.png";
                    pic_Hinweis.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                multirandom();
                btn_Einreichen.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  cbo_Fach_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //int ii = 3;
        private void TimerCheck_Tick(object sender, EventArgs e)
        {

            //if (ii > 0)
            //{
            //    timerFrageZeit.Stop();
            //    btn_next.Enabled = false;
            //    btn_next.Text = ii.ToString();
            //    ii--;
            //}
            //else
            //{
            //    btn_next.Text = "Next";
            //    btn_next.Enabled = true;
            //    ii = 3;
            //    TimerCheck.Stop();
            //    Rest();
            //    FetchFragen();
            //    timerFrageZeit.Start();
            //}
        }
        private void timerFrageZeit_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (progressBarFrageZeit.Value > 0)
                //{
                chrono++;
                //   progressBarFrageZeit.Value = chrono;

                lbl_Zeit.Text = chrono.ToString();

                //}
                //else  
                //{
                //    progressBarFrageZeit.Value = 100;
                //    timerFrageZeit.Stop();
                //    ErgebnisEintragen();
                //    MessageBox.Show("Ihre Ergebnis ist: " + note);
                //    Einloggen log = new Einloggen();
                //    log.Show();
                //    this.Hide();

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei  timerFrageZeit_Tick", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void radioBtn_Auswahl_1_CheckedChanged(object sender, EventArgs e)
        {
            benutzerAntworten[ifrage] = radioBtn_Auswahl_1.Text;
        }
        private void radioBtn_Auswahl_2_CheckedChanged(object sender, EventArgs e)
        {
            benutzerAntworten[ifrage] = radioBtn_Auswahl_2.Text;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            benutzerAntworten[ifrage] = radioBtn_Auswahl_3.Text;
        } //Der Index war außerhalb des Arraybereichs."Bereich [0, 99]

        private void radioBtn_Auswahl_4_CheckedChanged(object sender, EventArgs e)
        {
            benutzerAntworten[ifrage] = radioBtn_Auswahl_4.Text;
        }// Achtung:
         //: "Der Index war außerhalb des Arraybereichs."
        private void radioBtn_Auswahl_5_CheckedChanged(object sender, EventArgs e)
        {
            benutzerAntworten[ifrage] = radioBtn_Auswahl_5.Text;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            About ein = new About();
            ein.ShowDialog();
        }
        private void lbl_Kandidaten_DoubleClick(object sender, EventArgs e)
        {
            ErgebnisseAnzeigen ergebnisseAnzeigen = new ErgebnisseAnzeigen();
            ergebnisseAnzeigen.Show();
            this.Hide();
        }
    }
}
