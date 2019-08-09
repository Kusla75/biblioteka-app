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
    public partial class RegistrovanjeClana : Form
    {
        static IServis proxy;

        public RegistrovanjeClana()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            proxy = new ServisClient();

            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";

            string greskaString = "";
            Clan novi_clan = new Clan();
            novi_clan.Aktivan = true;

            if (ime_textBox.Text != "")
            {
                for (int i = 0; i < ime_textBox.TextLength; ++i)
                {
                    int num = Convert.ToInt32(ime_textBox.Text[i]);
                    if (!Slovo.ProveriSlovo(num))
                    {
                        greskaString += "Ime nije dobro uneto. ";
                        break; 
                    }
                    else if (i + 1 == ime_textBox.TextLength)
                    {
                        novi_clan.Ime = ime_textBox.Text;
                    }
                }
            }
            else
            {
                greskaString += "Nije uneto ime. ";
            }

            if (prezime_textBox.Text != "")
            {
                for (int i = 0; i < prezime_textBox.TextLength; ++i)
                {
                    int num = Convert.ToInt32(prezime_textBox.Text[i]);
                    if (!Slovo.ProveriSlovo(num))
                    {
                        greskaString += "Prezime nije dobro uneto. ";
                        break;
                    }
                    else if (i + 1 == prezime_textBox.TextLength)
                    {
                        novi_clan.Prezime = prezime_textBox.Text;
                    }
                }
            }
            else
            {
                greskaString += "Nije uneto prezime. ";
            }

            novi_clan.DatumRodjenja = dateTimePicker.Value;

            if (jmbg_textBox.Text != "" && jmbg_textBox.TextLength == 13)
            {
                if (UInt64.TryParse(jmbg_textBox.Text, out ulong jmbg))
                {
                    novi_clan.Jmbg = jmbg;
                }
                else
                {
                    greskaString += "JMBG nije dobro unet. ";
                }
            }
            else
            {
                if (jmbg_textBox.Text == "")
                    greskaString += "Nije unet JMBG. ";
                else if (jmbg_textBox.TextLength != 13)
                    greskaString += "JMBG treba da sadrži 13 cifara. ";
            }

            if (email_textBox.Text != "")
            {
                if (email_textBox.Text.Contains("@") && email_textBox.Text.Contains(".com"))
                {
                    novi_clan.Email = email_textBox.Text;
                }
                else
                {
                    greskaString += "Email nije dobro unet. ";
                }
                
            }
            else
            {
                greskaString += "Email nije unet. ";
            }

            greska_label.Text = greskaString;
            if (greskaString == "")
            {
                try
                {
                    if (proxy.RegistovanjeClana(novi_clan))
                    {
                        greska_label.ForeColor = Color.Green;
                        greska_label.Text += "Član je uspešno registrovan u sistem!";
                    }
                    else
                    {
                        greska_label.ForeColor = Color.Red;
                        greska_label.Text += "Došlo je do greške pri registrovanju novog člana!";
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
            dateTimePicker.Value = new DateTime(2019, 5, 9);
            jmbg_textBox.Clear();
            email_textBox.Clear();
        }
    }
}
