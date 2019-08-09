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
using ClassLibrary;
using Klijent.ServiceReference;

namespace Klijent
{
    public partial class Signup : Form
    {
        static IServis proxy = new ServisClient();

        public Signup()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";

            string greskaString = "";

            if (korisnickoIme_textBox.Text != "")
            {
                if (korisnickoIme_textBox.TextLength < 5)
                {
                    greskaString += "Korisničko ime mora da sadrži barem 5 znakova. ";
                }
                else
                {
                    for (int i = 0; i < korisnickoIme_textBox.TextLength; ++i)
                    {
                        int num = Convert.ToInt32(korisnickoIme_textBox.Text[i]);
                        if (!Slovo.ProveriSlovo(num))
                        {
                            greskaString += "Korisničko ime treba da sadrži samo slova i brojeve. ";
                            break;
                        }
                    }
                }              
            }
            else
            {
                greskaString += "Niste uneli korisničko ime. ";
            }

            if (lozinka_textBox.Text != "")
            {
                if (lozinka_textBox.TextLength < 5 || lozinka_textBox.TextLength > 20)
                {
                    greskaString += "Lozinka mora da sadrži između 5 i 20 znakova. ";
                }
            }
            else
            {
                greskaString += "Niste uneli lozinku. ";
            }

            if (lozinkaPotvrda_textBox.Text != lozinka_textBox.Text)
            {
                greskaString += "Lozinke se ne poklapaju. ";
            }

            greska_label.Text = greskaString;
            if (greskaString == "")
            {
                try
                {
                    if (proxy.RegistrovanjeKorisnika(korisnickoIme_textBox.Text, lozinka_textBox.Text))
                    {
                        greska_label.ForeColor = Color.Green;
                        greska_label.Text = "Uspešno ste registrovani u sistem! ";
                    }
                    else
                    {
                        greska_label.ForeColor = Color.Red;
                        greska_label.Text = "Došlo je do greške pri registrovanju! ";
                    }
                }
                catch (FaultException<Izuzetak> izuzetak)
                {
                    greska_label.ForeColor = Color.Blue;
                    greska_label.Text += izuzetak.Detail.Razlog;
                }

            }

            korisnickoIme_textBox.Clear();
            lozinka_textBox.Clear();
            lozinkaPotvrda_textBox.Clear();
        }
        
    }
}
