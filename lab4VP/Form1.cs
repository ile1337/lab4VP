using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4VP
{
    public partial class Form1 : Form 
    {

        public List<Produkt> listOfProducts = new List<Produkt>();
       
        public Form1()
        {
            InitializeComponent();
            btnIzbrisiodKosnicka.Enabled = false;

        }

        private void btnNovProdukt_Click(object sender, EventArgs e)
        {
            NovProdukt prod = new NovProdukt(this.listOfProducts);
            DialogResult rez = prod.ShowDialog();
            if(rez == DialogResult.OK)
            {
                lbProdukti.Items.Add(prod.produkt);
            }
        }

        private void lbProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbProdukti.SelectedItem == null)
                return;

          
                btnIzbrisiodKosnicka.Enabled = true;
           
            tbIme.Text = (lbProdukti.SelectedItem as Produkt).Ime;
            tbKategorija.Text = (lbProdukti.SelectedItem as Produkt).Kategorija;
            tbCena.Text = (lbProdukti.SelectedItem as Produkt).Cena.ToString();

        }

        private void tbIme_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        private void tbKategorija_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodadivoKosnicka_Click(object sender, EventArgs e)
        {
           
            foreach (Produkt s in lbProdukti.SelectedItems)
            {
                lbKosnicka.Items.Add(s);
                int tmp = 0;
                for (int i = 0; i < lbKosnicka.Items.Count; ++i)
                {
                    tmp += (lbKosnicka.Items[i] as Produkt).Cena;
                }
                tbVkupno.Text = tmp.ToString();

            }
           

        }

        private void lbKosnicka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKosnicka.Items.Count == 0)
            {
                btnIzbrisiodKosnicka.Enabled = false;
            }
            else
            {
                btnIzbrisiodKosnicka.Enabled = true;
            }
        }

        private void tbVkupno_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnIzprazniKosnicka_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?", "Изпразни ја кошничката ?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    lbKosnicka.Items.Clear();
                    tbVkupno.Text = "0";
                    break;
                case DialogResult.No:
                    return;
                    break;
            }
           
        }

        private void btnIzprazniLista_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Дали сте сигурни дека сакате да ги испразните продуктите?", "Изпразни ја листата ?", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    lbProdukti.Items.Clear();
                    tbIme.Text = "";
                    tbCena.Text = "";
                    tbKategorija.Text = "";
                    break;
                case DialogResult.No:
                    return;
                    break;
            }
        }

        private void btnIzbrisiProdukt_Click(object sender, EventArgs e)
        {
            if(lbKosnicka.SelectedIndex != -1)
            {
                lbKosnicka.Items.Remove(lbKosnicka.SelectedItems[lbKosnicka.SelectedIndex]);
            }
            if(lbProdukti.SelectedIndex != -1)
            {
                lbProdukti.Items.Remove(lbProdukti.SelectedItems[lbProdukti.SelectedIndex]);
            }
            if(lbProdukti.Items.Count == 0)
            {
                tbIme.Text = "";
                tbCena.Text = "";
                tbKategorija.Text = "";
            }
            if (lbKosnicka.Items.Count == 0)
            {
                tbVkupno.Text = "0";
            }



        }
        
        private void btnIzbrisiodKosnicka_Click(object sender, EventArgs e)
        {
         
            if (lbKosnicka.SelectedIndex != -1)
            {
                int tmp = 0, tmp2=0, ftmp=0;
                btnIzbrisiodKosnicka.Enabled = true;
                for (int i = lbKosnicka.SelectedItems.Count - 1; i >= 0; i--)
                {
                   
                    if(lbKosnicka.SelectedItems[i] != null ) 
                        tmp += (lbKosnicka.SelectedItems[i] as Produkt).Cena;

                    tmp2 = Convert.ToInt32(tbVkupno.Text);
                    ftmp = tmp2 - tmp;
                    tbVkupno.Text = ftmp.ToString();
                    lbKosnicka.Items.Remove(lbKosnicka.SelectedItems[i]);
                }
                   

            }
            
            
        }
    }
}
