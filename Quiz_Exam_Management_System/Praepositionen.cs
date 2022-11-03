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
    public partial class Praepositionen : Form
    {
        public Praepositionen()
        {
            InitializeComponent();
           
            chek_Bis.BackColor = Color.FromArgb(230, 226, 243);
            chek_Durch.BackColor = Color.FromArgb(230, 226, 243);
            chek_Für.BackColor = Color.FromArgb(230, 226, 243);
            chek_Ohne.BackColor = Color.FromArgb(230, 226, 243);
            chek_Gegen.BackColor = Color.FromArgb(230, 226, 243);
            chek_Um.BackColor = Color.FromArgb(230, 226, 243);
            lbl_Akku.BackColor = Color.FromArgb(230, 226, 243);
           
           // groupBox_Akkusativ.BackColor = Color.FromArgb(230, 226, 243);
           chek_Ab.BackColor = Color.FromArgb(255, 170, 198);
           chek_Aus.BackColor = Color.FromArgb(255, 170, 198);
           chek_Ausser.BackColor = Color.FromArgb(255, 170, 198);
           chek_Bei.BackColor = Color.FromArgb(255, 170, 198);
           chek_Gegenueber.BackColor = Color.FromArgb(255, 170, 198);
           chek_Gegenueber.BackColor = Color.FromArgb(255, 170, 198);
           chek_Mit.BackColor = Color.FromArgb(255, 170, 198);
           chek_Nach.BackColor = Color.FromArgb(255, 170, 198);
           chek_Von.BackColor = Color.FromArgb(255, 170, 198);
           chek_Seit.BackColor = Color.FromArgb(255, 170, 198);
           chek_Zu.BackColor = Color.FromArgb(255, 170, 198);
           lbl_Dativ.BackColor = Color.FromArgb(255, 170, 198);

           chek_An.BackColor = Color.FromArgb(255, 213, 226);
           chek_Auf.BackColor = Color.FromArgb(255, 213, 226);
           chek_In.BackColor = Color.FromArgb(255, 213, 226);
           chek_Hinter.BackColor = Color.FromArgb(255, 213, 226);
           chek_Neben.BackColor = Color.FromArgb(255, 213, 226);
           chek_Unter.BackColor = Color.FromArgb(255, 213, 226);
           chek_Ueber.BackColor = Color.FromArgb(255, 213, 226);
           chek_Vor.BackColor = Color.FromArgb(255, 213, 226);
           chek_Zwischen.BackColor = Color.FromArgb(255, 213, 226);
        }
    }
}
