namespace Quiz_Exam_Management_System
{
    partial class Spritzen
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Kandidaten = new System.Windows.Forms.Label();
            this.progressBar_Spritzen = new System.Windows.Forms.ProgressBar();
            this.timer_progressBar_Spritzen = new System.Windows.Forms.Timer(this.components);
            this.lbl_loading = new System.Windows.Forms.Label();
            this.lbl_prozent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quiz_Exam_Management_System.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(291, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 176);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Kandidaten
            // 
            this.lbl_Kandidaten.AutoSize = true;
            this.lbl_Kandidaten.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kandidaten.Location = new System.Drawing.Point(215, 9);
            this.lbl_Kandidaten.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Kandidaten.Name = "lbl_Kandidaten";
            this.lbl_Kandidaten.Size = new System.Drawing.Size(370, 42);
            this.lbl_Kandidaten.TabIndex = 9;
            this.lbl_Kandidaten.Text = "Exam Management System";
            // 
            // progressBar_Spritzen
            // 
            this.progressBar_Spritzen.Location = new System.Drawing.Point(12, 415);
            this.progressBar_Spritzen.Name = "progressBar_Spritzen";
            this.progressBar_Spritzen.Size = new System.Drawing.Size(776, 23);
            this.progressBar_Spritzen.TabIndex = 10;
            // 
            // timer_progressBar_Spritzen
            // 
            this.timer_progressBar_Spritzen.Tick += new System.EventHandler(this.timer_progressBar_Spritzen_Tick);
            // 
            // lbl_loading
            // 
            this.lbl_loading.AutoSize = true;
            this.lbl_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loading.Location = new System.Drawing.Point(330, 373);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.Size = new System.Drawing.Size(82, 25);
            this.lbl_loading.TabIndex = 11;
            this.lbl_loading.Text = "loading";
            // 
            // lbl_prozent
            // 
            this.lbl_prozent.AutoSize = true;
            this.lbl_prozent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prozent.Location = new System.Drawing.Point(440, 373);
            this.lbl_prozent.Name = "lbl_prozent";
            this.lbl_prozent.Size = new System.Drawing.Size(31, 25);
            this.lbl_prozent.TabIndex = 11;
            this.lbl_prozent.Text = "%";
            // 
            // Spritzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_prozent);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.progressBar_Spritzen);
            this.Controls.Add(this.lbl_Kandidaten);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spritzen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spritzen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Kandidaten;
        private System.Windows.Forms.ProgressBar progressBar_Spritzen;
        private System.Windows.Forms.Timer timer_progressBar_Spritzen;
        private System.Windows.Forms.Label lbl_loading;
        private System.Windows.Forms.Label lbl_prozent;
    }
}