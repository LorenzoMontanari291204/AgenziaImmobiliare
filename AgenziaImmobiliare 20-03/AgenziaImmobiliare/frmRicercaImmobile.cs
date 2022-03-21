using AgenziaImmobiliare_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenziaImmobiliare
{
    public partial class frmRicercaImmobile : Form
    {
        Agenzia_Immobiliare ag;
        //dichiarazione variabili
        public string chiave;
        public frmRicercaImmobile(Agenzia_Immobiliare ag)
        {
            InitializeComponent();
            this.ag = ag;
        }
        private void btnVisulBox_Click(object sender, EventArgs e)
        {
            chiave = txtBoxChiaveBox.Text;
            List<Box> Box = ag.RicercaBox(chiave, ag);
            foreach (Box b in Box)
            {
                lblBox.Text = b.Stampa();
            }
        }

        private void frmRicercaImmobile_Load(object sender, EventArgs e)
        {

        }
        private void btnVisualAppartamento_Click(object sender, EventArgs e)
        {
            chiave = txtBoxChiaveAppartamento.Text;
            List<Appartamento> Appartamenti = ag.RicercaAppartamento(chiave, ag);
            foreach (Appartamento a in Appartamenti)
            {
                lblAppartamento.Text = a.Stampa();
            }
        }

        private void btnVisualVilla_Click(object sender, EventArgs e)
        {
            chiave = txtBoxChiaveVilla.Text;
            List<Villa> Ville = ag.RicercaVilla(chiave, ag);
            foreach (Villa v in Ville)
            {
                lblVilla.Text = v.Stampa();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nell' agenzia immobiliare sono presenti 3 immobili di default" +
            " (un box, un appartamento e una villa) con le rispettive chiavi visibili in alto");
        }
    }

}
