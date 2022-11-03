namespace Quiz_Exam_Management_System
{
    partial class About
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ergebnisse = new System.Windows.Forms.Label();
            this.lbl_QuizPro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Faecher = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Faecher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Ergebnisse);
            this.panel1.Controls.Add(this.lbl_QuizPro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 241);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(209, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 3);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "About";
            // 
            // lbl_Ergebnisse
            // 
            this.lbl_Ergebnisse.AutoSize = true;
            this.lbl_Ergebnisse.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ergebnisse.Location = new System.Drawing.Point(109, 141);
            this.lbl_Ergebnisse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Ergebnisse.Name = "lbl_Ergebnisse";
            this.lbl_Ergebnisse.Size = new System.Drawing.Size(314, 29);
            this.lbl_Ergebnisse.TabIndex = 3;
            this.lbl_Ergebnisse.Text = "Developped By Mohanad Altahhan";
            // 
            // lbl_QuizPro
            // 
            this.lbl_QuizPro.AutoSize = true;
            this.lbl_QuizPro.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuizPro.Location = new System.Drawing.Point(6, 9);
            this.lbl_QuizPro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_QuizPro.Name = "lbl_QuizPro";
            this.lbl_QuizPro.Size = new System.Drawing.Size(105, 25);
            this.lbl_QuizPro.TabIndex = 1;
            this.lbl_QuizPro.Text = "QuizPro 1.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.pictureBox_Faecher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(506, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(44, 241);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox_Faecher
            // 
            this.pictureBox_Faecher.Image = global::Quiz_Exam_Management_System.Properties.Resources.return_icon_png_3;
            this.pictureBox_Faecher.Location = new System.Drawing.Point(4, 202);
            this.pictureBox_Faecher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Faecher.Name = "pictureBox_Faecher";
            this.pictureBox_Faecher.Size = new System.Drawing.Size(36, 34);
            this.pictureBox_Faecher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Faecher.TabIndex = 8;
            this.pictureBox_Faecher.TabStop = false;
            this.pictureBox_Faecher.Click += new System.EventHandler(this.pictureBox_Faecher_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 241);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Faecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_QuizPro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ergebnisse;
        private System.Windows.Forms.PictureBox pictureBox_Faecher;
    }
}