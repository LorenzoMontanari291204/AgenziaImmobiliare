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
        //frmRicercaImmobile ri = new frmRicercaImmobile(ag);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Agenzia_Immobiliare ag = new Agenzia_Immobiliare();
            ag.AddBox(new Box("123", "Via Filippo Turati", "47865", "San Leo", "10 mq", "ABC", "2"));
            ag.AddAppartamento(new Appartamento("456", "Via Marecchia", "47865", "San Leo", "50 mq", "DEF", "7", "1"));
            ag.AddVilla(new Villa("ABCD", "Via Libiano", "789", "San Leo", "400 mq", "GHI", "25", "3", "50 mq"));
            ag.AddChiave(new Chiave("ABC"));
            ag.AddChiave(new Chiave("DEF"));
            ag.AddChiave(new Chiave("GHI"));
        }

        private void btnAddBox_Click(object sender, EventArgs e)
        {
            frmBox frmBox = new frmBox();
            frmBox.ShowDialog();
            
            ag.AddBox(new Box(frmBox.codice, frmBox.indirizzo, frmBox.cap, frmBox.città, frmBox.superficie, frmBox.chiave, frmBox.PostiAuto));
            ag.AddChiave(new Chiave(frmBox.chiave));
        }

        private void btnAddAppartamento_Click(object sender, EventArgs e)
        {
            frmAppartamento frmAppartamento = new frmAppartamento();
            frmAppartamento.ShowDialog();
            
            ag.AddAppartamento(new Appartamento(frmAppartamento.codice, frmAppartamento.indirizzo, frmAppartamento.cap, frmAppartamento.città, frmAppartamento.superficie, frmAppartamento.chiave, frmAppartamento.NumeroVani, frmAppartamento.NumeroBagni));
            ag.AddChiave(new Chiave(frmAppartamento.chiave));
        }

        private void btnAddVilla_Click(object sender, EventArgs e)
        {
            frmVilla frmVilla = new frmVilla();
            frmVilla.ShowDialog();
            ag.AddVilla(new Villa(frmVilla.codice, frmVilla.indirizzo, frmVilla.cap, frmVilla.città, frmVilla.superficie, frmVilla.chiave, frmVilla.NumeroVani, frmVilla.NumeroBagni, frmVilla.DimGiardino));
            ag.AddChiave(new Chiave(frmVilla.chiave));
        }

        private void btnRicercaImmobile_Click(object sender, EventArgs e)
        {
            frmRicercaImmobile frmRicercaImmobile = new frmRicercaImmobile(ag);
            frmRicercaImmobile.ShowDialog();
        }
    }
}
