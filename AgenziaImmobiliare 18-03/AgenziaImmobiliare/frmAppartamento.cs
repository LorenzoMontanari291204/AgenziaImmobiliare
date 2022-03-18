using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenziaImmobiliare
{
    public partial class frmAppartamento : Form
    {
        //dichiarazione variabili
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public string cap { get; set; }
        public string città { get; set; }
        public string superficie { get; set; }
        public string NumeroVani { get; set; }
        public string NumeroBagni { get; set; }
        public string chiave { get; set; }
        public frmAppartamento()
        {
            InitializeComponent();
        }

        private void frmAppartamento_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvaAppartamento_Click(object sender, EventArgs e)
        {
            codice = txtAppartamentoCodice.Text;
            indirizzo = txtAppartamentoIndirizzo.Text;
            cap = txtAppartamentoCap.Text;
            città = txtAppartamentoCittà.Text;
            superficie = txtAppartamentoSuperficie.Text;
            NumeroVani = txtAppartamentoNumVani.Text;
            NumeroBagni = txtAppartamentoNumBagni.Text;
            chiave = txtBoxChiave.Text;
            if (codice != "" && indirizzo != "" && cap != "" && città != "" && superficie != "" &&
                NumeroVani != "" && NumeroBagni!="" && chiave != "")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Non sono state inserite tutte le informazioni");
            }
        }
    }
}
