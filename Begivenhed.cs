using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Begivenhed //klassenavn
    {
        //Felter - instance fields(attributter)
        private string navn;
        private string beskrivelse;
        private string sted;
        private int dato;
        private bool begrænsetAntalPladser;

        //Konstruktør
        public Begivenhed(string Navn, string Beskrivelse, string Sted, int Dato, bool BegrænsetAntalPladser)
        {
            this.navn = Navn;
            this.beskrivelse = Beskrivelse;
            this.sted = Sted;
            this.dato = Dato;
            this.begrænsetAntalPladser = BegrænsetAntalPladser;

        }
        //Properties
        // get betyder hent
        // set betyder ændre værdien til noget andet (f.eks. brugerId)
        public string Name
        {
            get { return this.navn; }
            set { this.navn = value; }

        }
        //Get and set for BESKRIVELSE
        public string Beskrivelse
        {
            get { return this.beskrivelse; }

            set { this.beskrivelse = value; }
        }
        //Get and set for STED
        public string Sted
        {
            get { return this.sted; }
            set { this.sted = value; }
        }
        //Get and set for DATO
        public int Dato
        {
            get { return this.dato; }
            set { this.dato = value; }
        }
        //Get and set for BegrænsetAntalPladser
        public bool BegrænsetAntalPladser
        {
            get { return this.begrænsetAntalPladser; }
            set { this.begrænsetAntalPladser = value; }
        }
    }
    //Metoder
}


