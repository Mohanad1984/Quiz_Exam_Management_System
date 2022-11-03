using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Exam_Management_System
{
    public partial class Spritzen : Form
    {
        public Spritzen()
        {
            InitializeComponent();
            timer_progressBar_Spritzen.Start();
        }
        int count = 0; 
        private void timer_progressBar_Spritzen_Tick(object sender, EventArgs e)
        {
            count += 1;
            progressBar_Spritzen.Value = count;
            lbl_prozent.Text = count + " %";
            if(progressBar_Spritzen.Value == 100)
            {
                progressBar_Spritzen.Value = 0;
                timer_progressBar_Spritzen.Stop();
                Einloggen log = new Einloggen();
                log.Show();
                this.Hide();
            }
        }
    }
}
