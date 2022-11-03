using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Ergebnis
    {
        public int UserId { get; set; }
        public DateTime ErgebnisDatum { get; set; }
        public int ErgebnisZeit { get; set; }
        public int ErgebnisNoten { get; set; }
        public int ErgebnisHinweise { get; set; }
    }
}
