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
        private string motoroplysning;
        private double mål;
        private int byggeår;
        private string reperation;

        //Konstruktør
        public Både(string Navn, string Type, string Model, int Sejlnummer, string Motoroplysning, double Mål, int Byggeår, string Reperation)
        {
            this.navn = Navn;
            this.type = Type;
            this.model = Model;
            this.sejlnummer = Sejlnummer;
            this.motoroplysning = Motoroplysning;
            this.mål = Mål;
            this.byggeår = Byggeår;
            this.reperation = Reperation;
        }
        //Properties 
        // get betyder hent 
        // set betyder ændre værdien til noget andet (f.eks. brugerId)
        public string Navn
        {
            get { return this.navn; }
            set { this.navn = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public int Sejlnummer
        {
            get { return this.sejlnummer; }
            set { this.sejlnummer = value; }
        }
        public double Mål
        {
            get { return this.mål; }
            set { this.mål = value; }
        }
        public int Byggeår
        {
            get { return this.byggeår; }
            set { this.byggeår = value; }
        }
        public string Reperation
        {
            get { return this.reperation; }
            set { this.reperation = value; }
        }









    }
    

}
