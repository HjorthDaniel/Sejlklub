using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sejlklub
{
    public class Administrator : Bruger
    {

        private string titel;
        private double løn;


        public Administrator(string navn, string titel, double løn) : base(navn)
        {
            this.titel = titel;
            this.løn = løn;

            
        }
        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public double Løn
        {
            get { return løn; }
            set { løn = value; }
        }

        public void ÆndreBeskrivelse(Begivenhed begivenhed, string nyBeskrivelse)
        {
            begivenhed.Beskrivelse = nyBeskrivelse;
        }

        public void ÆndreNavn(Begivenhed begivenhed, string nytNavn)
        {
            begivenhed.Name = nytNavn;
        }

        public void ÆndreSted(Begivenhed begivenhed, string nytSted)
        {
            begivenhed.Sted = nytSted;
        }

        public void ÆndreDato(Begivenhed begivenhed, int nyDato)
        {
            begivenhed.Dato = nyDato;
        }

        public static Begivenhed OpretBegivenhed(string Navn, string Beskrivelse, string Sted, int Dato, bool BegrænsetAntalPladser)
        {
            return new Begivenhed(Navn, Beskrivelse, Sted, Dato,BegrænsetAntalPladser);
        }

        public override string ToString()
        {
            return $"Administrator: {Navn}, {løn}, {titel} ";
            
        }

        public string ToString2()
        {
            return $"Administrator: {Navn}, {løn}, {titel} ";
        }
        public static Udlejning UdlejBåde(int Pris, bool Tilgængelighed, string Navn, string Type, string Model, int Sejlnummer, double Mål, int ByggeÅr, int SidsteBundmalingsÅrstal)
        {
            return new Udlejning(Pris, Tilgængelighed, Navn, Type, Model, Sejlnummer, Mål, ByggeÅr, SidsteBundmalingsÅrstal);
        }
    }
}
