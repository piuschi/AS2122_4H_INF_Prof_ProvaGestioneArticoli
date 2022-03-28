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


        // TODO: (8) aggiungere attributi privati di Articolo
        // ...

        public string descrizione { get; set; }
        public string unitaMisura { get; }
        public int codice { get; }
        public double prezzo { get; }

        public Articolo(int codice, string descrizione, string unitaMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaMisura} {prezzo} ({codice})";
        }
    }
}
