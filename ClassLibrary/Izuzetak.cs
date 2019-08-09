using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ClassLibrary
{
    [DataContract]
    public class Izuzetak
    {
        string razlog;

        public Izuzetak()
        {
            razlog = "";
        }

        public Izuzetak(string r)
        {
            razlog = r;
        }

        [DataMember]
        public string Razlog
        {
            get { return razlog; }
            set { razlog = value; }
        }


    }
}
