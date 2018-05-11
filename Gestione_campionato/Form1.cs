using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gestione_campionato
{
    public partial class Form1 : Form
    {
        FormAgg fg;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_carica(object sender, EventArgs e)
        {
            Carica("Campionato.txt");
        }

        StreamReader = new StreamReader sr("Campionato.txt");

        private void Carica(string nomefile)
        {
            for (int i=0; i<10; i++)
            {
                sr.ReadLine();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visualizza();
        }

        // Visualizza su listView
        void Visualizza()
        {
            listPart.Items.Clear();
            ListViewItem item;
            for (int i = 0; i < 10; i++)
            {
                item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add("Squadra in Casa" + (i+1).ToString());
                item.SubItems.Add("Squadra Ospite" + (i+1).ToString());
                item.SubItems.Add("0");
                item.SubItems.Add("0");
                listPart.Items.Add(item);
            }
        }

        private void btn_aggiorna_Click_1(object sender, EventArgs e)
        {
            if (fg == null)
            {
                fg = new FormAggiorna();
                fg.RisultatoCambiato += AggiornaPartite;
            }
            fg.Show();
        }

        void AggiornaPartite(int riga, int colonna)
        {
            gior.tab[r, c].goal++;
    }

        private void aggiornaToolStripMenuItem_Click()
        {
        
        }
}
