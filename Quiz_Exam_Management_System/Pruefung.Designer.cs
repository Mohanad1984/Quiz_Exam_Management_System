namespace Quiz_Exam_Management_System
{
    partial class Pruefung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Haupt = new System.Windows.Forms.Panel();
            this.lbl_RichtigeAntwort = new System.Windows.Forms.Label();
            this.lbl_GesamtFragen = new System.Windows.Forms.Label();
            this.txt_GesamtFragen = new System.Windows.Forms.TextBox();
            this.txt_RichtigeAntwort = new System.Windows.Forms.TextBox();
            this.radioBtn_Auswahl_5 = new System.Windows.Forms.RadioButton();
            this.pic_Hinweis = new System.Windows.Forms.PictureBox();
            this.dateTimeP_PruefungZeit = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.progressBarFrageZeit = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbo_Fach = new System.Windows.Forms.ComboBox();
            this.panel_Zeit = new System.Windows.Forms.Panel();
            this.lbl_Zeit = new System.Windows.Forms.Label();
            this.grb_Fragen = new System.Windows.Forms.GroupBox();
            this.radioBtn_Auswahl_4 = new System.Windows.Forms.RadioButton();
            this.radioBtn_Auswahl_3 = new System.Windows.Forms.RadioButton();
            this.radioBtn_Auswahl_2 = new System.Windows.Forms.RadioButton();
            this.radioBtn_Auswahl_1 = new System.Windows.Forms.RadioButton();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Einreichen = new System.Windows.Forms.Button();
            this.panel_Kandidaten = new System.Windows.Forms.Panel();
            this.lbl_KandidatName = new System.Windows.Forms.Label();
            this.lbl_Kandidaten = new System.Windows.Forms.Label();
            this.lbl_Fach = new System.Windows.Forms.Label();
            this.lbl_QuizPro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerFrageZeit = new System.Windows.Forms.Timer(this.components);
            this.TimerCheck = new System.Windows.Forms.Timer(this.components);
            this.richTxt_Frage = new System.Windows.Forms.RichTextBox();
            this.panel_Haupt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinweis)).BeginInit();
            this.panel_Zeit.SuspendLayout();
            this.grb_Fragen.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Haupt
            // 
            this.panel_Haupt.BackColor = System.Drawing.Color.BurlyWood;
            this.panel_Haupt.Controls.Add(this.richTxt_Frage);
            this.panel_Haupt.Controls.Add(this.lbl_RichtigeAntwort);
            this.panel_Haupt.Controls.Add(this.lbl_GesamtFragen);
            this.panel_Haupt.Controls.Add(this.txt_GesamtFragen);
            this.panel_Haupt.Controls.Add(this.txt_RichtigeAntwort);
            this.panel_Haupt.Controls.Add(this.radioBtn_Auswahl_5);
            this.panel_Haupt.Controls.Add(this.pic_Hinweis);
            this.panel_Haupt.Controls.Add(this.dateTimeP_PruefungZeit);
            this.panel_Haupt.Controls.Add(this.dateTimePicker1);
            this.panel_Haupt.Controls.Add(this.progressBarFrageZeit);
            this.panel_Haupt.Controls.Add(this.textBox2);
            this.panel_Haupt.Controls.Add(this.textBox1);
            this.panel_Haupt.Controls.Add(this.cbo_Fach);
            this.panel_Haupt.Controls.Add(this.panel_Zeit);
            this.panel_Haupt.Controls.Add(this.grb_Fragen);
            this.panel_Haupt.Controls.Add(this.btn_next);
            this.panel_Haupt.Controls.Add(this.btn_Einreichen);
            this.panel_Haupt.Controls.Add(this.panel_Kandidaten);
            this.panel_Haupt.Controls.Add(this.lbl_KandidatName);
            this.panel_Haupt.Controls.Add(this.lbl_Kandidaten);
            this.panel_Haupt.Controls.Add(this.lbl_Fach);
            this.panel_Haupt.Controls.Add(this.lbl_QuizPro);
            this.panel_Haupt.Controls.Add(this.panel2);
            this.panel_Haupt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Haupt.Location = new System.Drawing.Point(3, 1);
            this.panel_Haupt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Haupt.Name = "panel_Haupt";
            this.panel_Haupt.Size = new System.Drawing.Size(1800, 875);
            this.panel_Haupt.TabIndex = 2;
            // 
            // lbl_RichtigeAntwort
            // 
            this.lbl_RichtigeAntwort.AutoSize = true;
            this.lbl_RichtigeAntwort.Location = new System.Drawing.Point(1487, 166);
            this.lbl_RichtigeAntwort.Name = "lbl_RichtigeAntwort";
            this.lbl_RichtigeAntwort.Size = new System.Drawing.Size(119, 23);
            this.lbl_RichtigeAntwort.TabIndex = 18;
            this.lbl_RichtigeAntwort.Text = "Richtige Antwort";
            // 
            // lbl_GesamtFragen
            // 
            this.lbl_GesamtFragen.AutoSize = true;
            this.lbl_GesamtFragen.Location = new System.Drawing.Point(1487, 111);
            this.lbl_GesamtFragen.Name = "lbl_GesamtFragen";
            this.lbl_GesamtFragen.Size = new System.Drawing.Size(115, 23);
            this.lbl_GesamtFragen.TabIndex = 17;
            this.lbl_GesamtFragen.Text = "GesamtFragen";
            // 
            // txt_GesamtFragen
            // 
            this.txt_GesamtFragen.Enabled = false;
            this.txt_GesamtFragen.Location = new System.Drawing.Point(1612, 108);
            this.txt_GesamtFragen.Name = "txt_GesamtFragen";
            this.txt_GesamtFragen.Size = new System.Drawing.Size(100, 29);
            this.txt_GesamtFragen.TabIndex = 16;
            // 
            // txt_RichtigeAntwort
            // 
            this.txt_RichtigeAntwort.Enabled = false;
            this.txt_RichtigeAntwort.Location = new System.Drawing.Point(1612, 166);
            this.txt_RichtigeAntwort.Name = "txt_RichtigeAntwort";
            this.txt_RichtigeAntwort.Size = new System.Drawing.Size(100, 29);
            this.txt_RichtigeAntwort.TabIndex = 15;
            // 
            // radioBtn_Auswahl_5
            // 
            this.radioBtn_Auswahl_5.BackColor = System.Drawing.Color.Chocolate;
            this.radioBtn_Auswahl_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_Auswahl_5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Auswahl_5.Location = new System.Drawing.Point(238, 790);
            this.radioBtn_Auswahl_5.Name = "radioBtn_Auswahl_5";
            this.radioBtn_Auswahl_5.Size = new System.Drawing.Size(161, 19);
            this.radioBtn_Auswahl_5.TabIndex = 4;
            this.radioBtn_Auswahl_5.TabStop = true;
            this.radioBtn_Auswahl_5.Text = "Auswahl 5";
            this.radioBtn_Auswahl_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtn_Auswahl_5.UseVisualStyleBackColor = false;
            this.radioBtn_Auswahl_5.Visible = false;
            this.radioBtn_Auswahl_5.CheckedChanged += new System.EventHandler(this.radioBtn_Auswahl_5_CheckedChanged);
            // 
            // pic_Hinweis
            // 
            this.pic_Hinweis.Location = new System.Drawing.Point(1620, 312);
            this.pic_Hinweis.Name = "pic_Hinweis";
            this.pic_Hinweis.Size = new System.Drawing.Size(75, 60);
            this.pic_Hinweis.TabIndex = 13;
            this.pic_Hinweis.TabStop = false;
            // 
            // dateTimeP_PruefungZeit
            // 
            this.dateTimeP_PruefungZeit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeP_PruefungZeit.Location = new System.Drawing.Point(1512, 68);
            this.dateTimeP_PruefungZeit.Name = "dateTimeP_PruefungZeit";
            this.dateTimeP_PruefungZeit.Size = new System.Drawing.Size(200, 29);
            this.dateTimeP_PruefungZeit.TabIndex = 12;
            this.dateTimeP_PruefungZeit.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1512, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // progressBarFrageZeit
            // 
            this.progressBarFrageZeit.Location = new System.Drawing.Point(555, 786);
            this.progressBarFrageZeit.Name = "progressBarFrageZeit";
            this.progressBarFrageZeit.Size = new System.Drawing.Size(393, 23);
            this.progressBarFrageZeit.TabIndex = 10;
            this.progressBarFrageZeit.Value = 100;
            this.progressBarFrageZeit.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1619, 378);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 102);
            this.textBox2.TabIndex = 9;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1619, 486);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 185);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // cbo_Fach
            // 
            this.cbo_Fach.FormattingEnabled = true;
            this.cbo_Fach.ItemHeight = 23;
            this.cbo_Fach.Location = new System.Drawing.Point(66, 15);
            this.cbo_Fach.Name = "cbo_Fach";
            this.cbo_Fach.Size = new System.Drawing.Size(168, 31);
            this.cbo_Fach.TabIndex = 8;
            this.cbo_Fach.SelectedIndexChanged += new System.EventHandler(this.cbo_Fach_SelectedIndexChanged);
            // 
            // panel_Zeit
            // 
            this.panel_Zeit.Controls.Add(this.lbl_Zeit);
            this.panel_Zeit.Location = new System.Drawing.Point(1612, 205);
            this.panel_Zeit.Name = "panel_Zeit";
            this.panel_Zeit.Size = new System.Drawing.Size(83, 79);
            this.panel_Zeit.TabIndex = 7;
            // 
            // lbl_Zeit
            // 
            this.lbl_Zeit.AutoSize = true;
            this.lbl_Zeit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Zeit.Location = new System.Drawing.Point(-5, 13);
            this.lbl_Zeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Zeit.Name = "lbl_Zeit";
            this.lbl_Zeit.Size = new System.Drawing.Size(45, 29);
            this.lbl_Zeit.TabIndex = 0;
            this.lbl_Zeit.Text = "Zeit";
            // 
            // grb_Fragen
            // 
            this.grb_Fragen.Controls.Add(this.radioBtn_Auswahl_4);
            this.grb_Fragen.Controls.Add(this.radioBtn_Auswahl_3);
            this.grb_Fragen.Controls.Add(this.radioBtn_Auswahl_2);
            this.grb_Fragen.Controls.Add(this.radioBtn_Auswahl_1);
            this.grb_Fragen.Location = new System.Drawing.Point(11, 269);
            this.grb_Fragen.Name = "grb_Fragen";
            this.grb_Fragen.Size = new System.Drawing.Size(1432, 494);
            this.grb_Fragen.TabIndex = 6;
            this.grb_Fragen.TabStop = false;
            this.grb_Fragen.Text = "Fragen";
            // 
            // radioBtn_Auswahl_4
            // 
            this.radioBtn_Auswahl_4.BackColor = System.Drawing.Color.DarkOrange;
            this.radioBtn_Auswahl_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_Auswahl_4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Auswahl_4.Location = new System.Drawing.Point(6, 373);
            this.radioBtn_Auswahl_4.Name = "radioBtn_Auswahl_4";
            this.radioBtn_Auswahl_4.Size = new System.Drawing.Size(1420, 109);
            this.radioBtn_Auswahl_4.TabIndex = 3;
            this.radioBtn_Auswahl_4.TabStop = true;
            this.radioBtn_Auswahl_4.Text = "Auswahl 4";
            this.radioBtn_Auswahl_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtn_Auswahl_4.UseVisualStyleBackColor = false;
            this.radioBtn_Auswahl_4.Visible = false;
            this.radioBtn_Auswahl_4.CheckedChanged += new System.EventHandler(this.radioBtn_Auswahl_4_CheckedChanged);
            // 
            // radioBtn_Auswahl_3
            // 
            this.radioBtn_Auswahl_3.BackColor = System.Drawing.Color.SandyBrown;
            this.radioBtn_Auswahl_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_Auswahl_3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Auswahl_3.Location = new System.Drawing.Point(6, 258);
            this.radioBtn_Auswahl_3.Name = "radioBtn_Auswahl_3";
            this.radioBtn_Auswahl_3.Size = new System.Drawing.Size(1420, 109);
            this.radioBtn_Auswahl_3.TabIndex = 2;
            this.radioBtn_Auswahl_3.TabStop = true;
            this.radioBtn_Auswahl_3.Text = "Auswahl 3";
            this.radioBtn_Auswahl_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtn_Auswahl_3.UseVisualStyleBackColor = false;
            this.radioBtn_Auswahl_3.Visible = false;
            this.radioBtn_Auswahl_3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioBtn_Auswahl_2
            // 
            this.radioBtn_Auswahl_2.BackColor = System.Drawing.Color.LightSalmon;
            this.radioBtn_Auswahl_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_Auswahl_2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Auswahl_2.Location = new System.Drawing.Point(6, 143);
            this.radioBtn_Auswahl_2.Name = "radioBtn_Auswahl_2";
            this.radioBtn_Auswahl_2.Size = new System.Drawing.Size(1420, 109);
            this.radioBtn_Auswahl_2.TabIndex = 1;
            this.radioBtn_Auswahl_2.TabStop = true;
            this.radioBtn_Auswahl_2.Text = "Auswahl 2";
            this.radioBtn_Auswahl_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtn_Auswahl_2.UseVisualStyleBackColor = false;
            this.radioBtn_Auswahl_2.Visible = false;
            this.radioBtn_Auswahl_2.CheckedChanged += new System.EventHandler(this.radioBtn_Auswahl_2_CheckedChanged);
            // 
            // radioBtn_Auswahl_1
            // 
            this.radioBtn_Auswahl_1.BackColor = System.Drawing.Color.DarkSalmon;
            this.radioBtn_Auswahl_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtn_Auswahl_1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn_Auswahl_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBtn_Auswahl_1.Location = new System.Drawing.Point(6, 28);
            this.radioBtn_Auswahl_1.Name = "radioBtn_Auswahl_1";
            this.radioBtn_Auswahl_1.Size = new System.Drawing.Size(1420, 109);
            this.radioBtn_Auswahl_1.TabIndex = 0;
            this.radioBtn_Auswahl_1.TabStop = true;
            this.radioBtn_Auswahl_1.Text = "Auswahl 1";
            this.radioBtn_Auswahl_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBtn_Auswahl_1.UseVisualStyleBackColor = false;
            this.radioBtn_Auswahl_1.Visible = false;
            this.radioBtn_Auswahl_1.CheckedChanged += new System.EventHandler(this.radioBtn_Auswahl_1_CheckedChanged);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Enabled = false;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_next.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_next.Location = new System.Drawing.Point(11, 815);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(1432, 48);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Nächste";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Einreichen
            // 
            this.btn_Einreichen.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Einreichen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Einreichen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Einreichen.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Einreichen.Location = new System.Drawing.Point(240, 15);
            this.btn_Einreichen.Name = "btn_Einreichen";
            this.btn_Einreichen.Size = new System.Drawing.Size(101, 32);
            this.btn_Einreichen.TabIndex = 5;
            this.btn_Einreichen.Text = "Start";
            this.btn_Einreichen.UseVisualStyleBackColor = false;
            this.btn_Einreichen.Click += new System.EventHandler(this.btn_Einreichen_Click);
            // 
            // panel_Kandidaten
            // 
            this.panel_Kandidaten.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel_Kandidaten.Location = new System.Drawing.Point(725, 68);
            this.panel_Kandidaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Kandidaten.Name = "panel_Kandidaten";
            this.panel_Kandidaten.Size = new System.Drawing.Size(400, 3);
            this.panel_Kandidaten.TabIndex = 2;
            // 
            // lbl_KandidatName
            // 
            this.lbl_KandidatName.AutoSize = true;
            this.lbl_KandidatName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KandidatName.Location = new System.Drawing.Point(934, 17);
            this.lbl_KandidatName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KandidatName.Name = "lbl_KandidatName";
            this.lbl_KandidatName.Size = new System.Drawing.Size(112, 29);
            this.lbl_KandidatName.TabIndex = 0;
            this.lbl_KandidatName.Text = "Kandidaten";
            // 
            // lbl_Kandidaten
            // 
            this.lbl_Kandidaten.AutoSize = true;
            this.lbl_Kandidaten.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kandidaten.Location = new System.Drawing.Point(754, 17);
            this.lbl_Kandidaten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Kandidaten.Name = "lbl_Kandidaten";
            this.lbl_Kandidaten.Size = new System.Drawing.Size(100, 29);
            this.lbl_Kandidaten.TabIndex = 0;
            this.lbl_Kandidaten.Text = "Kandidat: ";
            this.lbl_Kandidaten.DoubleClick += new System.EventHandler(this.lbl_Kandidaten_DoubleClick);
            // 
            // lbl_Fach
            // 
            this.lbl_Fach.AutoSize = true;
            this.lbl_Fach.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fach.Location = new System.Drawing.Point(7, 17);
            this.lbl_Fach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fach.Name = "lbl_Fach";
            this.lbl_Fach.Size = new System.Drawing.Size(52, 25);
            this.lbl_Fach.TabIndex = 0;
            this.lbl_Fach.Text = "Fach";
            // 
            // lbl_QuizPro
            // 
            this.lbl_QuizPro.AutoSize = true;
            this.lbl_QuizPro.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuizPro.Location = new System.Drawing.Point(1607, 8);
            this.lbl_QuizPro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QuizPro.Name = "lbl_QuizPro";
            this.lbl_QuizPro.Size = new System.Drawing.Size(105, 25);
            this.lbl_QuizPro.TabIndex = 0;
            this.lbl_QuizPro.Text = "QuizPro 1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(1720, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 875);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Quiz_Exam_Management_System.Properties.Resources.Ausloggen1;
            this.pictureBox6.Location = new System.Drawing.Point(12, 705);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Quiz_Exam_Management_System.Properties.Resources._2940539_200;
            this.pictureBox5.Location = new System.Drawing.Point(12, 649);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox4.Location = new System.Drawing.Point(3, 344);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox3.Location = new System.Drawing.Point(4, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(4, 236);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Exam_Management_System.Properties.Resources.preview1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerFrageZeit
            // 
            this.timerFrageZeit.Interval = 1000;
            this.timerFrageZeit.Tick += new System.EventHandler(this.timerFrageZeit_Tick);
            // 
            // TimerCheck
            // 
            this.TimerCheck.Interval = 1000;
            this.TimerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // richTxt_Frage
            // 
            this.richTxt_Frage.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxt_Frage.Location = new System.Drawing.Point(11, 84);
            this.richTxt_Frage.Name = "richTxt_Frage";
            this.richTxt_Frage.ReadOnly = true;
            this.richTxt_Frage.Size = new System.Drawing.Size(1432, 186);
            this.richTxt_Frage.TabIndex = 19;
            this.richTxt_Frage.Text = "";
            // 
            // Pruefung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 890);
            this.Controls.Add(this.panel_Haupt);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pruefung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prüfung";
            this.panel_Haupt.ResumeLayout(false);
            this.panel_Haupt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinweis)).EndInit();
            this.panel_Zeit.ResumeLayout(false);
            this.panel_Zeit.PerformLayout();
            this.grb_Fragen.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Haupt;
        private System.Windows.Forms.Button btn_Einreichen;
        private System.Windows.Forms.Panel panel_Kandidaten;
        private System.Windows.Forms.Label lbl_Kandidaten;
        private System.Windows.Forms.Label lbl_QuizPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grb_Fragen;
        private System.Windows.Forms.RadioButton radioBtn_Auswahl_4;
        private System.Windows.Forms.RadioButton radioBtn_Auswahl_3;
        private System.Windows.Forms.RadioButton radioBtn_Auswahl_2;
        private System.Windows.Forms.RadioButton radioBtn_Auswahl_1;
        private System.Windows.Forms.Panel panel_Zeit;
        private System.Windows.Forms.Label lbl_Zeit;
        private System.Windows.Forms.Label lbl_Fach;
        private System.Windows.Forms.ComboBox cbo_Fach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBarFrageZeit;
        private System.Windows.Forms.Timer timerFrageZeit;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Timer TimerCheck;
        private System.Windows.Forms.Label lbl_KandidatName;
        private System.Windows.Forms.DateTimePicker dateTimeP_PruefungZeit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioBtn_Auswahl_5;
        private System.Windows.Forms.PictureBox pic_Hinweis;
        private System.Windows.Forms.Label lbl_RichtigeAntwort;
        private System.Windows.Forms.Label lbl_GesamtFragen;
        private System.Windows.Forms.TextBox txt_GesamtFragen;
        private System.Windows.Forms.TextBox txt_RichtigeAntwort;
        private System.Windows.Forms.RichTextBox richTxt_Frage;
    }
}