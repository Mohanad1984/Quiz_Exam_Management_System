using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Fragen
    {
        public string FrageBeschreibung { get; set; }
        public string FrageWahl_1 { get; set; }
        public string FrageWahl_2 { get; set; }
        public string FrageWahl_3 { get; set; }
        public string FrageWahl_4 { get; set; }
        public int FrageAntwort { get; set; }
        public Faecher FachId { get; set; }
        public int AdmiId { get; set; }
        public DateTime EintragungsDatum { get; set; }

    }
}
