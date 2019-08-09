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

namespace Klijent
{
    public partial class Login : Form
    {
        static IServis proxy = new ServisClient();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                greska_label.Text = "";

                if (proxy.LogovanjeKorisnika(korisnickoIme_textBox.Text, lozinka_textBox.Text))
                {
                    GlavnaForma glavnaForma = new GlavnaForma();

                    this.Hide();
                    korisnickoIme_textBox.Clear();
                    lozinka_textBox.Clear();
                    greska_label.Text = "";

                    glavnaForma.ShowDialog();
                    this.Show();
                }
                else
                {
                    greska_label.Text = "Došlo je do greške pri registrovanju!\n" +
                        "Korisničko ime ili lozinka nisu dobro uneti.";
                    korisnickoIme_textBox.Clear();
                    lozinka_textBox.Clear();
                }

                /*GlavnaForma f = new GlavnaForma();
                this.Hide();
                f.ShowDialog();
                this.Show();*/
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("           Došlo je do greške.\n  Veza sa serverom je prekinuta!", "Greška");
            }
        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            korisnickoIme_textBox.Clear();
            lozinka_textBox.Clear();
            greska_label.Text = "";

            Signup signUpForma = new Signup();
            signUpForma.ShowDialog();
            this.Show();                
        }
    }
}
