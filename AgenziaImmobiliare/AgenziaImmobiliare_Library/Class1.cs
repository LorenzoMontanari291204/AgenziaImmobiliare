using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenziaImmobiliare_Library
{
    public class Agenzia_Immobiliare
    {
        public List<Box> Box;
        public List<Appartamento> Appartamenti;
        public List<Villa> Ville;
    }
    public class Immobile
    {
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public string cap { get; set; }
        public string città { get; set; }

        public Immobile(string codice, string indirizzo, string cap, string città)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;

        }

        public string tipoimmobile()
        {
            return " ";
        }

        public void RicercaImmobile()
        {

        }
    }
    public class Villa : Immobile
    {
        public string NumPostiAuto { get; set; }
        public double mqGiardino { get; set; }
        public Villa(string codice, string indirizzo, string cap, string città, string NumPostiAuto, double mqGiardino) : base(codice, indirizzo, cap, città)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.NumPostiAuto = NumPostiAuto;
            this.mqGiardino = mqGiardino;
        }
    }

    public class Box : Immobile
    {
        public string NumeroPostiAuto { get; set; }
        public Box(string codice, string indirizzo, string cap, string città, string NumeroPostiAuto) : base(codice, indirizzo, cap, città)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.NumeroPostiAuto = NumeroPostiAuto;
        }
    }

    public class Appartamento : Immobile
    {
        public string NumVani { get; set; }
        public string NumBagni { get; set; }
        public Appartamento(string codice, string indirizzo, string cap, string città, string numVani, string numBagni) : base(codice, indirizzo, cap, città)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.NumVani = numVani;
            this.NumBagni = NumBagni;
        }
    }


}
