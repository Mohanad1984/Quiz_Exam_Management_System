using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User : BaseDataEntity
    {
        public string userVorname { get; set; }
        public string userNachname { get; set; }
        public string userBenutzername { get; set; }
        public string userPasswort { get; set; }
        public string userTelefonnummer { get; set; }
        public string userStrasse { get; set; }
        public string userHausNr { get; set; }
        public string userPlz { get; set; }
        public string userOrt { get; set; }
        public DateTime userGeburtsdatum { get; set; }
        public string userTyp { get; set; }
    }
}
