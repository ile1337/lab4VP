using System;
using System.Collections.Generic;
using System.Text;

namespace lab4VP
{
    public class Produkt
    {
        public int Cena { get; set; }

        public string Kategorija { get; set; }

        public string Ime { get; set; }

        public Produkt (string Ime, string Kategorija, int Cena)
        {
            this.Cena = Cena;
            this.Ime = Ime;
            this.Kategorija = Kategorija;
        }
        
        public Produkt()
        {

        }

        public void RemoveItem()
        {
            this.Cena = 0;
            this.Ime = null;
            this.Kategorija = null;
        }

        public override string ToString()
        {
            return string.Format("{0}", Ime);
        }

    }
}
