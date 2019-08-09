using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using ClassLibrary;

namespace Server
{
    [ServiceContract]
    interface IServis
    {
        //------------------------------------------------------------------------------------------------------//

        [OperationContract]
        bool LogovanjeKorisnika(string korisnickoIme, string sifra);

        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        bool RegistrovanjeKorisnika(string korisnickoIme, string lozinka);

        //------------------------------------------------------------------------------------------------------//

        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        bool RegistovanjeClana(Clan clan);

        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        bool RegistrovanjePisca(Pisac pisac);

        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        bool RegistrovanjeKnjige(Knjiga knjiga, uint kolicina);

        [OperationContract]
        bool IznajmiKnjigu(Clan clan, Knjiga knjiga, int id_knjige);

        [OperationContract]
        bool VratiKnjigu(int id_knjige, int id_iznajmljivanja);

        [OperationContract]
        DataSet IznajmljeneKnjigeClana(ulong jmbg_clana);

        //------------------------------------------------------------------------------------------------------//

        [OperationContract]
        bool IzmenaVrednostiTabele(string naziv_tabele, string naziv_kolone, string naziv_id_kolone, string id, string value_type, string vrednost);

        //------------------------------------------------------------------------------------------------------//

        [OperationContract]
        DataSet PretragaBazePodataka(string keyword, Dictionary<string, bool> izbori);

        [OperationContract]
        DataSet DetaljnaPretragaClana(string ime, string prezime, string email, DateTime datum_rodjenja);

        [OperationContract]
        DataSet DetaljnaPretragaKnjige(string naziv, int kolicina, int godina_izdavanja);

        [OperationContract]
        DataSet DetaljnaPretragaPisca(string ime, string prezime, DateTime datum_rodjenja);

        //------------------------------------------------------------------------------------------------------//

        [OperationContract]
        DataSet SviClanovi();

        [OperationContract]
        DataSet SviPisci();

        [OperationContract]
        DataSet SveKnjige();

        [OperationContract]
        DataSet SvaIznajmljivanja();

    }
}
