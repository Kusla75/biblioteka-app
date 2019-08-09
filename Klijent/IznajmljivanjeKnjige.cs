using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.ServiceReference;
using System.ServiceModel;
using ClassLibrary;

namespace Klijent
{
    public partial class IznajmljivanjeKnjige : Form
    {
        static IServis proxy = new ServisClient();

        private void UpdateDataGridView()
        {
            DataSet dataSet = new DataSet();           
            dataSet = proxy.SviClanovi(); 

            Clanovi_dataGridView.DataSource = dataSet.Tables["SviClanovi"].DefaultView;
            Clanovi_dataGridView.Columns["ime"].DisplayIndex = 0;
            Clanovi_dataGridView.Columns["prezime"].DisplayIndex = 1;
            Clanovi_dataGridView.Columns["aktivan"].DisplayIndex = 2;
            Clanovi_dataGridView.Columns["email"].DisplayIndex = 3;
            Clanovi_dataGridView.Columns["datum_rodjenja"].DisplayIndex = 4;
            Clanovi_dataGridView.Columns["jmbg_clana"].DisplayIndex = 5;

            dataSet = proxy.SveKnjige();
            Knjige_dataGridView.DataSource = dataSet.Tables["SveKnjige"].DefaultView;
            Knjige_dataGridView.Columns["naziv_knjige"].DisplayIndex = 0;
            Knjige_dataGridView.Columns["kolicina_u_biblioteci"].DisplayIndex = 1;
            Knjige_dataGridView.Columns["jmbg_pisca"].Visible = false;
            Knjige_dataGridView.Columns["godina_izdavanja"].DisplayIndex = 2;
            Knjige_dataGridView.Columns["id_knjige"].DisplayIndex = 3;

            // Koristi se za uklanjanje redova gde je kolicina knjige jednaka nuli
            foreach (DataGridViewRow row in Knjige_dataGridView.Rows)
            {
                if (Convert.ToInt32(row.Cells["kolicina_u_biblioteci"].Value) == 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[Knjige_dataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();

                }
            }

            Clanovi_dataGridView.ClearSelection();
            Knjige_dataGridView.ClearSelection();
        }

        public IznajmljivanjeKnjige()
        {
            InitializeComponent();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IznajmljivanjeKnjige_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void IznajmiKnjigu_button_Click(object sender, EventArgs e)
        {
            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";

            string greskaString = "";
            int id_knjige = 0;
            Clan clan = new Clan();
            Knjiga knjiga = new Knjiga();

            if (Clanovi_dataGridView.SelectedRows.Count != 0)
            { 
                DataGridViewRow row_clanovi = new DataGridViewRow();
                row_clanovi = Clanovi_dataGridView.SelectedRows[0];

                if (Convert.ToInt32(row_clanovi.Cells["aktivan"].Value) == 1)
                {
                    clan.Ime = row_clanovi.Cells["ime"].Value.ToString();
                    clan.Prezime = row_clanovi.Cells["prezime"].Value.ToString();
                    clan.DatumRodjenja = Convert.ToDateTime(row_clanovi.Cells["datum_rodjenja"].Value);
                    clan.Jmbg = Convert.ToUInt64(row_clanovi.Cells["jmbg_clana"].Value);
                    clan.Aktivan = Convert.ToBoolean(row_clanovi.Cells["aktivan"].Value);
                }
                else
                {
                    greskaString += "Član koga ste izabrali nije aktivan. ";
                }
                
            }
            else
            {
                greskaString += "Niste izabrali člana. ";
            }
            
            if (Knjige_dataGridView.SelectedRows.Count != 0)
            {     
                DataGridViewRow row_knjige = new DataGridViewRow();
                row_knjige = Knjige_dataGridView.SelectedRows[0];
                knjiga.Naziv = row_knjige.Cells["naziv_knjige"].Value.ToString();
                knjiga.GodinaIzdavanja = Convert.ToUInt32(row_knjige.Cells["godina_izdavanja"].Value);
                id_knjige = Convert.ToInt32(row_knjige.Cells["id_knjige"].Value);            
            }
            else
            {
                greskaString += "Niste izabrali knjigu. ";
            }

            greska_label.Text = greskaString;
            if (greskaString == "")
            {
                if (proxy.IznajmiKnjigu(clan, knjiga, id_knjige))
                {
                    greska_label.ForeColor = Color.Green;
                    greska_label.Text = "Uspešno ste iznajmili knjigu. ";
                }
                else
                {
                    greska_label.ForeColor = Color.Red;
                    greska_label.Text = "Došlo je do greške pri iznajmljivanju knjige! ";
                }
            }

            UpdateDataGridView();

        }

    }
}
