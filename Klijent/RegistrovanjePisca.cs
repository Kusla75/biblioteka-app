using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.ServiceModel;
using Klijent.ServiceReference;

namespace Klijent
{
    public partial class RegistrovanjePisca : Form
    {
        static IServis proxy = new ServisClient();

        public RegistrovanjePisca()
        {
            InitializeComponent();
        }

        private void RegistrujPisca_Click(object sender, EventArgs e)
        {
            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";
            string greskaString = "";
            Pisac novi_pisac = new Pisac();

            if (ime_textBox.Text != "")
            {
                for (int i = 0; i < ime_textBox.TextLength; ++i)
                {
                    int num = Convert.ToInt32(ime_textBox.Text[i]);
                    if (!Slovo.ProveriSlovo(num))
                    {
                        greskaString += "Ime pisca nije dobro uneto. ";
                        break;
                    }
                    else if (i + 1 == ime_textBox.TextLength)
                    {
                        novi_pisac.Ime = ime_textBox.Text;
                    }
                }
            }
            else
            {
                greskaString += "Nije uneto ime pisca. ";
            }

            if (prezime_textBox.Text != "")
            {
                for (int i = 0; i < prezime_textBox.TextLength; ++i)
                {
                    int num = Convert.ToInt32(prezime_textBox.Text[i]);
                    if (!Slovo.ProveriSlovo(num))
                    {
                        greskaString += "Prezime pisca nije dobro uneto. ";
                        break;
                    }
                    else if (i + 1 == prezime_textBox.TextLength)
                    {
                        novi_pisac.Prezime = prezime_textBox.Text;
                    }
                }
            }
            else
            {
                greskaString += "Nije uneto prezime pisca. ";
            }

            if (jmbg_textBox.Text != "" && jmbg_textBox.TextLength == 13)
            {
                if (UInt64.TryParse(jmbg_textBox.Text, out ulong jmbg))
                {
                    novi_pisac.Jmbg = jmbg;
                }
                else
                {
                    greskaString += "JMBG pisca nije dobro unet. ";
                }
            }
            else
            {
                if (jmbg_textBox.Text == "")
                    greskaString += "Nije unet JMBG pisca. ";
                else if (jmbg_textBox.TextLength != 13)
                    greskaString += "JMBG pisca treba da sadrži 13 cifara. ";
            }

            novi_pisac.DatumRodjenja = datumRodjenja_dateTimePicker.Value;

            greska_label.Text = greskaString;
            if (greskaString == "")
            {
                try
                { 
                    if (proxy.RegistrovanjePisca(novi_pisac))
                    {
                        greska_label.ForeColor = Color.Green;
                        greska_label.Text = "Uspešno ste registrovali pisca u sistem. ";

                    }
                    else
                    {
                        greska_label.ForeColor = Color.Red;
                        greska_label.Text = "Došlo je do greške pri registrovanju pisca. ";
                    }
                }
                catch (FaultException<Izuzetak> izuzetak)
                {
                    greska_label.ForeColor = Color.Blue;
                    greska_label.Text += izuzetak.Detail.Razlog;
                }
            }

            ime_textBox.Clear();
            prezime_textBox.Clear();
            jmbg_textBox.Clear();
            datumRodjenja_dateTimePicker.Value = new DateTime(2019, 5, 9);

        }



    }
}
