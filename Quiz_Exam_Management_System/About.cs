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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox_Faecher_Click(object sender, EventArgs e)
        {
            ErgebnisseAnzeigen ein = new ErgebnisseAnzeigen();
            ein.Show();
            this.Close();
        }
    }
}
