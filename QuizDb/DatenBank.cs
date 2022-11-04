using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDb
{
    public class DatenBank
    {
        public virtual /*DbSet<Artikel>*/User UserTab { get; set; }
        public virtual /*DbSet<Lager>*/Fragen FragenTab { get; set; }
        public virtual /*DbSet<Lager>*/Faecher FaecherTab { get; set; }
        public virtual /*DbSet<Lager>*/ Ergebnis ErgebnisseTab { get; set; }
        //public virtual /*DbSet<MaterialBuchung>*/ MaterialBuchungen { get; set; }

        private string con;
        private DataTable dataTable_Admi;
        private DataTable dataTable_Kandidat;
        private DataTable dataTable_Fragen;
        private DataTable dataTable_faecher;
        private DataTable dataTable_ergebnisse;
        private String Server = "Data Source = HAUPT-PC; ";
        private String UserID = "Initial Catalog = QuizDb; ";
        private String Password = "Integrated Security = True";
        private String Database = "Database=QuizDb";
        private const string SelectallesFromAdmiTbl = "Select * From AdmiTbl";
        private const string SelectallesFromKanditatTbl = "Select * From KanditatTbl";
        private const string SelectallesFromFachTbl = "Select * From FachTbl";
        private const string SelectallesFromFrageTbl = "Select * From FrageTbl Where fachId = ";
        private const string SelectallesFrage_antworten = "Select frageAntwort From FrageTbl Where frageBeschreibung = ";
        private const string SelectallesFromErgebnisTbl = "Select * From ErgebnisTbl";
        //private string s7 = "Select * From ";
        //private string s8 = "Select Max(ErgebnisNoten) From ErgebnisTbl Where KandidatId = '" + 4 + "';";
        //private string s9 = "Select count(*) From FrageTbl Where fachId = ";
        //private string s10 = "";

        public DatenBank()
        {
            con = Server + UserID + Password;
            GetFaecher();
        }

        private const String commandStringCreateTableAdmiTbl = "CREATE TABLE AdmiTbl( "
                                     + " AdmiId INT NOT NULL IDENTITY (1, 1)  PRIMARY KEY,"
                                     + " AdmiVorname NVARCHAR(100) NOT NULL,"
                                     + " AdmiNachname NVARCHAR(100) NOT NULL,"
                                     + " AdmiBenutzername NVARCHAR(100) NOT NULL,"
                                     + " AdmiPasswort NVARCHAR(100) NOT NULL,"
                                     + " AdmiTelefonnummer NVARCHAR(30) NOT NULL,"
                                     + " AdmiE_mail NVARCHAR(50) NOT NULL,"
                                     + " AdmiStrasse NVARCHAR(100) NOT NULL,"
                                     + " AdmiHausNr NVARCHAR(10) NOT NULL,"
                                     + " AdmiPlz NVARCHAR(7) NOT NULL,"
                                     + " AdmiOrt NVARCHAR(30) NOT NULL,"
                                     + " AdmiHinweise NVARCHAR(500),"
                                     + " AdmiGeburtsdatum DATE NOT NULL"
                                     + " )";

        private const String commandStringCreateTableKandidatTbl = "CREATE TABLE KandidatTbl(" +
                            " kandidatId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY," +
                            " kandidatVorname VARCHAR(100) NOT NULL," +
                            " kandidatNachname VARCHAR(100) NOT NULL," +
                            " kandidatBenutzername VARCHAR(100) NOT NULL," +
                            " kandidatPasswort VARCHAR(100) NOT NULL," +
                            " kandidatTelefonnummer VARCHAR(30) NOT NULL," +
                            " kandidatE_mail VARCHAR(50) NOT NULL," +
                            " kandidatStrasse VARCHAR(100) NOT NULL," +
                            " kandidatHausNr VARCHAR(10) NOT NULL," +
                            " kandidatPlz VARCHAR(7) NOT NULL," +
                            " kandidatOrt VARCHAR(30) NOT NULL," +
                            " kandidatHinweise VARCHAR(500)," +
                            " kandidatGeburtsdatum DATE NOT NULL, " +
                            " kandidatEintragenAdmiId INT, " +
                            " kandidatEintragungsdatum DATE, " +
                            " FOREIGN KEY (kandidatEintragenAdmiId) REFERENCES AdmiTbl (AdmiId)" +
                            ");";

        private const String commandStringCreateTableFachTbl = "CREATE TABLE FachTbl (" +
                            " fachId INT(10) AUTO_INCREMENT PRIMARY KEY," +
                            " fachName VARCHAR(100) NOT NULL," +
                            " fachHinweise VARCHAR(500), " +
                            " AdmiId INT NOT NULL , " +
                            " fBearbeitenAdmiId INT NOT NULL, " +
                            " fEintragungsdatum DATE NULL" +
                            " fBearbeitendatum DATE NULL" +
                            " FOREIGN KEY (fEintragenAdmiId) REFERENCES AdmiTbl (AdmiId)" +
                            " );";

        private const String commandStringCreateTableFrageTbl = "CREATE TABLE FrageTbl(" +
                            " frageId INT NOT NULL IDENTITY (1, 1)  PRIMARY KEY," +
                            " frageBeschreibung NVARCHAR(100) NOT NULL," +
                            " frageWahl_1 NVARCHAR(100) NOT NULL," +
                            " frageWahl_2 NVARCHAR(100) NOT NULL," +
                            " frageWahl_3 NVARCHAR(100) NOT NULL," +
                            " frageWahl_4 NVARCHAR(100) NOT NULL," +
                            //" frageWahl_5 NVARCHAR(100) NULL," +
                            " frageAntwort  NVARCHAR(100) NOT NULL," +
                            " fachId  INT(10) NOT NULL," +
                            " admiId  INT(10) NOT NULL," +
                            " EintragungsDatum INT(10) NOT NULL," +
                            " FOREIGN KEY (admiId) REFERENCES AdmiTbl (admiId)" +
                            " FOREIGN KEY (fachId) REFERENCES FachTbl (fachId)" +
                            " );";

        private const String commandStringCreateTableErgebnisTbl = "CREATE TABLE ErgebnisTbl(" +
                           " ergebnisId INT NOT NULL IDENTITY (1, 1) PRIMARY KEY," +
                           " fachId INT(10) NOT NULL," +
                           " kandidatId INT(10) NOT NULL," +
                           " ergebnisDatum DATE NOT NULL," +
                           " ergebnisZeit TIME NOT NULL," +
                           " ergebnisNoten INT NOT NULL," +
                           " ergebnisHinweise VARCHAR(500) NULL," +
                           " FOREIGN KEY (fachId) REFERENCES FachTbl (fachId)," +
                           " FOREIGN KEY (kandidatId) REFERENCES KandidatTbl (kandidatId)" +
                           " ); ";

        private const String commandStringInsertIntoTableAdmiTblAnfangswert = "Insert Into AdmiTbl( "
                                                 + " AdmiVorname, AdmiNachname, AdmiBenutzername, AdmiPasswort, AdmiTelefonnummer, AdmiStrasse,"
                                                 + " AdmiHausNr, AdmiPlz, AdmiOrt, AdmiHinweise, AdmiGeburtsdatum )" +
                                                 "Values " +
                                                 "('AdmiVorname','AdmiNachname','admi','admi','0157874547', 'AdmiE_mail@hotmail.com'," +
                                                 " 'AdmiStrasse', 'AdmiHausNr','AdmiPlz','AdmiOrt','AdmiHinweise','2000-08-21');";

        private const string InsertIntoKandidatTbl = "Insert Into KandidatTbl (kandidatVorname, kandidatNachname, kandidatBenutzername, kandidatPasswort, kandidatTelefonnummer," +//,kandidatE_mail
                                                    " kandidatStrasse, kandidatHausNr, kandidatPlz, kandidatOrt, kandidatHinweise, kandidatGeburtsdatum )" +
                                                    " Values" +
                                                    " (@kVorname, @kNachname, @kBenutzername, @kPasswort, @kTel," +
                                                    "  @kStrasse, @kHausNr, @kPlz, @kOrt, @kHinweise, @kGeburtsdatum)";

        private const string InsertIntoAdmiTbl = "Insert Into AdmiTbl (AdmiVorname, AdmiNachname, AdmiBenutzername, AdmiPasswort, AdmiTelefonnummer," + //,AdmiE_mail
                                                 " AdmiStrasse, AdmiHausNr, AdmiPlz, AdmiOrt, AdmiHinweise, AdmiGeburtsdatum )" +
                                                 " Values" +
                                                 " (@aVorname, @aNachname, @aBenutzername, @aPasswort, @aTel," + //AdmiE_mail
                                                 " @aStrasse, @aHausNr, @aPlz, @aOrt, @aHinweise, @aGeburtsdatum)";
        private const string InsertIntoErgebnisTbl = "Insert Into ErgebnisTbl (FachId, kandidatId, ergebnisDatum, ergebnisZeit," +
                                                     " ergebnisNoten, ergebnisHinweise )" +
                                                     " Values" +
                                                     " (@FachId, @kandidatId, @ergebnisDatum, @ergebnisZeit, @ergebnisNoten, @ergebnisHinweise )";

        private const string InsertIntoFrageTbl = "Insert Into FrageTbl (frageBeschreibung, frageWahl_1, frageWahl_2," +
                                                    " frageWahl_3, frageWahl_4, frageAntwort, fachId )" + //frageWahl_5 EintragungsDatum ,admiId
                                                    " Values" +
                                                    " (@frageBeschreibung, @frageWahl_1, @frageWahl_2, @frageWahl_3, @frageWahl_4," +
                                                    " @frageAntwort, @fachId)"; //, @frageWahl_5, @EintragungsDatum , @admiId 

        private const string InsertIntoFachTbl = "Insert Into FachTbl (fachId, fachName, fachHinweise," + //fEintragenAdmiId fBearbeitenAdmiId, fBearbeitendatum
                                                    " Values" +
                                                    " (@fachId, @fachName, @fachHinweise)"; //@fEintragenAdmiId, @fBearbeitenAdmiId, @fBearbeitendatum

        private const string UpdateKandidatTbl = "Update dbo.KandidatTbl Set" +
                                                  " kandidatVorname = @kVorname, " +
                                                  " kandidatNachname = @kNachname," +
                                                  " kandidatBenutzername = @kBenutzername," +
                                                  " kandidatPasswort = @kPasswort," +
                                                  " kandidatTelefonnummer = @kTel," +
                                                  //" kandidatE_mail = @kE_mail ," +
                                                  " kandidatStrasse = @kStrasse, " +
                                                  " kandidatHausNr = @kHausNr, " +
                                                  " kandidatPlz = @kPlz, " +
                                                  " kandidatOrt = @kOrt, " +
                                                  " kandidatHinweise = @kHinweise," +
                                                  " kandidatGeburtsdatum = @kGeburtsdatum " +
                                                  "Where " +
                                                  "kandidatId = @kId";

        private const string UpdateAdmiTbl = "Update dbo.AdmiTbl Set" +
                                                 " AdmiVorname = @aVorname, " +
                                                 " AdmiNachname = @aNachname," +
                                                 " AdmiBenutzername = @aBenutzername," +
                                                 " AdmiPasswort = @aPasswort," +
                                                 " AdmiTelefonnummer = @aTel," +
                                                 //" AdmiE_mail = @aE_mail ," +
                                                 " AdmiStrasse = @aStrasse, " +
                                                 " AdmiHausNr = @aHausNr, " +
                                                 " AdmiPlz = @aPlz, " +
                                                 " AdmiOrt = @aOrt, " +
                                                 " AdmiHinweise = @aHinweise," +
                                                 " AdmiGeburtsdatum = @aGeburtsdatum " +
                                                 " Where" +
                                                 " AdmiId = @aId";
        private const string UpdateFachTbl = "Update dbo.FachTbl Set" +
                                                 " fachName = @fName, " +
                                                 " fachHinweise = @fHinweise " +
                                                 " Where" +
                                                 " fachId = @fId";
        private const string UpdateFrageTbl = "Update dbo.FrageTbl Set" +
                                               " frageBeschreibung = @frageBeschreibung, " +
                                               " frageWahl_1 = @frageWahl_1," +
                                               " frageWahl_2 = @frageWahl_2," +
                                               " frageWahl_3 = @frageWahl_3," +
                                               " frageWahl_4 = @frageWahl_4, " +
                                               " frageAntwort = @frageAntwort, " +
                                               " fachId = @fachId" +
                                               " Where" +
                                               " frageId = @frageId";
        private const String scommandStringDropDatabaseQuizDb = "DROP DATABASE QuizDb;";
        private const String scommandStringDropTableAdmiTbl = "DROP TABLE AdmiTbl;";
        private const String scommandStringDropTableKandidatTbl = "DROP TABLE KandidatTbl;";
        private const String scommandStringDropTableFachTbl = "DROP TABLE FachTbl;";
        private const String scommandStringDropTableFrageTbl = "DROP TABLE FrageTbl;";
        private const String scommandStringDropTableErgebnisTbl = "DROP TABLE ErgebnisTbl;";

        public string Connection
        {
            get { return con; }
            set { con = value; }
        }

        public DataTable DataTable_Admi
        {
            get { return dataTable_Admi; }
            set { dataTable_Admi = value; }
        }
        public DataTable DataTable_Kandidat
        {
            get { return dataTable_Kandidat; }
            set { dataTable_Kandidat = value; }
        }
        public DataTable DataTable_faecher
        {
            get { return dataTable_faecher; }
            set { dataTable_faecher = value; }
        }
        public DataTable DataTable_Fragen
        {
            get { return dataTable_Fragen; }
            set { dataTable_Fragen = value; }
        }
        public DataTable dataTable_Ergebnisse
        {
            get { return dataTable_ergebnisse; }
            set { dataTable_ergebnisse = value; }
        }
        SqlConnection conn = new SqlConnection(@"Data Source = HAUPT-PC; Initial Catalog = QuizDb; Integrated Security = True");

        public void CreateDatabase()
        {
            using (SqlConnection connection = new SqlConnection(Server + UserID + Password + Database))
            {
                try
                {
                    String scommandStringCreateDatabaseQuizDb = "CREATE DATABASE IF NOT EXISTS `QuizDb`;";

                    using (SqlCommand command = new SqlCommand(scommandStringCreateDatabaseQuizDb, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void CreateTables()
        {
            using (SqlConnection connection = new SqlConnection(Server + UserID + Password + Database))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(commandStringCreateTableAdmiTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(commandStringCreateTableKandidatTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(commandStringCreateTableFachTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(commandStringCreateTableFrageTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(commandStringCreateTableErgebnisTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(commandStringInsertIntoTableAdmiTblAnfangswert, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void DropDatabase()
        {

            using (SqlConnection connection = new SqlConnection(Server + UserID + Password + Database))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(scommandStringDropDatabaseQuizDb, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void DropTables()
        {
            using (SqlConnection connection = new SqlConnection(Server + UserID + Password + Database))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(scommandStringDropTableAdmiTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(scommandStringDropTableKandidatTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(scommandStringDropTableFachTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(scommandStringDropTableFrageTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(scommandStringDropTableErgebnisTbl, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void GetAdmi()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SelectallesFromAdmiTbl, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataTable_Admi = new DataTable();
                dataTable_Admi.Columns.Add("AdmiId", typeof(int));
                dataTable_Admi.Columns.Add("AdmiVorname", typeof(string));
                dataTable_Admi.Columns.Add("AdmiNachname", typeof(string));
                dataTable_Admi.Columns.Add("AdmiBenutzername", typeof(string));
                dataTable_Admi.Columns.Add("AdmiPasswort", typeof(string));
                dataTable_Admi.Columns.Add("AdmiTelefonnummer", typeof(string));
                //dataTable_Admi.Columns.Add("AdmiE_mail", typeof(string));
                dataTable_Admi.Columns.Add("AdmiStrasse", typeof(string));
                dataTable_Admi.Columns.Add("AdmiHausNr", typeof(string));
                dataTable_Admi.Columns.Add("AdmiPlz", typeof(string));
                dataTable_Admi.Columns.Add("AdmiOrt", typeof(string));
                dataTable_Admi.Columns.Add("AdmiHinweise", typeof(string));
                dataTable_Admi.Columns.Add("AdmiGeburtsdatum", typeof(DateTime));
                dataTable_Admi.Load(reader);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetKanditaten()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SelectallesFromKanditatTbl, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataTable_Kandidat = new DataTable();
                dataTable_Kandidat.Columns.Add("AdmiId", typeof(int));
                dataTable_Kandidat.Columns.Add("AdmiVorname", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiNachname", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiBenutzername", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiPasswort", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiTelefonnummer", typeof(string));
                //dataTable_Kandidat.Columns.Add("kandidatE_mail", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiStrasse", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiHausNr", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiPlz", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiOrt", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiHinweise", typeof(string));
                dataTable_Kandidat.Columns.Add("AdmiGeburtsdatum", typeof(DateTime));
                dataTable_Kandidat.Load(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conn.Close();
            }
        }
        private void GetFaecher()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SelectallesFromFachTbl, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataTable_faecher = new DataTable();
                dataTable_faecher.Columns.Add("fachId", typeof(int));
                dataTable_faecher.Columns.Add("fachName", typeof(string));
                dataTable_faecher.Columns.Add("fEintragenAdmiId", typeof(int));
                dataTable_faecher.Columns.Add("fBearbeitendatum", typeof(DateTime));
                dataTable_faecher.Load(reader);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conn.Close();
            }
        }
        public int GetFachId(string value)
        {
            conn.Open();
            string select = "Select fachId From FachTbl Where fachName = '" + value + "'; ";
            int Value;
            SqlCommand command = new SqlCommand(select, conn);
            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                Value = reader.GetInt32(0);
            }
            conn.Close();
            return Value;
        }
        public int GetFragenAnzahl(string value)
        {
            conn.Open();
            //object s = DataTable_faecher.Rows[Index][0];
            string selectCount = "Select count(*) From FrageTbl Where fachId = (Select fachId From FachTbl Where fachName = '" + value + "');";
            SqlDataAdapter sda = new SqlDataAdapter(selectCount, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
            int v = Convert.ToInt32(dt.Rows[0][0]);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public void GetFragen(string value)
        {
            try
            {
                conn.Open();
                string SubSelect = SelectallesFromFrageTbl;
                SubSelect = " (Select fachId From FachTbl Where fachName = '" + value + "'); ";
                SqlCommand cmd = new SqlCommand(SelectallesFromFrageTbl + SubSelect, conn);
                dataTable_Fragen = new DataTable();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataTable_Fragen = new DataTable();
                dataTable_Fragen.Columns.Add("frageId", typeof(int));
                dataTable_Fragen.Columns.Add("frageBeschreibung", typeof(string));
                dataTable_Fragen.Columns.Add("frageWahl_1", typeof(string));
                dataTable_Fragen.Columns.Add("frageWahl_2", typeof(string));
                dataTable_Fragen.Columns.Add("frageWahl_3", typeof(string));
                dataTable_Fragen.Columns.Add("frageWahl_4", typeof(string));
                // dataTable_Fragen.Columns.Add("frageWahl_5", typeof(string));
                dataTable_Fragen.Columns.Add("frageAntwort", typeof(string));
                dataTable_Fragen.Columns.Add("fachId", typeof(int));
                // dataTable_Fragen.Columns.Add("admiId", typeof(int));
                // dataTable_Fragen.Columns.Add("EintragungsDatum", typeof(DateTime));
                dataTable_Fragen.Load(reader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public string[] GetAntworten(string frage)
        {
            try
            {///sdsdsdsdsdsdsdddddddddddddd
                int i = 0;
                string[] antworten = new string[5];
                conn.Open();
                string s = SelectallesFrage_antworten + "'" + frage + "'";
                SqlCommand cmd = new SqlCommand(s, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    // reader.Read();
                    while (reader.Read())
                    {
                        antworten[i] = reader.GetString(0);
                        i++;
                    }
                }
                return antworten;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void GetErgebnisse()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SelectallesFromErgebnisTbl, conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                dataTable_ergebnisse = new DataTable();
                dataTable_ergebnisse.Columns.Add("ergebnisId", typeof(int));
                dataTable_ergebnisse.Columns.Add("fachId", typeof(int));
                dataTable_ergebnisse.Columns.Add("kandidatId", typeof(int));
                dataTable_ergebnisse.Columns.Add("ergebnisDatum", typeof(DateTime));
                dataTable_ergebnisse.Columns.Add("ergebnisZeit", typeof(DateTime));
                dataTable_ergebnisse.Columns.Add("ergebnisNoten", typeof(int));
                dataTable_ergebnisse.Columns.Add("ergebnisHinweise", typeof(string));
                dataTable_ergebnisse.Load(reader);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conn.Close();
            }
        }
        private void AdmiEintragen(string aVorname, string aNachname, string aBenutzername, string aPasswort, string aTel, string aStrasse, string aHausNr, string aPlz, string aOrt, string aHinweise, DateTime aGeburtsdatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertIntoAdmiTbl, conn);
                cmd.Parameters.AddWithValue("@aVorname", aVorname);
                cmd.Parameters.AddWithValue("@aNachname", aNachname);
                cmd.Parameters.AddWithValue("@aBenutzername", aBenutzername);
                cmd.Parameters.AddWithValue("@aPasswort", aPasswort);
                cmd.Parameters.AddWithValue("@aTel", aTel);
                //cmd.Parameters.AddWithValue("@AdmiE_mail", aE_mail);
                cmd.Parameters.AddWithValue("@aStrasse", aStrasse);
                cmd.Parameters.AddWithValue("@aHausNr", aHausNr);
                cmd.Parameters.AddWithValue("@aPlz", aPlz);
                cmd.Parameters.AddWithValue("@aOrt", aOrt);
                cmd.Parameters.AddWithValue("@aHinweise", aHinweise);
                cmd.Parameters.AddWithValue("@aGeburtsdatum", aGeburtsdatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void AdmiBearbeiten(int aId, string aVorname, string aNachname, string aBenutzername, string aPasswort, string aTel, string aStrasse, string aHausNr, string aPlz, string aOrt, string aHinweise, DateTime aGeburtsdatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(UpdateAdmiTbl, conn);
                cmd.Parameters.AddWithValue("@aId", aId);
                cmd.Parameters.AddWithValue("@aVorname", aVorname);
                cmd.Parameters.AddWithValue("@aNachname", aNachname);
                cmd.Parameters.AddWithValue("@aBenutzername", aBenutzername);
                cmd.Parameters.AddWithValue("@aPasswort", aPasswort);
                cmd.Parameters.AddWithValue("@aTel", aTel);
                //cmd.Parameters.AddWithValue("@aE_mail", aE_mail);
                cmd.Parameters.AddWithValue("@aStrasse", aStrasse);
                cmd.Parameters.AddWithValue("@aHausNr", aHausNr);
                cmd.Parameters.AddWithValue("@aPlz", aPlz);
                cmd.Parameters.AddWithValue("@aOrt", aOrt);
                cmd.Parameters.AddWithValue("@aHinweise", aHinweise);
                cmd.Parameters.AddWithValue("@aGeburtsdatum", aGeburtsdatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void KandidatEintragen(string kVorname, string kNachname, string kBenutzername, string kPasswort, string kTel, string kStrasse, string kHausNr, string kPlz, string kOrt, string kHinweise, DateTime kGeburtsdatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertIntoKandidatTbl, conn);
                cmd.Parameters.AddWithValue("@kVorname", kVorname);
                cmd.Parameters.AddWithValue("@kNachname", kNachname);
                cmd.Parameters.AddWithValue("@kBenutzername", kBenutzername);
                cmd.Parameters.AddWithValue("@kPasswort", kPasswort);
                cmd.Parameters.AddWithValue("@kTel", kTel);
                //cmd.Parameters.AddWithValue("@kE_mail", kE_mail);
                cmd.Parameters.AddWithValue("@kStrasse", kStrasse);
                cmd.Parameters.AddWithValue("@kHausNr", kHausNr);
                cmd.Parameters.AddWithValue("@kPlz", kPlz);
                cmd.Parameters.AddWithValue("@kOrt", kOrt);
                cmd.Parameters.AddWithValue("@kHinweise", kHinweise);
                cmd.Parameters.AddWithValue("@kGeburtsdatum", kGeburtsdatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void KandidatBearbeiten(int kId, string kVorname, string kNachname, string kBenutzername, string kPasswort, string kTel, string kStrasse, string kHausNr, string kPlz, string kOrt, string kHinweise, DateTime kGeburtsdatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(UpdateKandidatTbl, conn);
                cmd.Parameters.AddWithValue("@kId", kId);
                cmd.Parameters.AddWithValue("@kVorname", kVorname);
                cmd.Parameters.AddWithValue("@kNachname", kNachname);
                cmd.Parameters.AddWithValue("@kBenutzername", kBenutzername);
                cmd.Parameters.AddWithValue("@kPasswort", kPasswort);
                cmd.Parameters.AddWithValue("@kTel", kTel);
                //cmd.Parameters.AddWithValue("@kE_mail", kE_mail);
                cmd.Parameters.AddWithValue("@kStrasse", kStrasse);
                cmd.Parameters.AddWithValue("@kHausNr", kHausNr);
                cmd.Parameters.AddWithValue("@kPlz", kPlz);
                cmd.Parameters.AddWithValue("@kOrt", kOrt);
                cmd.Parameters.AddWithValue("@kHinweise", kHinweise);
                cmd.Parameters.AddWithValue("@kGeburtsdatum", kGeburtsdatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void ErgebnisEintragen(int FachId, int kandidatId, DateTime ergebnisDatum, DateTime ergebnisZeit, int ergebnisNoten, string ergebnisHinweise)
        {
            try
            {
                conn.Open();
                SqlCommand cmd_InsertIntoErgebnisTbl = new SqlCommand(InsertIntoErgebnisTbl, conn);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@FachId", FachId);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@kandidatId", kandidatId);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisDatum", ergebnisDatum);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisZeit", ergebnisZeit);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisNoten", ergebnisNoten);
                cmd_InsertIntoErgebnisTbl.Parameters.AddWithValue("@ergebnisHinweise", ergebnisHinweise);
                cmd_InsertIntoErgebnisTbl.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void FachEintragen(int fId, string fName, string fHinweise, int fBearbeitenAdmiId, DateTime fBearbeitendatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertIntoFachTbl, conn);
                cmd.Parameters.AddWithValue("@fId", fId);
                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@fHinweise", fHinweise);
                // cmd.Parameters.AddWithValue("@fBearbeitenAdmi", fBearbeitenAdmi);
                // cmd.Parameters.AddWithValue("@fBearbeitendatum", fBearbeitendatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void FachBearbeiten(int fId, string fName, string fHinweise, int fBearbeitenAdmiId, DateTime fBearbeitendatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(UpdateFachTbl, conn);
                cmd.Parameters.AddWithValue("@fId", fId);
                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@fHinweise", fHinweise);
                // cmd.Parameters.AddWithValue("@fBearbeitenAdmi", fBearbeitenAdmi);
                // cmd.Parameters.AddWithValue("@fBearbeitendatum", fBearbeitendatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        public void FrageEintragen(string frageBeschreibung, string frageWahl_1, string frageWahl_2, string frageWahl_3, string frageWahl_4, string frageAntwort, int fachId) //frageWahl_5  int fBearbeitenAdmiId, DateTime fBearbeitendatum,, string fHinweise
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(InsertIntoFrageTbl, conn);
                // cmd.Parameters.AddWithValue("@frageId", frageId);
                cmd.Parameters.AddWithValue("@frageBeschreibung", frageBeschreibung);
                cmd.Parameters.AddWithValue("@frageWahl_1", frageWahl_1);
                cmd.Parameters.AddWithValue("@frageWahl_2", frageWahl_2);
                cmd.Parameters.AddWithValue("@frageWahl_3", frageWahl_3);
                cmd.Parameters.AddWithValue("@frageWahl_4", frageWahl_4);
                //cmd.Parameters.AddWithValue("@frageWahl_5", frageWahl_5);
                cmd.Parameters.AddWithValue("@frageAntwort", frageAntwort);
                cmd.Parameters.AddWithValue("@fachId", fachId);
                // cmd.Parameters.AddWithValue("@fBearbeitenAdmi", fBearbeitenAdmiId);
                // cmd.Parameters.AddWithValue("@fBearbeitendatum", fBearbeitendatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void FrageBearbeiten(int frageId, string frageBeschreibung, string frageWahl_1, string frageWahl_2, string frageWahl_3, string frageWahl_4, string frageAntwort, int fBearbeitenAdmiId, DateTime fBearbeitendatum, string kOrt, string kHinweise, DateTime kGeburtsdatum)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(UpdateFrageTbl, conn);
                cmd.Parameters.AddWithValue("@frageId", frageId);
                cmd.Parameters.AddWithValue("@frageBeschreibung", frageBeschreibung);
                cmd.Parameters.AddWithValue("@frageWahl_1", frageWahl_1);
                cmd.Parameters.AddWithValue("@frageWahl_2", frageWahl_2);
                cmd.Parameters.AddWithValue("@frageWahl_3", frageWahl_3);
                cmd.Parameters.AddWithValue("@frageWahl_4", frageWahl_4);
                //cmd.Parameters.AddWithValue("@frageWahl_5", frageWahl_5);
                cmd.Parameters.AddWithValue("@frageAntwort", frageAntwort);
                // cmd.Parameters.AddWithValue("@fBearbeitenAdmi", fBearbeitenAdmiId);
                // cmd.Parameters.AddWithValue("@fBearbeitendatum", fBearbeitendatum);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        private void SaveHighest()
        {
            conn.Open();
            string selectMaxNoteOfKandidat = "Select Max(ErgebnisNoten) From ErgebnisTbl Where KandidatId = '" + 4 + "';";
            SqlDataAdapter sda = new SqlDataAdapter(selectMaxNoteOfKandidat, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();
        }
        private int CountQuestions()
        {
            int Qnum;
            conn.Open();
            //  string selectCountOfAll = "Select count(*) From FrageTbl Where fachId = '" + dt_faecher.Rows[cbo_Fach.SelectedIndex][0] + "';";
            SqlDataAdapter sda = new SqlDataAdapter("selectCountOfAll", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Qnum = Convert.ToInt32(dt.Rows[0][0]);
            conn.Close();
            return Qnum;
        }
    }
}
