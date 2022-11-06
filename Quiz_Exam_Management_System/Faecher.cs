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
    public partial class Faecher : Form
    {
        int key = 0;
        SqlConnection con = new SqlConnection(@"Data Source = localhost; Initial Catalog = QuizDb; Integrated Security = True");
        public Faecher()
        {
            InitializeComponent();
            //CreateTables();
            FaecherAnzeigen();
        }
        private void CreateTables()
        {
            try
            {
                string CREATEFachTbl = "CREATE TABLE dbo.FachTbl " +
                    "(" +
                    " fachId int NOT NULL IDENTITY (1, 1)  PRIMARY KEY, " +
                    " fachName VARCHAR(100) NOT NULL," +
                    " fachHinweise VARCHAR(500) NULL," +
                    ");";
                con.Open();
                SqlCommand cmd = new SqlCommand(CREATEFachTbl, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("info", "Kandidat ist gespeichert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CreateTables FachTbl", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Reset()
        {
            txt_FachName.Text = "";
            txt_Hinweise.Text = "";
            key = 0;
        }

        private void FaecherAnzeigen()
        {
            try
            {
                con.Open();
                string SelectIntoKandidatTbl = "Select * From FachTbl";
                SqlDataAdapter sda = new SqlDataAdapter(SelectIntoKandidatTbl, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dgv_FaecherList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler bei Kandidaten anzeigen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }
        private void btn_Speicher_Click(object sender, EventArgs e)
        {
            string InsertIntoFachTbl = "Insert Into FachTbl (fachName, fachHinweise) " +
                                                   " Values" +
                                                   " (@fName, @fHinweise)";
            if (txt_FachName.Text == "")
            {
                MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //int score = 0;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(InsertIntoFachTbl,con);
                    cmd.Parameters.AddWithValue("@fName", txt_FachName.Text);
                    cmd.Parameters.AddWithValue("@fHinweise", txt_Hinweise.Text);
                    cmd.ExecuteNonQuery();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    FaecherAnzeigen();
                }
            }
        }

        private void btn_Rest_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgv_FaecherList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(txt_FachName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgv_FaecherList.SelectedRows[0].Cells[0].Value);
            }
            txt_FachName.Text = dgv_FaecherList.SelectedRows[0].Cells[1].Value.ToString();
            txt_Hinweise.Text = dgv_FaecherList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btn_Bearbeiten_Click(object sender, EventArgs e)
        {
            string UpdateFachTbl = "Update dbo.FachTbl Set" +
                                          " fachName = @fName, " +
                                          " fachHinweise = @fHinweise " +
                                        
                                          "Where " +
                                          "fachId = @fId";
            if (txt_FachName.Text == "")
            {
                MessageBox.Show("info", "info fehlt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(UpdateFachTbl, con);
                    cmd.Parameters.AddWithValue("@fId", key);
                    cmd.Parameters.AddWithValue("@fName", txt_FachName.Text);
                    cmd.Parameters.AddWithValue("@fHinweise", txt_Hinweise.Text);
                    cmd.ExecuteNonQuery();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    FaecherAnzeigen();
                }
            }
        }

        private void lbl_Kandidaten_Click(object sender, EventArgs e)
        {
            Kandidaten kandi = new Kandidaten();
            kandi.Show();
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
