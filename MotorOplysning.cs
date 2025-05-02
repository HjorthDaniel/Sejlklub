using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class MotorOplysning : Både //klassenavn
    {
        private bool benzin;
        private int hesteKræfter;

        public MotorOplysning(bool Benzin, int HesteKræfter, int Pris, bool Tilgængelighed, string Navn, string Type, string Model, int Sejlnummer, double Mål, int ByggeÅr, int SidsteBundmalingsÅrstal) : base(Navn, Type, Model, Sejlnummer, Mål, ByggeÅr, SidsteBundmalingsÅrstal)

        {
            this.benzin = Benzin;
            this.hesteKræfter = HesteKræfter;
        }
        //Get and set for Benzin
        public bool Benzin
        {
            get { return this.benzin; }
            set { this.benzin = value; }
        }
        //Get and set for Hestekræfter
        public int Hestekræfter
        {
            get { return this.hesteKræfter; }
            set { hesteKræfter = value; }
        }
    }
}
