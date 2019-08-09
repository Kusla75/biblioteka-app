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
    public partial class SveTabele : Form
    {
        static IServis proxy = new ServisClient();
        string izabrana_tabela;

        // Sluzi za namestanje podataka unutar tabele
        private void AdjustColumnWidth()
        {
            for (int i = 0; i < SveTabele_dataGridView.Columns.Count; ++i)
            {
                SveTabele_dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void Update_TabelaClanovi()
        {
            SveTabele_dataGridView.ReadOnly = false;
            DataSet dataSet = new DataSet();
            dataSet = proxy.SviClanovi();

            SveTabele_dataGridView.DataSource = dataSet.Tables["SviClanovi"].DefaultView;
            SveTabele_dataGridView.Columns["jmbg_clana"].ReadOnly = true;
            SveTabele_dataGridView.Columns["aktivan"].ReadOnly = true;

            AdjustColumnWidth();
            SveTabele_dataGridView.ClearSelection();
        }

        private void Update_TabelaKnjige()
        {
            SveTabele_dataGridView.ReadOnly = false;
            DataSet dataSet = new DataSet();
            dataSet = proxy.SveKnjige();

            SveTabele_dataGridView.DataSource = dataSet.Tables["SveKnjige"].DefaultView;
            SveTabele_dataGridView.Columns["id_knjige"].ReadOnly = true;
            SveTabele_dataGridView.Columns["jmbg_pisca"].ReadOnly = true;

            AdjustColumnWidth();
            SveTabele_dataGridView.ClearSelection();
        }

        private void Update_TabelaPisci()
        {
            SveTabele_dataGridView.ReadOnly = false;
            DataSet dataSet = new DataSet();
            dataSet = proxy.SviPisci();

            SveTabele_dataGridView.DataSource = dataSet.Tables["SviPisci"].DefaultView;
            SveTabele_dataGridView.Columns["jmbg_pisca"].ReadOnly = true;

            AdjustColumnWidth();
            SveTabele_dataGridView.ClearSelection();
        }

        private void Update_TabelaIznajmljivanja()
        {
            DataSet dataSet = new DataSet();
            dataSet = proxy.SvaIznajmljivanja();

            SveTabele_dataGridView.DataSource = dataSet.Tables["SvaIznajmljivanja"].DefaultView;
            
            foreach (DataGridViewColumn column in SveTabele_dataGridView.Columns)
            {
                column.ReadOnly = true;
            }

            SveTabele_dataGridView.Columns["datum_vracanja"].ReadOnly = false;

            AdjustColumnWidth();
            SveTabele_dataGridView.ClearSelection();
        }

        private void ResetFormElements()
        {
            Izmena_label.Text = "";
            Izmena_textBox.Text = "";
            Izmena_textBox.Enabled = false;
            DateTimePicker.Enabled = false;
            Greska_label.ForeColor = Color.Red;
            Greska_label.Text = "";
            Izmeni_button.Enabled = false;
        }

        public SveTabele()
        {
            InitializeComponent();
        }

        private void SveTabele_Load(object sender, EventArgs e)
        {
            ResetFormElements();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clanovi_button_Click(object sender, EventArgs e)
        {
            ResetFormElements();
            Update_TabelaClanovi();
            izabrana_tabela = "clan";

        }

        private void Knjige_button_Click(object sender, EventArgs e)
        {
            ResetFormElements();
            Update_TabelaKnjige();
            izabrana_tabela = "knjiga";

        }

        private void Pisci_button_Click(object sender, EventArgs e)
        {
            ResetFormElements();
            Update_TabelaPisci();
            izabrana_tabela = "pisac";

        }

        private void Iznajmljivanja_button_Click(object sender, EventArgs e)
        {
            ResetFormElements();
            Update_TabelaIznajmljivanja();
            izabrana_tabela = "iznajmio";

        }

        private void SveTabele_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResetFormElements();
                Izmena_textBox.Enabled = true;
                DateTimePicker.Enabled = true;
                Izmeni_button.Enabled = true;

                var index = SveTabele_dataGridView.SelectedCells[0].ColumnIndex;
                Izmena_label.Text = SveTabele_dataGridView.Columns[index].Name;
            
           
                if (SveTabele_dataGridView.SelectedCells[0].ReadOnly)
                {
                    Greska_label.ForeColor = Color.Red;
                    Greska_label.Text = "Sadržaj ove ćelije se ne može menjati! ";
                    Izmena_textBox.Enabled = false;
                    DateTimePicker.Enabled = false;
                    Izmeni_button.Enabled = false;
                }
                else
                {
                    if (SveTabele_dataGridView.SelectedCells[0].Value.GetType().ToString() == "System.DateTime")
                    {
                        Izmena_textBox.Enabled = false;
                        DateTimePicker.Enabled = true;

                        DateTimePicker.Value = Convert.ToDateTime(SveTabele_dataGridView.SelectedCells[0].Value);
                    }
                    else
                    {
                        DateTimePicker.Enabled = false;
                        Izmena_textBox.Text = SveTabele_dataGridView.SelectedCells[0].Value.ToString();
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                ResetFormElements();
            }

        }

        private void Izmeni_button_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da želiti da učinite izmenu?", "", MessageBoxButtons.YesNo);

            if (rezultat == DialogResult.Yes)
            {
                if (Greska_label.Text == "")
                {
                    var index = SveTabele_dataGridView.SelectedCells[0].ColumnIndex;
                    string naziv_kolone = SveTabele_dataGridView.Columns[index].Name;

                    index = SveTabele_dataGridView.SelectedCells[0].RowIndex;
                    string naziv_id_kolone = SveTabele_dataGridView.Columns[0].Name;
                    string id = SveTabele_dataGridView.Rows[index].Cells[naziv_id_kolone].Value.ToString();

                    string value_type = SveTabele_dataGridView.SelectedCells[0].Value.GetType().ToString();

                    switch (value_type)
                    {
                        case "System.Int32":
                            {
                                int num;

                                if (!int.TryParse(Izmena_textBox.Text, out num))
                                {
                                    Greska_label.Text = "Broj nije dobro uneta! ";
                                }

                            }
                            break;

                        case "System.String":
                            {
                                for (int i = 0; i < Izmena_textBox.Text.Length; ++i)
                                {
                                    int num = Convert.ToInt32(Izmena_textBox.Text[i]);

                                    if (!(Slovo.ProveriSlovo(num) || num == 32 || num == 64))
                                    {
                                        Greska_label.Text = "Reč nije dobro uneta! ";
                                        break;
                                    }
                                }

                            }
                            break;

                        case "System.DateTime":
                            {

                            }
                            break;

                        default: { Greska_label.Text = "Došlo je do greške! "; } break;
                    }

                    if (Greska_label.Text == "")
                    {
                        string vrednost;

                        if (value_type == "System.DateTime")
                        {
                            vrednost = DateTimePicker.Value.ToString();
                        }
                        else
                        {
                            vrednost = Izmena_textBox.Text;
                        }

                        if (proxy.IzmenaVrednostiTabele(izabrana_tabela, naziv_kolone, naziv_id_kolone, id, value_type, vrednost))
                        {
                            Greska_label.ForeColor = Color.Green;
                            Greska_label.Text = "Uspešno ste izmenili podatak! ";
                        }
                        else
                        {
                            Greska_label.Text = "Došlo je do greške! ";
                        }

                        switch (izabrana_tabela)
                        {
                            case "clan": { Update_TabelaClanovi(); } break;
                            case "knjiga": { Update_TabelaKnjige(); } break;
                            case "pisac": { Update_TabelaPisci(); } break;
                            case "iznajmio": { Update_TabelaIznajmljivanja(); } break;
                        }

                        ResetFormElements();

                    }
                }
            }

        }

    }
}
