using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Data;
using ClassLibrary;

namespace Server
{
    public class Servis : IServis
    {
        string konekcijaString = "Data Source = DESKTOP-5KJCUBS\\SQLEXPRESS;" +
            "Initial Catalog = Biblioteka; Integrated Security = SSPI";

        //-----                   Registrovanje i logovanje korisnika                    -----//

        public bool LogovanjeKorisnika(string korisnickoIme, string lozinka)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaProvere = new SqlCommand(
                    "SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = @korisnicoIme AND lozinka = @lozinka", konekcija);

                komandaProvere.Parameters.AddWithValue("@korisnicoIme", korisnickoIme);
                komandaProvere.Parameters.AddWithValue("@lozinka", lozinka);

                int brojRedova = (int)komandaProvere.ExecuteScalar();

                if (brojRedova == 1) { return true; }
                else { return false; }
            }         
        }

        public bool RegistrovanjeKorisnika(string korisnickoIme, string lozinka)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaProvere = new SqlCommand(
                    "SELECT COUNT(*) FROM korisnik WHERE korisnicko_ime = @korisnickoIme", konekcija);

                komandaProvere.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);

                int num = (int)komandaProvere.ExecuteScalar();

                if (num == 0)
                {
                    SqlCommand komandaRegistrovanja = new SqlCommand(
                        "INSERT INTO korisnik VALUES (@korisnickoIme, @lozinka)", konekcija);

                    komandaRegistrovanja.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                    komandaRegistrovanja.Parameters.AddWithValue("@lozinka", lozinka);

                    num = komandaRegistrovanja.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }
                }
                else
                {
                    Izuzetak izuzetak = new Izuzetak("Korisnik sa unetim korisničkim imenom već postoji! ");
                    throw new FaultException<Izuzetak>(izuzetak);
                }
            }
        }

        //-----                          GlavnaForma funkcije                           -----//

        public bool RegistovanjeClana(Clan clan)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaProvereJmbg = new SqlCommand("SELECT COUNT(*) FROM clan WHERE " +
                    "jmbg_clana = @jmbg_clana", konekcija);

                komandaProvereJmbg.Parameters.AddWithValue("@jmbg_clana", Convert.ToString(clan.Jmbg));

                int num = (int)komandaProvereJmbg.ExecuteScalar();
            
                if (num == 0)
                {
                    SqlCommand komanda = new SqlCommand("INSERT INTO clan VALUES (@jmbg, @ime, " +
                        "@prezime, @email, @datum_rodjenja, @aktivan)", konekcija);

                    komanda.Parameters.AddWithValue("@jmbg", Convert.ToString(clan.Jmbg));
                    komanda.Parameters.AddWithValue("@ime", clan.Ime);
                    komanda.Parameters.AddWithValue("@prezime", clan.Prezime);
                    komanda.Parameters.AddWithValue("@email", clan.Email);
                    komanda.Parameters.AddWithValue("@datum_rodjenja", clan.DatumRodjenja);
                    komanda.Parameters.AddWithValue("@aktivan", Convert.ToByte(clan.Aktivan));

                    num = komanda.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }            
                }
                else
                {
                    Izuzetak izuzetak = new Izuzetak("JMBG člana već postoji u sistemu! ");
                    throw new FaultException<Izuzetak>(izuzetak);
                }
            }
        }

        public bool RegistrovanjePisca(Pisac pisac)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaJmbg = new SqlCommand("SELECT COUNT(*) FROM pisac WHERE jmbg_pisca = @jmbg", konekcija);
                komandaJmbg.Parameters.AddWithValue("@jmbg", Convert.ToString(pisac.Jmbg));

                int num = (int)komandaJmbg.ExecuteScalar();

                if (num == 0)
                {
                    SqlCommand komandaRegistrovanja = new SqlCommand("INSERT INTO pisac VALUES (@jmbg, @ime, " +
                    "@prezime, @datum_rodjenja)", konekcija);

                    komandaRegistrovanja.Parameters.AddWithValue("@jmbg", Convert.ToString(pisac.Jmbg));
                    komandaRegistrovanja.Parameters.AddWithValue("@ime", pisac.Ime);
                    komandaRegistrovanja.Parameters.AddWithValue("@prezime", pisac.Prezime);
                    komandaRegistrovanja.Parameters.AddWithValue("@datum_rodjenja", pisac.DatumRodjenja);

                    num = komandaRegistrovanja.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }
                }
                else
                {
                    Izuzetak izuzetak = new Izuzetak("JMBG pisca već postoji u sistemu! ");
                    throw new FaultException<Izuzetak>(izuzetak);
                }

            }
        }

        public bool RegistrovanjeKnjige(Knjiga knjiga, uint kolicina)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komIdKnjige = new SqlCommand("SELECT id_knjige FROM knjiga WHERE " +
                            "naziv_knjige = @naziv AND godina_izdavanja = @god_izdavanja", konekcija);

                komIdKnjige.Parameters.AddWithValue("@naziv", knjiga.Naziv);
                komIdKnjige.Parameters.AddWithValue("@god_izdavanja", Convert.ToInt32(knjiga.GodinaIzdavanja));

                if (komIdKnjige.ExecuteScalar() == null)
                {
                    SqlCommand komRegistrovanjaKnjige = new SqlCommand("INSERT INTO knjiga VALUES " +
                    "(@naziv, @kolicina, @jmbg_pisca, @god_izdavanja)", konekcija);

                    komRegistrovanjaKnjige.Parameters.AddWithValue("@naziv", knjiga.Naziv);
                    komRegistrovanjaKnjige.Parameters.AddWithValue("@kolicina", Convert.ToInt32(kolicina));
                    komRegistrovanjaKnjige.Parameters.AddWithValue("@jmbg_pisca", Convert.ToString(knjiga.Pisac.Jmbg));
                    komRegistrovanjaKnjige.Parameters.AddWithValue("@god_izdavanja", Convert.ToInt32(knjiga.GodinaIzdavanja));

                    int num = komRegistrovanjaKnjige.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }
                }
                else
                {
                    Izuzetak izuzetak = new Izuzetak("Knjiga već postoji u sisetmu!");
                    throw new FaultException<Izuzetak>(izuzetak);
                }
               
            }
        }

        public bool IznajmiKnjigu(Clan clan, Knjiga knjiga, int id_knjige)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaAzuriranja = new SqlCommand("UPDATE knjiga SET kolicina_u_biblioteci = " +
                    "kolicina_u_biblioteci - 1 WHERE id_knjige = @id", konekcija);

                komandaAzuriranja.Parameters.AddWithValue("@id", id_knjige);

                int num = komandaAzuriranja.ExecuteNonQuery();

                if (num == 1)
                {
                    DateTime datum = DateTime.Now;
                    SqlCommand komandaIznajmljivanja = new SqlCommand("INSERT INTO iznajmio VALUES (@jmbg_clana, " +
                        "@id_knjige, @datum_izdavanja, @datum_vracana, @vracena)", konekcija);

                    komandaIznajmljivanja.Parameters.AddWithValue("@jmbg_clana", Convert.ToString(clan.Jmbg));
                    komandaIznajmljivanja.Parameters.AddWithValue("@id_knjige", id_knjige);
                    komandaIznajmljivanja.Parameters.AddWithValue("@datum_izdavanja", datum);
                    komandaIznajmljivanja.Parameters.AddWithValue("@datum_vracana", datum.AddDays(14)); 
                    komandaIznajmljivanja.Parameters.AddWithValue("@vracena", Convert.ToByte(false));

                    num = komandaIznajmljivanja.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }
                }
                else { return false; }

            }
        }

        public bool VratiKnjigu(int id_knjige, int id_iznajmljivanja)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaAzuriranjaKnjige = new SqlCommand("UPDATE knjiga SET kolicina_u_biblioteci = " +
                    "kolicina_u_biblioteci + 1 WHERE id_knjige = @id", konekcija);

                komandaAzuriranjaKnjige.Parameters.AddWithValue("@id", id_knjige);

                int num = komandaAzuriranjaKnjige.ExecuteNonQuery();

                if (num == 1)
                {
                    SqlCommand komandaAzuriranjaIznajmio = new SqlCommand("UPDATE iznajmio SET datum_vracanja = @datum, " +
                        "vracena = 1 WHERE id_iznajmljivanja = @id", konekcija);

                    komandaAzuriranjaIznajmio.Parameters.AddWithValue("@datum", DateTime.Now);
                    komandaAzuriranjaIznajmio.Parameters.AddWithValue("@id", id_iznajmljivanja);

                    num = komandaAzuriranjaIznajmio.ExecuteNonQuery();

                    if (num == 1) { return true; }
                    else { return false; }

                }
                else { return false; }

            }
        }

        public DataSet IznajmljeneKnjigeClana(ulong jmbg_clana)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaIznajmljenjihKnjigaClana = new SqlCommand("SELECT i.id_iznajmljivanja, k.naziv_knjige, " +
                    "k.id_knjige, i.datum_izdavanja, i.datum_vracanja FROM " +
                    "knjiga k, iznajmio i WHERE i.jmbg_clana = @jmbg AND i.id_knjige = k.id_knjige AND vracena = 0", konekcija);

                komandaIznajmljenjihKnjigaClana.Parameters.AddWithValue("@jmbg", Convert.ToString(jmbg_clana));

                SqlDataAdapter dataAdapter = new SqlDataAdapter(komandaIznajmljenjihKnjigaClana);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "IznajmljenjeKnjige");

                return dataSet;
            }
        }

        public DataSet PretragaBazePodataka(string keyword, Dictionary<string, bool> izbori)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                string pretragaClanova = "SELECT ime, prezime, datum_rodjenja, jmbg_clana, email FROM clan WHERE " +
                    "jmbg_clana LIKE @search OR ime LIKE @search OR prezime LIKE @search OR " +
                    "email LIKE @search OR datum_rodjenja LIKE @search";

                string pretragaKnjiga = "SELECT naziv_knjige, kolicina_u_biblioteci, godina_izdavanja, jmbg_pisca FROM knjiga WHERE " +
                    "naziv_knjige LIKE @search OR kolicina_u_biblioteci LIKE @search OR " +
                    "jmbg_pisca LIKE @search OR godina_izdavanja LIKE @search";

                string pretragaPisaca = "SELECT ime, prezime, datum_rodjenja, jmbg_pisca FROM pisac WHERE " +
                    "jmbg_pisca LIKE @search OR ime LIKE @search OR " +
                    "prezime LIKE @search OR datum_rodjenja LIKE @search";
                
                DataTable rezultatPretrage = new DataTable("RezultatPretrage");

                SqlCommand komandaClanova = new SqlCommand(pretragaClanova, konekcija);
                komandaClanova.Parameters.AddWithValue("@search", "%" + keyword + "%");

                SqlCommand komandaKnjiga = new SqlCommand(pretragaKnjiga, konekcija);
                komandaKnjiga.Parameters.AddWithValue("@search", "%" + keyword + "%");

                SqlCommand komandaPisaca = new SqlCommand(pretragaPisaca, konekcija);
                komandaPisaca.Parameters.AddWithValue("@search", "%" + keyword + "%");

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                if (izbori["Clan"] && izbori["Knjiga"] && izbori["Pisac"])
                {
                    dataAdapter.SelectCommand = komandaClanova;
                    dataAdapter.Fill(rezultatPretrage);

                    dataAdapter.SelectCommand = komandaKnjiga;
                    dataAdapter.Fill(rezultatPretrage);

                    dataAdapter.SelectCommand = komandaPisaca;
                    dataAdapter.Fill(rezultatPretrage);

                    dataSet.Tables.Add(rezultatPretrage);

                    return dataSet;
                }
                else
                {
                    if (izbori["Clan"])
                    {
                        dataAdapter.SelectCommand = komandaClanova;
                        dataAdapter.Fill(rezultatPretrage);
                    }
                    if (izbori["Knjiga"])
                    {
                        dataAdapter.SelectCommand = komandaKnjiga;
                        dataAdapter.Fill(rezultatPretrage);
                    }
                    if (izbori["Pisac"])
                    {
                        dataAdapter.SelectCommand = komandaPisaca;
                        dataAdapter.Fill(rezultatPretrage);
                    }

                    dataSet.Tables.Add(rezultatPretrage);

                    return dataSet;
                }

            }
        }

        //-----                             Izmena tabela                              -----//

        public bool IzmenaVrednostiTabele(string naziv_tabele, string naziv_kolone, string naziv_id_kolone, string id, string value_type, string vrednost)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komanda = new SqlCommand("UPDATE " + naziv_tabele + " SET " + naziv_kolone + " = @vrednost WHERE " +
                    naziv_id_kolone + " = @id", konekcija);

                if (naziv_tabele == "clan" || naziv_tabele == "pisac")
                {
                    komanda.Parameters.AddWithValue("@id", Convert.ToString(id));
                }
                else
                {
                    komanda.Parameters.AddWithValue("@id", id);
                }

                if (value_type == "System.Int32")
                {
                    komanda.Parameters.AddWithValue("@vrednost", Convert.ToInt32(vrednost));
                }
                else if (value_type == "System.DateTime")
                {
                    komanda.Parameters.AddWithValue("@vrednost", Convert.ToDateTime(vrednost));
                }
                else
                {
                    komanda.Parameters.AddWithValue("@vrednost", vrednost);
                }

                int num = komanda.ExecuteNonQuery();

                if (num == 1) { return true; }
                else { return false; }

            }
        }

        //-----                             Detaljna pretraga                          -----//

        public DataSet DetaljnaPretragaClana(string ime, string prezime, string email, DateTime datum_rodjenja)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaPretrage = new SqlCommand("SELECT * FROM clan WHERE datum_rodjenja = @datum ", konekcija);
                komandaPretrage.Parameters.AddWithValue("@datum", datum_rodjenja);

                if (ime != "")
                {
                    komandaPretrage.CommandText += "OR ime = @ime ";
                    komandaPretrage.Parameters.AddWithValue("@ime", ime);
                }
                if (prezime != "")
                {
                    komandaPretrage.CommandText += "OR prezime = @prezime ";
                    komandaPretrage.Parameters.AddWithValue("@prezime", prezime);
                }
                if (email != "")
                {
                    komandaPretrage.CommandText += "OR email = @email ";
                    komandaPretrage.Parameters.AddWithValue("@email", email);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(komandaPretrage);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "RezultatPretrage");

                return dataSet;
            }
        }

        public DataSet DetaljnaPretragaKnjige(string naziv, int kolicina, int godina_izdavanja)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaPretrage = new SqlCommand("SELECT * FROM knjiga WHERE 1 = 2 ", konekcija);

                if (naziv != "")
                {
                    komandaPretrage.CommandText += "OR naziv_knjige = @naziv ";
                    komandaPretrage.Parameters.AddWithValue("@naziv", naziv);
                }
                if (kolicina != 0)
                {
                    komandaPretrage.CommandText += "OR kolicina_u_biblioteci = @kolicina ";
                    komandaPretrage.Parameters.AddWithValue("@kolicina", kolicina);
                }
                if (godina_izdavanja != 0)
                {
                    komandaPretrage.CommandText += "OR godina_izdavanja = @godina ";
                    komandaPretrage.Parameters.AddWithValue("@godina", godina_izdavanja);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(komandaPretrage);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "RezultatPretrage");

                return dataSet;
            }
        }

        public DataSet DetaljnaPretragaPisca(string ime, string prezime, DateTime datum_rodjenja)
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                SqlCommand komandaPretrage = new SqlCommand("SELECT * FROM pisac WHERE datum_rodjenja = @datum ", konekcija);
                komandaPretrage.Parameters.AddWithValue("@datum", datum_rodjenja);

                if (ime != "")
                {
                    komandaPretrage.CommandText += "OR ime = @ime ";
                    komandaPretrage.Parameters.AddWithValue("@ime", ime);
                }
                if (prezime != "")
                {
                    komandaPretrage.CommandText += "OR prezime = @prezime ";
                    komandaPretrage.Parameters.AddWithValue("@prezime", prezime);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(komandaPretrage);
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "RezultatPretrage");

                return dataSet;
            }
        }

        //-----                             Dataset funkcije                           -----//

        public DataSet SviClanovi()
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                string selectKomandaSve = "SELECT * FROM clan";

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectKomandaSve, konekcija);
                dataAdapter.Fill(dataSet, "SviClanovi");

                return dataSet;
            }
        }

        public DataSet SviPisci()
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                string selectKomandaSve = "SELECT * FROM pisac";

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectKomandaSve, konekcija);
                dataAdapter.Fill(dataSet, "SviPisci");

                return dataSet;
            }
        }

        public DataSet SveKnjige()
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                string selectKomandaSve = "SELECT * FROM knjiga";

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectKomandaSve, konekcija);
                dataAdapter.Fill(dataSet, "SveKnjige");

                return dataSet;
            }
        }

        public DataSet SvaIznajmljivanja()
        {
            using (SqlConnection konekcija = new SqlConnection(konekcijaString))
            {
                konekcija.Open();

                string selectKomandaSve = "SELECT * FROM iznajmio";

                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectKomandaSve, konekcija);
                dataAdapter.Fill(dataSet, "SvaIznajmljivanja");

                return dataSet;
            }
        }

    }
}
