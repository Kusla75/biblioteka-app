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
    public partial class DetaljnaPretraga : Form
    {
        static IServis proxy = new ServisClient();

        private void ResetujSve()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker.Value = new DateTime(2019, 5, 9);
            ResetujInfoLabel();
        }

        private void ResetujInfoLabel()
        {
            Info_label.ForeColor = Color.Black;
            Info_label.TextAlign = ContentAlignment.MiddleLeft;
            Info_label.Text = "Pretraga:";
        }

        private void PromeniElemZaClana()
        {
            DataSet dataSet = new DataSet();
            dataSet = proxy.SviClanovi();

            label1.Text = "Ime:";
            label2.Text = "Prezime:";
            label3.Text = "Email:";
            label4.Text = "Datum rođenja:";

            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            dateTimePicker.Visible = true;
        }

        private void PromeniElemZaKnjigu()
        {
            DataSet dataSet = new DataSet();
            dataSet = proxy.SveKnjige();

            label1.Text = "Naziv knjige:";
            label2.Text = "Količina:";
            label3.Text = "Godina izdavanja:";

            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = false;
            dateTimePicker.Visible = false;
        }

        private void PromeniElemZaPisca()
        { 
            DataSet dataSet = new DataSet();
            dataSet = proxy.SviClanovi();

            label1.Text = "Ime:";
            label2.Text = "Prezime:";
            label4.Text = "Datum rođenja:";

            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = true;
            dateTimePicker.Visible = true;
        }

        public DetaljnaPretraga()
        {
            InitializeComponent();
        }

        private void DetaljnaPretraga_Load(object sender, EventArgs e)
        {
            Clan_radioButton.Checked = true;

            PromeniElemZaClana();
        }

        private void Clan_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PromeniElemZaClana();
            ResetujSve();
            Pretraga_dataGridView.DataSource = null;
        }

        private void Knjiga_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PromeniElemZaKnjigu();
            ResetujSve();
            Pretraga_dataGridView.DataSource = null;
        }

        private void Pisac_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            PromeniElemZaPisca();
            ResetujSve();
            Pretraga_dataGridView.DataSource = null;
        }

        private void Pretraga_button_Click(object sender, EventArgs e)
        {
            if (Clan_radioButton.Checked)
            {
                DataSet dataSet = proxy.DetaljnaPretragaClana(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker.Value);

                Pretraga_dataGridView.DataSource = dataSet.Tables["RezultatPretrage"].DefaultView;
                Pretraga_dataGridView.ClearSelection();
            }

            else if (Knjiga_radioButton.Checked)
            {
                string greskaString = "";
                int kolicina;
                int godina_izdavanja;

                if (textBox2.Text != "")
                {
                    if (int.TryParse(textBox2.Text, out kolicina))
                    {
                        kolicina = Convert.ToInt32(textBox2.Text);
                    }
                    else { greskaString += "Količina nije dobro uneta. "; textBox2.Clear(); }
                }
                else { kolicina = 0; }

                if (textBox3.Text != "")
                {
                    if (int.TryParse(textBox3.Text, out godina_izdavanja))
                    {
                        godina_izdavanja = Convert.ToInt32(textBox3.Text);
                    }
                    else { greskaString += "Godina izdavanja nije dobro uneta. "; textBox3.Clear(); }
                }
                else { godina_izdavanja = 0; }

                if (greskaString == "")
                {
                    DataSet dataSet = proxy.DetaljnaPretragaKnjige(textBox1.Text, kolicina, godina_izdavanja);

                    Pretraga_dataGridView.DataSource = dataSet.Tables["RezultatPretrage"].DefaultView;
                    Pretraga_dataGridView.ClearSelection();
                    ResetujInfoLabel();
                }
                else
                {
                    Info_label.ForeColor = Color.Red;
                    Info_label.TextAlign = ContentAlignment.MiddleCenter;
                    Info_label.Text = greskaString;
                }
            }

            else if (Pisac_radioButton.Checked)
            {
                DataSet dataSet = proxy.DetaljnaPretragaPisca(textBox1.Text, textBox2.Text, dateTimePicker.Value);

                Pretraga_dataGridView.DataSource = dataSet.Tables["RezultatPretrage"].DefaultView;
                Pretraga_dataGridView.ClearSelection();
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
