using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestione_campionato
{
    // delegato alla gestione dell'evento cambio risultato
    public delegate void CambioRisultato( int partita, int squadra );
    
    public partial class FormAggiorna : Form
    {

        // creo un nuovo evento
        public event CambioRisultato RisultatoCambiato;

        public FormAggiorna()
        {
            InitializeComponent();
        }

        private void btn_casa_Click(object sender, EventArgs e)
        {
            squadra = 0;
            AvvertiModifica();
        }

        private void btn_ospiti_Click(object sender, EventArgs e)
        {
            squadra = 1;
            AvvertiModifica();
        }

        void AvvertiModifica()
        {
            par = Convert.ToInt32(nu_part.Value);

            if (RisultatoCambiato != null)
                RisultatoCambiato(partita,squadra);
        }
    }
}
