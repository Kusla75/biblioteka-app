using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Clan
    {
        ulong jmbg;
        string ime;
        string prezime;
        DateTime datumRodjenja;
        string email;
        bool aktivan;

        public Clan()
        {
            jmbg = 0;
            ime = "";
            prezime = "";
            datumRodjenja = new DateTime(1970, 1, 1);
            email = "";
            aktivan = false;
        }

        public Clan(ulong j, string i, string p, DateTime dr, string e, bool a)
        {
            jmbg = j;
            ime = i;
            prezime = p;
            datumRodjenja = dr;
            email = e;
            aktivan = a;
        }

        [DataMember]
        public ulong Jmbg
        {
            get { return jmbg; }
            set { jmbg = value; }
        }

        [DataMember]
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        [DataMember]
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        [DataMember]
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [DataMember]
        public bool Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

    }
}
