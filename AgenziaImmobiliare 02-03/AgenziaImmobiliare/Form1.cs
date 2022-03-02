using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenziaImmobiliare_Library;
using AgenziaImmobiliare;

namespace AgenziaImmobiliare
{
    public partial class Form1 : Form
    {
        Agenzia_Immobiliare ag = new Agenzia_Immobiliare();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Agenzia_Immobiliare ag = new Agenzia_Immobiliare();
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {
            frmBox frmBox = new frmBox();
            frmBox.ShowDialog();

            ag.AddBox(new Box(frmBox.codice, frmBox.indirizzo, frmBox.cap, frmBox.città, frmBox.superficie, frmBox.PostiAuto));
        }

        private void btnAddAppartamento_Click(object sender, EventArgs e)
        {
            frmAppartamento frmAppartamento = new frmAppartamento();
            frmAppartamento.ShowDialog();

            ag.AddAppartamento(new Appartamento(frmAppartamento.codice, frmAppartamento.indirizzo, frmAppartamento.cap, frmAppartamento.città, frmAppartamento.superficie, frmAppartamento.NumeroVani, frmAppartamento.NumeroBagni));
        }

        private void btnAddVilla_Click(object sender, EventArgs e)
        {
            frmVilla frmVilla = new frmVilla();
            frmVilla.ShowDialog();

            ag.AddVilla(new Villa(frmVilla.codice, frmVilla.indirizzo, frmVilla.cap, frmVilla.città, frmVilla.superficie, frmVilla.NumeroVani, frmVilla.NumeroBagni, frmVilla.DimGiardino));
        }
    }
}
