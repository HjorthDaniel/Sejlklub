using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Udlejning : Både
    {
        //Felter - instance fields(attributter)
        private int pris;
        private bool tilgængelighed;

        //Konstruktør

        public Udlejning(int Pris, bool Tilgængelighed, string Navn, string Type, string Model, int Sejlnummer, double Mål, int ByggeÅr, int SidsteBundmalingsÅrstal) : base(Navn, Type, Model, Sejlnummer, Mål, ByggeÅr, SidsteBundmalingsÅrstal)
        {
            this.pris = Pris;
            this.tilgængelighed = Tilgængelighed;
        }
        //Properties
        // get betyder hent
        // set betyder ændre værdien til noget andet (f.eks. brugerId)
        public int Pris
        {
            get { return this.pris; }
            set { this.pris = value; }

        }
        public bool Tilgængelighed
        {
            get { return this.tilgængelighed;}  
            set { this.tilgængelighed = value; }    
        }
    }
}
