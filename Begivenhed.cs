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

        //Konstruktør
        public Begivenhed(string Name, string Beskrivelse, string Sted, int Dato)
        {
            this.navn = Name;
            this.beskrivelse = Beskrivelse;
            this.sted = Sted;
            this.dato = Dato;

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
        //Metoder
    }
}
