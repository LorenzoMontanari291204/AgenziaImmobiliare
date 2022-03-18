using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenziaImmobiliare
{
    public partial class frmBox : Form
    {
        //dichiarazione variabili
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public string cap { get; set; }
        public string città { get; set; }
        public string superficie { get; set; }
        public string PostiAuto { get; set; }
        public string chiave { get; set; }
        public frmBox()
        {
            InitializeComponent();
        }

        private void frmBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvaBox_Click(object sender, EventArgs e)
        {
            codice = txtBoxCodice.Text;
            indirizzo = txtBoxIndirizzo.Text;
            cap = txtBoxCap.Text;
            città = txtBoxCittà.Text;
            superficie = txtBoxSuperificie.Text;
            PostiAuto = txtBoxPostiAuto.Text;
            chiave = txtBoxChiave.Text;
            if (codice!="" && indirizzo!="" && cap!="" && città!="" && superficie!="" &&
                PostiAuto!="" && chiave != "")
            {
                Close();
            }
            else
            {
                MessageBox.Show("Non sono state inserite tutte le informazioni");
            }
            
        }

        private void frmBox_Load_1(object sender, EventArgs e)
        {

        }
    }
}
