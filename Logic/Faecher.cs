using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Faecher
    {
        public int FachId { get; set; }
        public string fachName { get; set; }
        public string fachHinweise { get; set; }
        public User AdmiId { get; set; }
        public int fBearbeitenAdmiId { get; set; }
        public DateTime fEintragungsdatum { get; set; }
        public DateTime fBearbeitendatum { get; set; }

    }
}
