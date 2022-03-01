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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Agenzia_Immobiliare ag = new Agenzia_Immobiliare();
        }

        private void btnAddImmobile_Click(object sender, EventArgs e)
        {
            frmBox frmImmobile = new frmBox();
            frmImmobile.ShowDialog();
        }
    }
}
