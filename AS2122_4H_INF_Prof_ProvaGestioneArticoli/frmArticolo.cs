using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_4H_INF_Prof_ProvaGestioneArticoli
{
    public partial class frmArticolo : Form
    {
        DialogResult status = DialogResult.Cancel;

        private string descrizione;
        private string unitaMisura;
        private double prezzo;
        // ...

        public DialogResult Status { get { return status; } }

        public string Descrizione { get { return descrizione; } }
        public string UnitaMisura {  get { return unitaMisura; } }
        public double Prezzo { get { return prezzo; } }

        public frmArticolo()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // TODO: (7) passaggio all' attributo/property dei dati inseriti nella frmArticoli con controllo di valorizzazione del dato
            if (descrizione==null)
            {
                descrizione = Descrizione;
            }

            if  (unitaMisura==null)
            {
                unitaMisura = UnitaMisura;
            }

            status = DialogResult.OK;
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            status = DialogResult.Cancel;
            Close();
        }
    }
}
