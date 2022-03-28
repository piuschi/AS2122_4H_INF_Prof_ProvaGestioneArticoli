using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        public Articolo()
        {

        }
       
        private string Descrizione;
        private string UnitaMisura;
        private int Codice;
        private double Prezzo;

        public string descrizione { get; set; }
        public string unitaMisura { get; }
        public int codice { get; }
        public double prezzo { get; }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            
            this.Descrizione = descrizione;
            this.Codice = codice;
            this.UnitaMisura = unitaMisura;
            this.Prezzo = prezzo;
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}
