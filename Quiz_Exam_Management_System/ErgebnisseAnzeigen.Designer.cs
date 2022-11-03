namespace Quiz_Exam_Management_System
{
    partial class ErgebnisseAnzeigen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Haupt = new System.Windows.Forms.Panel();
            this.cbo_Kandidat = new System.Windows.Forms.ComboBox();
            this.cbo_Fach = new System.Windows.Forms.ComboBox();
            this.dgv_Ergebnisse = new System.Windows.Forms.DataGridView();
            this.btn_Rest = new System.Windows.Forms.Button();
            this.btn_Bearbeiten = new System.Windows.Forms.Button();
            this.btn_Speicher = new System.Windows.Forms.Button();
            this.txt_Hinweise = new System.Windows.Forms.TextBox();
            this.txt_FachName = new System.Windows.Forms.TextBox();
            this.panel_Faecher = new System.Windows.Forms.Panel();
            this.lbl_Ergebnisse = new System.Windows.Forms.Label();
            this.lbl_Kandidaten = new System.Windows.Forms.Label();
            this.lbl_ErgebnisseAnzeigen = new System.Windows.Forms.Label();
            this.lbl_FachName = new System.Windows.Forms.Label();
            this.lbl_Faecher = new System.Windows.Forms.Label();
            this.lbl_Fragen = new System.Windows.Forms.Label();
            this.lbl_QuizPro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Ausloggen = new System.Windows.Forms.PictureBox();
            this.pictureBox_About = new System.Windows.Forms.PictureBox();
            this.pictureBox_Faecher = new System.Windows.Forms.PictureBox();
            this.pictureBox_Kandidaten = new System.Windows.Forms.PictureBox();
            this.pictureBox_Fragen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Haupt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ergebnisse)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ausloggen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Faecher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kandidaten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fragen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Haupt
            // 
            this.panel_Haupt.BackColor = System.Drawing.Color.Lavender;
            this.panel_Haupt.Controls.Add(this.cbo_Kandidat);
            this.panel_Haupt.Controls.Add(this.cbo_Fach);
            this.panel_Haupt.Controls.Add(this.dgv_Ergebnisse);
            this.panel_Haupt.Controls.Add(this.btn_Rest);
            this.panel_Haupt.Controls.Add(this.btn_Bearbeiten);
            this.panel_Haupt.Controls.Add(this.btn_Speicher);
            this.panel_Haupt.Controls.Add(this.txt_Hinweise);
            this.panel_Haupt.Controls.Add(this.txt_FachName);
            this.panel_Haupt.Controls.Add(this.panel_Faecher);
            this.panel_Haupt.Controls.Add(this.lbl_Ergebnisse);
            this.panel_Haupt.Controls.Add(this.lbl_Kandidaten);
            this.panel_Haupt.Controls.Add(this.lbl_ErgebnisseAnzeigen);
            this.panel_Haupt.Controls.Add(this.lbl_FachName);
            this.panel_Haupt.Controls.Add(this.lbl_Faecher);
            this.panel_Haupt.Controls.Add(this.lbl_Fragen);
            this.panel_Haupt.Controls.Add(this.lbl_QuizPro);
            this.panel_Haupt.Controls.Add(this.panel2);
            this.panel_Haupt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Haupt.Location = new System.Drawing.Point(8, 8);
            this.panel_Haupt.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel_Haupt.Name = "panel_Haupt";
            this.panel_Haupt.Size = new System.Drawing.Size(1789, 875);
            this.panel_Haupt.TabIndex = 3;
            // 
            // cbo_Kandidat
            // 
            this.cbo_Kandidat.BackColor = System.Drawing.Color.Khaki;
            this.cbo_Kandidat.FormattingEnabled = true;
            this.cbo_Kandidat.Location = new System.Drawing.Point(984, 358);
            this.cbo_Kandidat.Name = "cbo_Kandidat";
            this.cbo_Kandidat.Size = new System.Drawing.Size(307, 31);
            this.cbo_Kandidat.TabIndex = 8;
            this.cbo_Kandidat.Text = "Select Kanditat";
            this.cbo_Kandidat.SelectedIndexChanged += new System.EventHandler(this.cbo_Kandidat_SelectedIndexChanged);
            this.cbo_Kandidat.SelectionChangeCommitted += new System.EventHandler(this.cbo_Kandidat_SelectionChangeCommitted);
            // 
            // cbo_Fach
            // 
            this.cbo_Fach.BackColor = System.Drawing.Color.LightCoral;
            this.cbo_Fach.FormattingEnabled = true;
            this.cbo_Fach.Location = new System.Drawing.Point(671, 358);
            this.cbo_Fach.Name = "cbo_Fach";
            this.cbo_Fach.Size = new System.Drawing.Size(307, 31);
            this.cbo_Fach.TabIndex = 7;
            this.cbo_Fach.Text = "Select Fach";
            this.cbo_Fach.SelectedIndexChanged += new System.EventHandler(this.cbo_Fach_SelectedIndexChanged);
            this.cbo_Fach.SelectionChangeCommitted += new System.EventHandler(this.cbo_Fach_SelectionChangeCommitted);
            // 
            // dgv_Ergebnisse
            // 
            this.dgv_Ergebnisse.AllowUserToAddRows = false;
            this.dgv_Ergebnisse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dgv_Ergebnisse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Ergebnisse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Ergebnisse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ergebnisse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Ergebnisse.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_Ergebnisse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Ergebnisse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Ergebnisse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Ergebnisse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Ergebnisse.ColumnHeadersHeight = 28;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Ergebnisse.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Ergebnisse.Location = new System.Drawing.Point(10, 453);
            this.dgv_Ergebnisse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Ergebnisse.Name = "dgv_Ergebnisse";
            this.dgv_Ergebnisse.RowHeadersVisible = false;
            this.dgv_Ergebnisse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ergebnisse.Size = new System.Drawing.Size(1660, 415);
            this.dgv_Ergebnisse.TabIndex = 6;
            // 
            // btn_Rest
            // 
            this.btn_Rest.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Rest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Rest.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Rest.Location = new System.Drawing.Point(984, 273);
            this.btn_Rest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Rest.Name = "btn_Rest";
            this.btn_Rest.Size = new System.Drawing.Size(152, 57);
            this.btn_Rest.TabIndex = 5;
            this.btn_Rest.Text = "Rest";
            this.btn_Rest.UseVisualStyleBackColor = false;
            // 
            // btn_Bearbeiten
            // 
            this.btn_Bearbeiten.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Bearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Bearbeiten.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Bearbeiten.Location = new System.Drawing.Point(824, 273);
            this.btn_Bearbeiten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Bearbeiten.Name = "btn_Bearbeiten";
            this.btn_Bearbeiten.Size = new System.Drawing.Size(152, 57);
            this.btn_Bearbeiten.TabIndex = 5;
            this.btn_Bearbeiten.Text = "Bearbeiten";
            this.btn_Bearbeiten.UseVisualStyleBackColor = false;
            // 
            // btn_Speicher
            // 
            this.btn_Speicher.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Speicher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Speicher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Speicher.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Speicher.Location = new System.Drawing.Point(664, 273);
            this.btn_Speicher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Speicher.Name = "btn_Speicher";
            this.btn_Speicher.Size = new System.Drawing.Size(152, 57);
            this.btn_Speicher.TabIndex = 5;
            this.btn_Speicher.Text = "Speicher";
            this.btn_Speicher.UseVisualStyleBackColor = false;
            // 
            // txt_Hinweise
            // 
            this.txt_Hinweise.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_Hinweise.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Hinweise.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Hinweise.Location = new System.Drawing.Point(17, 198);
            this.txt_Hinweise.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_Hinweise.Multiline = true;
            this.txt_Hinweise.Name = "txt_Hinweise";
            this.txt_Hinweise.Size = new System.Drawing.Size(496, 191);
            this.txt_Hinweise.TabIndex = 3;
            this.txt_Hinweise.Text = "Hinweise";
            // 
            // txt_FachName
            // 
            this.txt_FachName.BackColor = System.Drawing.Color.Orchid;
            this.txt_FachName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FachName.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_FachName.Location = new System.Drawing.Point(715, 230);
            this.txt_FachName.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txt_FachName.Name = "txt_FachName";
            this.txt_FachName.Size = new System.Drawing.Size(496, 29);
            this.txt_FachName.TabIndex = 3;
            this.txt_FachName.Text = "Fach Name";
            // 
            // panel_Faecher
            // 
            this.panel_Faecher.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel_Faecher.Location = new System.Drawing.Point(1081, 55);
            this.panel_Faecher.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel_Faecher.Name = "panel_Faecher";
            this.panel_Faecher.Size = new System.Drawing.Size(133, 3);
            this.panel_Faecher.TabIndex = 2;
            // 
            // lbl_Ergebnisse
            // 
            this.lbl_Ergebnisse.AutoSize = true;
            this.lbl_Ergebnisse.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ergebnisse.Location = new System.Drawing.Point(1079, 17);
            this.lbl_Ergebnisse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Ergebnisse.Name = "lbl_Ergebnisse";
            this.lbl_Ergebnisse.Size = new System.Drawing.Size(142, 29);
            this.lbl_Ergebnisse.TabIndex = 0;
            this.lbl_Ergebnisse.Text = "Ergebnisse";
            // 
            // lbl_Kandidaten
            // 
            this.lbl_Kandidaten.AutoSize = true;
            this.lbl_Kandidaten.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kandidaten.Location = new System.Drawing.Point(884, 17);
            this.lbl_Kandidaten.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Kandidaten.Name = "lbl_Kandidaten";
            this.lbl_Kandidaten.Size = new System.Drawing.Size(112, 29);
            this.lbl_Kandidaten.TabIndex = 0;
            this.lbl_Kandidaten.Text = "Kandidaten";
            this.lbl_Kandidaten.Click += new System.EventHandler(this.lbl_Kandidaten_Click);
            // 
            // lbl_ErgebnisseAnzeigen
            // 
            this.lbl_ErgebnisseAnzeigen.AutoSize = true;
            this.lbl_ErgebnisseAnzeigen.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErgebnisseAnzeigen.Location = new System.Drawing.Point(731, 418);
            this.lbl_ErgebnisseAnzeigen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ErgebnisseAnzeigen.Name = "lbl_ErgebnisseAnzeigen";
            this.lbl_ErgebnisseAnzeigen.Size = new System.Drawing.Size(197, 29);
            this.lbl_ErgebnisseAnzeigen.TabIndex = 0;
            this.lbl_ErgebnisseAnzeigen.Text = "Ergebnisse anzeigen";
            // 
            // lbl_FachName
            // 
            this.lbl_FachName.AutoSize = true;
            this.lbl_FachName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FachName.Location = new System.Drawing.Point(589, 228);
            this.lbl_FachName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_FachName.Name = "lbl_FachName";
            this.lbl_FachName.Size = new System.Drawing.Size(114, 29);
            this.lbl_FachName.TabIndex = 0;
            this.lbl_FachName.Text = "Fach Name";
            // 
            // lbl_Faecher
            // 
            this.lbl_Faecher.AutoSize = true;
            this.lbl_Faecher.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Faecher.Location = new System.Drawing.Point(726, 17);
            this.lbl_Faecher.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Faecher.Name = "lbl_Faecher";
            this.lbl_Faecher.Size = new System.Drawing.Size(75, 29);
            this.lbl_Faecher.TabIndex = 0;
            this.lbl_Faecher.Text = "Fächer";
            this.lbl_Faecher.Click += new System.EventHandler(this.lbl_Faecher_Click);
            // 
            // lbl_Fragen
            // 
            this.lbl_Fragen.AutoSize = true;
            this.lbl_Fragen.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fragen.Location = new System.Drawing.Point(567, 17);
            this.lbl_Fragen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Fragen.Name = "lbl_Fragen";
            this.lbl_Fragen.Size = new System.Drawing.Size(76, 29);
            this.lbl_Fragen.TabIndex = 0;
            this.lbl_Fragen.Text = "Fragen";
            this.lbl_Fragen.Click += new System.EventHandler(this.lbl_Fragen_Click);
            // 
            // lbl_QuizPro
            // 
            this.lbl_QuizPro.AutoSize = true;
            this.lbl_QuizPro.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuizPro.Location = new System.Drawing.Point(12, 15);
            this.lbl_QuizPro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_QuizPro.Name = "lbl_QuizPro";
            this.lbl_QuizPro.Size = new System.Drawing.Size(105, 25);
            this.lbl_QuizPro.TabIndex = 0;
            this.lbl_QuizPro.Text = "QuizPro 1.0";
            this.lbl_QuizPro.DoubleClick += new System.EventHandler(this.lbl_QuizPro_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox_Ausloggen);
            this.panel2.Controls.Add(this.pictureBox_About);
            this.panel2.Controls.Add(this.pictureBox_Faecher);
            this.panel2.Controls.Add(this.pictureBox_Kandidaten);
            this.panel2.Controls.Add(this.pictureBox_Fragen);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Location = new System.Drawing.Point(1709, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 875);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox_Ausloggen
            // 
            this.pictureBox_Ausloggen.Image = global::Quiz_Exam_Management_System.Properties.Resources.Ausloggen;
            this.pictureBox_Ausloggen.Location = new System.Drawing.Point(15, 809);
            this.pictureBox_Ausloggen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Ausloggen.Name = "pictureBox_Ausloggen";
            this.pictureBox_Ausloggen.Size = new System.Drawing.Size(55, 48);
            this.pictureBox_Ausloggen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ausloggen.TabIndex = 7;
            this.pictureBox_Ausloggen.TabStop = false;
            this.pictureBox_Ausloggen.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox_About
            // 
            this.pictureBox_About.Image = global::Quiz_Exam_Management_System.Properties.Resources._2940539_200;
            this.pictureBox_About.Location = new System.Drawing.Point(15, 749);
            this.pictureBox_About.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_About.Name = "pictureBox_About";
            this.pictureBox_About.Size = new System.Drawing.Size(55, 48);
            this.pictureBox_About.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_About.TabIndex = 7;
            this.pictureBox_About.TabStop = false;
            this.pictureBox_About.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox_Faecher
            // 
            this.pictureBox_Faecher.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox_Faecher.Location = new System.Drawing.Point(15, 681);
            this.pictureBox_Faecher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Faecher.Name = "pictureBox_Faecher";
            this.pictureBox_Faecher.Size = new System.Drawing.Size(55, 48);
            this.pictureBox_Faecher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Faecher.TabIndex = 7;
            this.pictureBox_Faecher.TabStop = false;
            this.pictureBox_Faecher.Click += new System.EventHandler(this.pictureBox_Faecher_Click);
            // 
            // pictureBox_Kandidaten
            // 
            this.pictureBox_Kandidaten.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox_Kandidaten.Location = new System.Drawing.Point(9, 476);
            this.pictureBox_Kandidaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Kandidaten.Name = "pictureBox_Kandidaten";
            this.pictureBox_Kandidaten.Size = new System.Drawing.Size(55, 48);
            this.pictureBox_Kandidaten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Kandidaten.TabIndex = 7;
            this.pictureBox_Kandidaten.TabStop = false;
            this.pictureBox_Kandidaten.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox_Fragen
            // 
            this.pictureBox_Fragen.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox_Fragen.Location = new System.Drawing.Point(9, 418);
            this.pictureBox_Fragen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Fragen.Name = "pictureBox_Fragen";
            this.pictureBox_Fragen.Size = new System.Drawing.Size(55, 48);
            this.pictureBox_Fragen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Fragen.TabIndex = 7;
            this.pictureBox_Fragen.TabStop = false;
            this.pictureBox_Fragen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Exam_Management_System.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ErgebnisseAnzeigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1800, 875);
            this.Controls.Add(this.panel_Haupt);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ErgebnisseAnzeigen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErgebnisseAnzeigen";
            this.panel_Haupt.ResumeLayout(false);
            this.panel_Haupt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ergebnisse)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ausloggen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_About)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Faecher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kandidaten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fragen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Haupt;
        private System.Windows.Forms.DataGridView dgv_Ergebnisse;
        private System.Windows.Forms.Button btn_Rest;
        private System.Windows.Forms.Button btn_Bearbeiten;
        private System.Windows.Forms.Button btn_Speicher;
        private System.Windows.Forms.TextBox txt_Hinweise;
        private System.Windows.Forms.TextBox txt_FachName;
        private System.Windows.Forms.Panel panel_Faecher;
        private System.Windows.Forms.Label lbl_Kandidaten;
        private System.Windows.Forms.Label lbl_ErgebnisseAnzeigen;
        private System.Windows.Forms.Label lbl_FachName;
        private System.Windows.Forms.Label lbl_Faecher;
        private System.Windows.Forms.Label lbl_Fragen;
        private System.Windows.Forms.Label lbl_QuizPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_Ausloggen;
        private System.Windows.Forms.PictureBox pictureBox_About;
        private System.Windows.Forms.PictureBox pictureBox_Faecher;
        private System.Windows.Forms.PictureBox pictureBox_Kandidaten;
        private System.Windows.Forms.PictureBox pictureBox_Fragen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Ergebnisse;
        private System.Windows.Forms.ComboBox cbo_Kandidat;
        private System.Windows.Forms.ComboBox cbo_Fach;
    }
}