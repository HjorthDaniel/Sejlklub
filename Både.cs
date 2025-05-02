using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Både //klassenavn
    {
        //Felter - instance fields(attributter)
        private string navn;
        private string type;
        private string model;
        private int sejlnummer;
        private double mål;
        private int byggeår;
        private int sidsteBundmalingsÅrstal;

        //Konstruktør
        public Både(string Navn, string Type, string Model, int Sejlnummer, double Mål,int ByggeÅr, int SidsteBundmalingsÅrstal)
        {
            this.navn = Navn;
            this.type = Type;
            this.model = Model;
            this.sejlnummer = Sejlnummer;
            this.mål = Mål;
            this.byggeår = ByggeÅr;
            this.sidsteBundmalingsÅrstal = SidsteBundmalingsÅrstal;
           
        }
        //Properties
        // get betyder hent
        // set betyder ændre værdien til noget andet (f.eks. brugerId)

        //Get and set for NAVN
        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }
        //Get for TYPE
        public string Type
        {
            get { return this.type; }
        }
        //Get  for MODEL
        public string Model
        {
            get { return model; }
         
        }
        //Get  for SEJLNUMMER
        public int Sejlnummer
        {
            get { return this.sejlnummer; }
        
        }
        //Get and set for MÅL
        public double Mål
        {
            get { return this.mål; }
            set { this.mål = value; }
        }
        //Get and set for BYGGEÅR
        public int Byggeår
        {
            get { return this.byggeår; }
        }

        public int SidsteBundmalingsÅrstal
        {
            get { return this.sidsteBundmalingsÅrstal; }
            set { this.sidsteBundmalingsÅrstal = value; }
        }

    }


}
