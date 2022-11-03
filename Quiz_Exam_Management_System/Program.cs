using System;
using System.Windows.Forms;


namespace Quiz_Exam_Management_System
{
    static public class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Einloggen());
            //Application.Run(new Pruefung());
            // Application.Run(new ErgebnisseAnzeigen());
            Application.Run(new Fragen());
            //Application.Run(new Spritzen());
            //Application.Run(new Praepositionen());
        }
    }
}
