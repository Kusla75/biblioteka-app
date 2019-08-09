using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Klijent.ServiceReference;
using ClassLibrary;

namespace Klijent
{
    public partial class RegistrovanjeKnjige : Form
    {
        static IServis proxy = new ServisClient();
        static Dictionary<string, Pisac> listaPisaca = new Dictionary<string, Pisac>();

        private void AzuriranjeComboboxa()
        {
            listaPisaca.Clear();
            pisac_comboBox.Items.Clear();

            DataSet pisci_dataSet = new DataSet();
            pisci_dataSet = proxy.SviPisci();
            string pisacImePrezime = "";

            foreach (DataRow row in pisci_dataSet.Tables["SviPisci"].Rows)
            {
                ulong jmbg = Convert.ToUInt64(row["jmbg_pisca"]);
                string ime = row["ime"].ToString();
                string prezime = row["prezime"].ToString();
                DateTime datumRodjenja = Convert.ToDateTime(row["datum_rodjenja"]);

                pisacImePrezime = row["ime"] + " " + row["prezime"];
                pisac_comboBox.Items.Add(pisacImePrezime);
                listaPisaca.Add(pisacImePrezime, new Pisac(jmbg, ime, prezime, datumRodjenja));
            }
        }

        public RegistrovanjeKnjige()
        {
            InitializeComponent();
        }

        private void RegistrovanjeKnjige_Load(object sender, EventArgs e)
        {
            AzuriranjeComboboxa();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrujKnjigu_button_Click(object sender, EventArgs e)
        {
            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";

            uint kolicina = 0;
            string greskaString = "";
            Knjiga nova_knjiga = new Knjiga();

            if (nazivKnjige_textBox.Text != "")
            {
                for (int i = 0; i < nazivKnjige_textBox.TextLength; ++i)
                {
                    int num = Convert.ToInt32(nazivKnjige_textBox.Text[i]);
                    if ( !(Slovo.ProveriSlovo(num) || num == 32) )  
                    {
                        greskaString += "Naziv knjige nije dobro uneto. ";
                        break;
                    }
                    else if (i + 1 == nazivKnjige_textBox.TextLength)
                    {
                        nova_knjiga.Naziv = nazivKnjige_textBox.Text;
                    }
                }
            }
            else
            {
                greskaString += "Nije unet naziv knjige. ";
            }

            if (godIzdavanja_textBox.Text != "")
            {
                if (uint.TryParse(godIzdavanja_textBox.Text, out uint godIzdavanja))
                {
                    if (godIzdavanja < 2100 && godIzdavanja > 1500)
                    {
                        nova_knjiga.GodinaIzdavanja = godIzdavanja;
                    }
                    else
                    {
                        greskaString += "Godina izdavanja mora da bude između 1500. i 2100. godine. ";
                    }
                }
                else
                {
                    greskaString += "Godina izdavanja nije dobro uneta. ";
                }
            }
            else
            {
                greskaString += "Nije uneta godina izdavanja. ";
            }

            if (kolicina_textBox.Text != "")
            {
                if (uint.TryParse(kolicina_textBox.Text, out kolicina) && kolicina != 0)
                {
                    if (kolicina > 15)
                    {
                        greskaString += "Možete dodati najviše 15 knjiga. ";
                    }
                }
                else
                {
                    greskaString += "Kolicina knjiga može piti samo ceo pozitivan broj. ";
                }
            }
            else
            {
                greskaString += "Količina knjige nije uneta. ";
            }

            if (pisac_comboBox.SelectedItem != null)
            {
                string izabraniPisac = pisac_comboBox.SelectedItem.ToString();
                nova_knjiga.Pisac = listaPisaca[izabraniPisac];
            }
            else
            {
                greskaString += "Pisac nije izabran. ";
            }

            greska_label.Text = greskaString;
            if(greskaString == "")
            {
                try
                {
                    if (proxy.RegistrovanjeKnjige(nova_knjiga, kolicina))
                    {
                        greska_label.ForeColor = Color.Green;
                        greska_label.Text += "Knjiga je uspešno registrovan u sistem!";
                    }
                    else
                    {
                        greska_label.ForeColor = Color.Red;
                        greska_label.Text += "Došlo je do greške pri registrovanju nove knjige!";
                    }

                }
                catch(FaultException<Izuzetak> izuzetak)
                {
                    greska_label.ForeColor = Color.Blue;
                    greska_label.Text += izuzetak.Detail.Razlog;
                }
            }

            nazivKnjige_textBox.Clear();
            godIzdavanja_textBox.Clear();
            kolicina_textBox.Clear();
            pisac_comboBox.SelectedItem = null;
        }

        private void RegistrujPisca_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            RegistrovanjePisca pisacForma = new RegistrovanjePisca();
            pisacForma.ShowDialog();
            AzuriranjeComboboxa();
            pisac_comboBox.SelectedItem = null;
            this.Enabled = true;
        }

        
    }
}
