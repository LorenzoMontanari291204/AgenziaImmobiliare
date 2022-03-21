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
    public partial class frmStampaImmobile : Form
    {
        Agenzia_Immobiliare _ag;
        public frmStampaImmobile(Agenzia_Immobiliare ag)
        {
            _ag = ag;
            InitializeComponent();
        }

        private void frmStampaImmobile_Load(object sender, EventArgs e)
        {

        }

        private void btnStampaBox_Click(object sender, EventArgs e)
        {
            List<Box> Box = _ag.StampaBox(_ag);
            foreach (Box b in Box)
            {
                listBoxBox.Items.Add(b.StampaImmobili());
            }
        }

        private void btnStampaAppartamenti_Click(object sender, EventArgs e)
        {
            List<Appartamento> Appartamenti = _ag.StampaAppartamenti(_ag);
            foreach(Appartamento a in Appartamenti)
            {
                listBoxAppartamenti.Items.Add(a.StampaImmobili());
            }
        }

        private void btnStampaVille_Click(object sender, EventArgs e)
        {
            List<Villa> Ville = _ag.StampaVille(_ag);
            foreach (Villa v in Ville)
            {
                listBoxVille.Items.Add(v.StampaImmobili());
            }
        }
    }
}
