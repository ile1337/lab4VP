using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab4VP
{
    public partial class NovProdukt : Form
    {
        public List<Produkt> produkti { get; set; }
        public Produkt produkt { get; set; }

        public NovProdukt(List<Produkt> produkti)
        {
            this.produkti = produkti;
            InitializeComponent();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if((tbAddCena.Text != "") && (tbAddIme.Text != "") && (tbAddKategoija.Text != ""))
            {
                produkt = new Produkt();
                produkt.Cena = int.Parse(tbAddCena.Text);
                produkt.Ime = tbAddIme.Text;
                produkt.Kategorija = tbAddKategoija.Text;
                produkti.Add(produkt);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Мора да ги пополните сите полиња!");
                DialogResult = DialogResult.Cancel;
            }
            
        }

        private void tbAddIme_Validating(object sender, CancelEventArgs e)
        {
            if(tbAddIme.Text.Trim() == "")
            {
                errorProvider1.SetError(tbAddIme, "Името е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAddIme, null);
                e.Cancel = false;

            }
        }

        private void tbAddKategoija_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbAddKategoija_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddKategoija.Text.Trim() == "")
            {
                errorProvider1.SetError(tbAddKategoija, "Категоријата е задолжителна!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAddKategoija, null);
                e.Cancel = false;

            }
        }

        private void tbAddCena_Validating(object sender, CancelEventArgs e)
        {
            if (tbAddCena.Text.Trim() == "")
            {
                errorProvider1.SetError(tbAddCena, "Цената е задолжителна!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbAddCena, null);
                e.Cancel = false;

            }
        }
    }
}
