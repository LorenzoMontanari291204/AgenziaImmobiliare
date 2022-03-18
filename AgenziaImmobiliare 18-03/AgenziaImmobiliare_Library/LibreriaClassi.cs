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
        public List<Chiave> Chiavi;
        
        public Agenzia_Immobiliare()
        {
            this.Box = new List<Box>();
            this.Appartamenti = new List<Appartamento>();
            this.Ville = new List<Villa>();
            this.Chiavi = new List<Chiave>();                                            
        }
        public List<Box> RicercaBox(string c, Agenzia_Immobiliare ag)
        {
            //restituisce un valore che indica se è presente una stringa
            return this.Box.FindAll(b => b.Contains(c));
        }
        public List<Appartamento> RicercaAppartamento(string c, Agenzia_Immobiliare ag)
        {
            return this.Appartamenti.FindAll(a => a.Contains(c));
        }
        public List<Villa> RicercaVilla(string c, Agenzia_Immobiliare ag)
        {
            return this.Ville.FindAll(v => v.Contains(c));
        }
        public void AddChiave(Chiave c)
        {
            Chiavi.Add(c);
        }
        public void AddBox(Box b)
        {
            Box.Add(b);
        }
        public void AddAppartamento(Appartamento a)
        {
            Appartamenti.Add(a);
        }
        public void AddVilla(Villa v)
        {
            Ville.Add(v);
        }
    }
    public class Immobile
    {
        public string codice { get; set; }
        public string indirizzo { get; set; }
        public string cap { get; set; }
        public string città { get; set; }
        public string superficie { get; set; }
        public string chiave { get; set; }

        public Immobile(string codice, string indirizzo, string cap, string città, string superficie, string chiave)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.superficie = superficie;
            this.chiave = chiave;
        }
        public virtual bool Contains(string c)
        {
            if (this.chiave.Contains(c)) return true;
            else return false;
        }
        public virtual string Stampa()
        {
            return "";
        }

        public string NomeChiave
        {
            get { return chiave; }
        }
    }
    public class Villa : Immobile
    {
        public string NumVani { get; set; }
        public string NumBagni { get; set; }
        public string dimGiardino { get; set; }
        public Villa(string codice, string indirizzo, string cap, string città, string superficie, string chiave, string NumVani, string NumBagni, string dimGiardino) : base(codice, indirizzo, cap, città, superficie, chiave)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.superficie = superficie;
            this.NumVani = NumVani;
            this.NumBagni = NumBagni;
            this.dimGiardino = dimGiardino;
            this.chiave = chiave;
        }
        public override bool Contains(string c)
        {
            if (base.Contains(c)) return true;
            else return false;
        }
        public override string Stampa()
        {
            return "Villa:\nCodice: " + this.codice + "\nIndirizzo: " + this.indirizzo + "\nCap: " +
            this.cap + "\nCitta: " + this.città + "\nSuperficie: " + this.superficie + "\nNumero Vani: " +
            this.NumVani + "\nNumero Bagni: " + this.NumBagni + "\nDimensione giardino: " + this.dimGiardino;
        }
    }

    public class Box : Immobile
    {
        public string NumeroPostiAuto { get; set; }
        public Box(string codice, string indirizzo, string cap, string città, string superficie, string chiave, string NumeroPostiAuto) : base(codice, indirizzo, cap, città, superficie, chiave)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.superficie = superficie;
            this.NumeroPostiAuto = NumeroPostiAuto;
            this.chiave = chiave;
        }
        public string Chiave
        {
            get { return chiave; }
        }
        public override bool Contains(string c)
        {
            if (base.Contains(c)) return true;
            else return false;
        }
        public override string Stampa()
        {
            return "Box:\nCodice: " + this.codice + "\nIndirizzo: " + this.indirizzo + "\nCap: " +
            this.cap + "\nCitta: " + this.città + "\nSuperficie: " + this.superficie + "\nNumero Posti Auto: " +
            this.NumeroPostiAuto;
        }
    }

    public class Appartamento : Immobile
    {
        public string NumVani { get; set; }
        public string NumBagni { get; set; }
        public Appartamento(string codice, string indirizzo, string cap, string città, string superficie, string chiave, string numVani, string numBagni) : base(codice, indirizzo, cap, città, superficie, chiave)
        {
            this.codice = codice;
            this.indirizzo = indirizzo;
            this.cap = cap;
            this.città = città;
            this.superficie = superficie;
            this.NumVani = numVani;
            this.NumBagni = numBagni;
            this.chiave = chiave;
        }
        public override bool Contains(string c)
        {
            if (base.Contains(c)) return true;
            else return false;
        }
        public override string Stampa()
        {
            return "Appartamento:\nCodice: " + this.codice + "\nIndirizzo: " + this.indirizzo + "\nCap: " +
            this.cap + "\nCitta: " + this.città + "\nSuperficie: " + this.superficie + "\nNumero Vani: " +
            this.NumVani + "\nNumero Bagni: " + this.NumBagni;
        }
    }

    public class Chiave
    {
        public string chiave { get; set; }
        public Chiave(string chiave)
        {
            this.chiave = chiave;
        }
        public string RitornaChiave
        {
            get { return chiave; }
        }
    }
}
