using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Pisac
    {
        ulong jmbg;
        string ime;
        string prezime;
        DateTime datumRodjenja;

        public Pisac()
        {
            jmbg = 0;
            ime = "";
            prezime = "";
            datumRodjenja = new DateTime(1970, 1, 1);
        }

        public Pisac(ulong j, string i, string p, DateTime dr)
        {
            jmbg = j;
            ime = i;
            prezime = p;
            datumRodjenja = dr;
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

    }
}
