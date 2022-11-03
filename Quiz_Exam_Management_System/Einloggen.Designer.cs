namespace Quiz_Exam_Management_System
{
    partial class Einloggen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_QMS = new System.Windows.Forms.Label();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.btn_Einloggen = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 469);
            this.panel1.TabIndex = 0;
            // 
            // lbl_QMS
            // 
            this.lbl_QMS.AutoSize = true;
            this.lbl_QMS.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QMS.Location = new System.Drawing.Point(340, 21);
            this.lbl_QMS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QMS.Name = "lbl_QMS";
            this.lbl_QMS.Size = new System.Drawing.Size(88, 43);
            this.lbl_QMS.TabIndex = 0;
            this.lbl_QMS.Text = "QMS";
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(234, 169);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(251, 29);
            this.txt_Benutzername.TabIndex = 1;
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Benutzername.Location = new System.Drawing.Point(229, 126);
            this.lbl_Benutzername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(141, 29);
            this.lbl_Benutzername.TabIndex = 0;
            this.lbl_Benutzername.Text = "Benutzername";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(234, 247);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(251, 29);
            this.txt_Passwort.TabIndex = 2;
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Passwort.Location = new System.Drawing.Point(229, 201);
            this.lbl_Passwort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(95, 29);
            this.lbl_Passwort.TabIndex = 0;
            this.lbl_Passwort.Text = "Passwort";
            // 
            // btn_Einloggen
            // 
            this.btn_Einloggen.BackColor = System.Drawing.Color.White;
            this.btn_Einloggen.Location = new System.Drawing.Point(307, 282);
            this.btn_Einloggen.Name = "btn_Einloggen";
            this.btn_Einloggen.Size = new System.Drawing.Size(131, 35);
            this.btn_Einloggen.TabIndex = 3;
            this.btn_Einloggen.Text = "Einloggen";
            this.btn_Einloggen.UseVisualStyleBackColor = false;
            this.btn_Einloggen.Click += new System.EventHandler(this.btn_Einloggen_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.BackColor = System.Drawing.Color.White;
            this.btn_Admin.Location = new System.Drawing.Point(307, 323);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(131, 35);
            this.btn_Admin.TabIndex = 4;
            this.btn_Admin.Text = "Admin";
            this.btn_Admin.UseVisualStyleBackColor = false;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_Exam_Management_System.Properties.Resources.preview;
            this.pictureBox1.Location = new System.Drawing.Point(537, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quiz Exam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Test your skills";
            // 
            // Einloggen
            // 
            this.AcceptButton = this.btn_Einloggen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_Einloggen);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.lbl_Benutzername);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.lbl_QMS);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Einloggen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Einloggen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_QMS;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Button btn_Einloggen;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}