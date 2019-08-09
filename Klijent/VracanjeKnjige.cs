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
    public partial class VracanjeKnjige : Form
    {
        static IServis proxy = new ServisClient();

        public VracanjeKnjige()
        {
            InitializeComponent();
        }

        private void UpdateKnjigeDataGridView()
        {
            DataSet dataSet = new DataSet();
            ulong jmbg_clana = Convert.ToUInt64(Clanovi_dataGridView.SelectedRows[0].Cells["jmbg_clana"].Value);
            dataSet = proxy.IznajmljeneKnjigeClana(jmbg_clana);

            Knjige_dataGridView.DataSource = dataSet.Tables["IznajmljenjeKnjige"].DefaultView;
            Knjige_dataGridView.ClearSelection();
        }

        private void VracanjeKnjige_Load(object sender, EventArgs e)
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

            Clanovi_dataGridView.ClearSelection();
        }

        private void Clanovi_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateKnjigeDataGridView();
        }

        private void VratiKnjigu_button_Click(object sender, EventArgs e)
        {
            greska_label.ForeColor = Color.Red;
            greska_label.Text = "";

            if (Clanovi_dataGridView.SelectedRows.Count != 0)
            {
                if (Knjige_dataGridView.SelectedRows.Count != 0)
                {
                    int id_knjige = Convert.ToInt32(Knjige_dataGridView.SelectedRows[0].Cells["id_knjige"].Value);
                    int id_iznajmljivanja = Convert.ToInt32(Knjige_dataGridView.SelectedRows[0].Cells["id_iznajmljivanja"].Value);

                    if (proxy.VratiKnjigu(id_knjige, id_iznajmljivanja))
                    {
                        greska_label.ForeColor = Color.Green;
                        greska_label.Text = "Uspešno ste vratili iznajmljenu knjigu! ";
                        UpdateKnjigeDataGridView();
                    }
                    else
                    {
                        greska_label.ForeColor = Color.Red;
                        greska_label.Text = "Došlo je do greške pri vraćanju knjige! ";
                    }
                    
                }
                else
                {
                    greska_label.ForeColor = Color.Red;
                    greska_label.Text = "Niste izabrali knjigu koju želite da vratite. ";
                }

            }
            else
            {
                greska_label.ForeColor = Color.Red;
                greska_label.Text = "Niste izabrali člana. ";
            }

            Clanovi_dataGridView.ClearSelection();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
