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
    public partial class GlavnaForma : Form
    {
        static IServis proxy = new ServisClient();
        Dictionary<string, bool> izbori = new Dictionary<string, bool>();

        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void RefreshDataGridView()
        {
            try
            {
                DataSet dataSet = new DataSet();

                dataSet = proxy.PretragaBazePodataka(Pretraga_textBox.Text, izbori);

                Pretraga_dataGridView.DataSource = dataSet.Tables["RezultatPretrage"].DefaultView;

                Pretraga_dataGridView.ClearSelection();
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("           Došlo je do greške.\n  Veza sa serverom je prekinuta!", "Greška");
            }
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            Autor_button.Hide();

            Clan_checkBox.Checked = true;
            Knjiga_checkBox.Checked = true;
            Pisac_checkBox.Checked = true;

            izbori.Add("Clan", true);
            izbori.Add("Knjiga", true);
            izbori.Add("Pisac", true);

            RefreshDataGridView();
        }

        //-----                                  Pretraga                                   -----//

        private void Pretraga_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshDataGridView();
        }

        private void Clan_checkBox_Click(object sender, EventArgs e)
        {
            izbori["Clan"] = Clan_checkBox.Checked;
            RefreshDataGridView();
        }

        private void Knjiga_checkBox_Click(object sender, EventArgs e)
        {
            izbori["Knjiga"] = Knjiga_checkBox.Checked;
            RefreshDataGridView();
        }

        private void Pisac_checkBox_Click(object sender, EventArgs e)
        {
            izbori["Pisac"] = Pisac_checkBox.Checked;
            RefreshDataGridView();
        }

        private void ResetujFiltere_button_Click(object sender, EventArgs e)
        {
            Clan_checkBox.Checked = true;
            Knjiga_checkBox.Checked = true;
            Pisac_checkBox.Checked = true;

            izbori["Clan"] = true;
            izbori["Knjiga"] = true;
            izbori["Pisac"] = true;

            RefreshDataGridView();
        }

        private void DetaljnaPretraga_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            DetaljnaPretraga detaljnaPretragaForma = new DetaljnaPretraga();
            detaljnaPretragaForma.ShowDialog();
            this.Enabled = true;
            RefreshDataGridView();
        }

        //-----                                  Buttons                                   -----//

        private void SveTabele_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            SveTabele SveTabeleForma = new SveTabele();
            SveTabeleForma.ShowDialog();
            this.Enabled = true;
            RefreshDataGridView();
        }

        private void RegistrujClana_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            RegistrovanjeClana registrovanjeClanaForma = new RegistrovanjeClana();
            registrovanjeClanaForma.ShowDialog();
            this.Enabled = true;
            RefreshDataGridView();
        }

        private void IznajmiKnjigu_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            IznajmljivanjeKnjige iznajmljivanjeKnjigeForma = new IznajmljivanjeKnjige();
            iznajmljivanjeKnjigeForma.ShowDialog();
            this.Enabled = true;
            RefreshDataGridView();
        }

        private void VratiKnjigu_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            VracanjeKnjige vracanjeKnjigeForma = new VracanjeKnjige();
            vracanjeKnjigeForma.ShowDialog();
            this.Enabled = true;
        }

        private void RegistrujKnjigu_button_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            RegistrovanjeKnjige registrovanjeKnjigeForma = new RegistrovanjeKnjige();
            registrovanjeKnjigeForma.ShowDialog();
            this.Enabled = true;
            RefreshDataGridView();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinSizeReset_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(935, 645);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void Info_button_Click(object sender, EventArgs e)
        {
            string file = "E:\\2 Nikola\\Projects\\CMT project\\Biblioteka\\Assets\\Autor.pdf";
            System.Diagnostics.Process.Start(file);
        }
    }
}
