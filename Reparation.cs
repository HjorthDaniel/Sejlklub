using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Reparation : Både
    {
        //Felter - instance fields(attributter)
        private bool rorpindKnækket;
        private bool bomnedhalKnækket;

        //Konstruktør

        public Reparation(bool RorpindKnækket, bool BomnedhalKnækket, string Navn, string Type, string Model, int Sejlnummer, double Mål, int ByggeÅr, int SidsteBundmalingsÅrstal) : base(Navn, Type, Model, Sejlnummer, Mål, ByggeÅr, SidsteBundmalingsÅrstal)
        {
            this.rorpindKnækket = RorpindKnækket;
            this.bomnedhalKnækket = BomnedhalKnækket;
            //Properties
            // get betyder hent
            // set betyder ændre værdien til noget andet (f.eks. brugerId)

        }
        public bool RorpindKnækket
        {
            get { return this.rorpindKnækket; }
            set { this.rorpindKnækket = value; }
        }
        public bool BomnedhalKnækket
        {
            get { return this.bomnedhalKnækket; }
            set { this.bomnedhalKnækket = value; }
        }

    }
}





