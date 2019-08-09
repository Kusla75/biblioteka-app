using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Knjiga
    {
        string naziv;
        Pisac pisac;
        uint godinaIzdavanja;

        public Knjiga()
        {
            naziv = "";
            pisac = new Pisac();
            godinaIzdavanja = 1970;
        }

        public Knjiga(string n, Pisac p, uint god)
        {
            naziv = n;
            pisac = new Pisac(p.Jmbg, p.Ime, p.Prezime, p.DatumRodjenja);
            godinaIzdavanja = god;
        }

        [DataMember]
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        [DataMember]
        public Pisac Pisac
        {
            get { return pisac; }
            set { pisac = value; }
        }

        [DataMember]
        public uint GodinaIzdavanja
        {
            get { return godinaIzdavanja; }
            set { godinaIzdavanja = value; }
        }

    }
}
