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
    public partial class FormAgg : Form
    {
        public FormAgg()
        {
            InitializeComponent();
            cb_goal.SelectedIndex = 0;  // Compare "Casa" di deafult
        }

        private void FormAgg_Load(object sender, EventArgs e)
        {

        }
    }
}
