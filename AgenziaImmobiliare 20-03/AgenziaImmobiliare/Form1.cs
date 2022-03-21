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
            //istanziamento immobili di default
            ag.AddBox(new Box("123", "Via Filippo Turati", "47865", "San Leo", "10 mq", "abc", "2"));
            ag.AddAppartamento(new Appartamento("456", "Via Marecchia", "47865", "San Leo", "50 mq", "def", "7", "1"));
            ag.AddVilla(new Villa("789", "Via Libiano", "47865", "San Leo", "400 mq", "ghi", "25", "3", "50 mq"));
            ag.AddChiave(new Chiave("abc"));
            ag.AddChiave(new Chiave("def"));
            ag.AddChiave(new Chiave("ghi"));
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {
            //istanziamento frmBox
            frmBox frmBox = new frmBox();
            frmBox.ShowDialog();

            //controllo che il box non abbia variabili nulle
            if (frmBox.codice != "" && frmBox.indirizzo != "" && frmBox.cap != "" && frmBox.città != "" && frmBox.superficie != "" &&
                frmBox.PostiAuto != "" && frmBox.chiave != "")
            {
                if (frmBox.codice != null && frmBox.indirizzo != null && frmBox.cap != "" && frmBox.città != null && frmBox.superficie != null &&
                frmBox.PostiAuto != null && frmBox.chiave != null)
                {
                    //passaggio del nuovo box nella lista di box
                    ag.AddBox(new Box(frmBox.codice, frmBox.indirizzo, frmBox.cap, frmBox.città, frmBox.superficie, frmBox.chiave, frmBox.PostiAuto));
                    ag.AddChiave(new Chiave(frmBox.chiave));
                }
            }
        }

        private void btnAddAppartamento_Click(object sender, EventArgs e)
        {
            //istanziamento frmAppartamento
            frmAppartamento frmAppartamento = new frmAppartamento();
            frmAppartamento.ShowDialog();

            //controllo che l'appartamento non abbia variabili nulle
            if (frmAppartamento.codice != "" && frmAppartamento.indirizzo != "" && frmAppartamento.cap != "" && frmAppartamento.città != "" && frmAppartamento.superficie != "" &&
                frmAppartamento.NumeroVani != "" && frmAppartamento.NumeroBagni != "" && frmAppartamento.chiave != "")
            {
                if (frmAppartamento.codice != null && frmAppartamento.indirizzo != null && frmAppartamento.cap != null && frmAppartamento.città != null && frmAppartamento.superficie != null &&
                frmAppartamento.NumeroVani != null && frmAppartamento.NumeroBagni != null && frmAppartamento.chiave != null)
                {
                    //passaggio del nuovo appartamento nella lista di appartamenti
                    ag.AddAppartamento(new Appartamento(frmAppartamento.codice, frmAppartamento.indirizzo, frmAppartamento.cap, frmAppartamento.città, frmAppartamento.superficie, frmAppartamento.chiave, frmAppartamento.NumeroVani, frmAppartamento.NumeroBagni));
                    ag.AddChiave(new Chiave(frmAppartamento.chiave));
                }
            }
        }

        private void btnAddVilla_Click(object sender, EventArgs e)
        {
            //istanziamento frmVilla
            frmVilla frmVilla = new frmVilla();
            frmVilla.ShowDialog();

            //controllo che la villa non abbia variabili nulle
            if (frmVilla.codice != "" && frmVilla.indirizzo != "" && frmVilla.cap != "" && frmVilla.città != "" && frmVilla.superficie != "" &&
                frmVilla.NumeroVani != "" && frmVilla.NumeroBagni != "" && frmVilla.DimGiardino != "" && frmVilla.chiave != "")
            {
                if (frmVilla.codice != null && frmVilla.indirizzo != null && frmVilla.cap != "" && frmVilla.città != null && frmVilla.superficie != null &&
                frmVilla.NumeroVani != null && frmVilla.NumeroBagni != null && frmVilla.DimGiardino != null && frmVilla.chiave != null)
                {
                    //passaggio della nuova villa nella lista di ville
                    ag.AddVilla(new Villa(frmVilla.codice, frmVilla.indirizzo, frmVilla.cap, frmVilla.città, frmVilla.superficie, frmVilla.chiave, frmVilla.NumeroVani, frmVilla.NumeroBagni, frmVilla.DimGiardino));
                    ag.AddChiave(new Chiave(frmVilla.chiave));
                }
            }
        }

        private void btnRicercaImmobile_Click(object sender, EventArgs e)
        {
            //istanziamento frmRicercaImmobile
            frmRicercaImmobile frmRicercaImmobile = new frmRicercaImmobile(ag);
            frmRicercaImmobile.ShowDialog();
        }

        private void btnVisualizzaImmobili_Click(object sender, EventArgs e)
        {
            //istanziamento frmStampaImmobile
            frmStampaImmobile frmStampaImmobile = new frmStampaImmobile(ag);
            frmStampaImmobile.ShowDialog();
        }
    }
}
