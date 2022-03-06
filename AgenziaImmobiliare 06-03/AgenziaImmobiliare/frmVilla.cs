using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenziaImmobiliare
{
    public partial class frmVilla : Form
    {
        //dichiarazione variabili
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public string cap { get; set; }
        public string città { get; set; }
        public string superficie { get; set; }
        public string NumeroVani { get; set; }
        public string NumeroBagni { get; set; }
        public string DimGiardino { get; set; }
        public frmVilla()
        {
            InitializeComponent();
        }

        private void frmVilla_Load(object sender, EventArgs e)
        {
            codice = txtVillaCodice.Text;
            indirizzo = txtVillaIndirizzo.Text;
            cap = txtVillaCap.Text;
            città = txtVillaCittà.Text;
            superficie = txtVillaSuperficie.Text;
            NumeroVani = txtVillaNumVani.Text;
            NumeroBagni = txtVillaNumBagni.Text;
            DimGiardino = txtVillaDimGiardino.Text;
            Close();
        }
    }
}
